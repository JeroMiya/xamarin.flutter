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
using FlutterSDK.Material.Drawerheader;
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
using FlutterSDK.Material.Inksplash;
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
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
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
namespace FlutterSDK.Semantics.Semantics
{
    /// <Summary>
    /// Signature for a function that is called for each [SemanticsNode].
    ///
    /// Return false to stop visiting nodes.
    ///
    /// Used by [SemanticsNode.visitChildren].
    /// </Summary>
    public delegate bool SemanticsNodeVisitor(FlutterSDK.Semantics.Semantics.SemanticsNode node);
    /// <Summary>
    /// Signature for [SemanticsAction]s that move the cursor.
    ///
    /// If `extendSelection` is set to true the cursor movement should extend the
    /// current selection or (if nothing is currently selected) start a selection.
    /// </Summary>
    public delegate void MoveCursorHandler(bool extendSelection);
    /// <Summary>
    /// Signature for the [SemanticsAction.setSelection] handlers to change the
    /// text selection (or re-position the cursor) to `selection`.
    /// </Summary>
    public delegate void SetSelectionHandler(FlutterSDK.Services.Textediting.TextSelection selection);
    public delegate void _SemanticsActionHandler(object args);
    internal static class SemanticsDefaultClass
    {
        /// <Summary>
        /// In tests use this function to reset the counter used to generate
        /// [SemanticsNode.id].
        /// </Summary>
        internal static void DebugResetSemanticsIdCounter()
        {
            SemanticsDefaultClass.SemanticsNode._LastIdentifier = 0;
        }



        /// <Summary>
        /// Converts `point` to the `node`'s parent's coordinate system.
        /// </Summary>
        internal static Offset _PointInParentCoordinates(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterBinding.UI.Offset point)
        {
            if (node.Transform == null)
            {
                return point;
            }

            Vector3 vector = Vector3(point.Dx, point.Dy, 0.0);
            node.Transform.Transform3(vector);
            return new Offset(vector.x, vector.y);
        }



        /// <Summary>
        /// Sorts `children` using the default sorting algorithm, and returns them as a
        /// new list.
        ///
        /// The algorithm first breaks up children into groups such that no two nodes
        /// from different groups overlap vertically. These groups are sorted vertically
        /// according to their [_SemanticsSortGroup.startOffset].
        ///
        /// Within each group, the nodes are sorted using
        /// [_SemanticsSortGroup.sortedWithinVerticalGroup].
        ///
        /// For an illustration of the algorithm see http://bit.ly/flutter-default-traversal.
        /// </Summary>
        internal static List<FlutterSDK.Semantics.Semantics.SemanticsNode> _ChildrenInDefaultOrder(List<FlutterSDK.Semantics.Semantics.SemanticsNode> children, TextDirection textDirection)
        {
            List<_BoxEdge> edges = new List<_BoxEdge>() { };
            foreach (SemanticsNode child in children)
            {

                Rect childRect = child.Rect.Deflate(0.1);
                edges.Add(new _BoxEdge(isLeadingEdge: true, offset: SemanticsDefaultClass._PointInParentCoordinates(child, childRect.TopLeft).Dy, node: child));
                edges.Add(new _BoxEdge(isLeadingEdge: false, offset: SemanticsDefaultClass._PointInParentCoordinates(child, childRect.BottomRight).Dy, node: child));
            }

            edges.Sort();
            List<_SemanticsSortGroup> verticalGroups = new List<_SemanticsSortGroup>() { };
            _SemanticsSortGroup group = default(_SemanticsSortGroup);
            int depth = 0;
            foreach (_BoxEdge edge in edges)
            {
                if (edge.IsLeadingEdge)
                {
                    depth += 1;
                    group = (group == null ? new _SemanticsSortGroup(startOffset: edge.Offset, textDirection: textDirection) : group);
                    group.Nodes.Add(edge.Node);
                }
                else
                {
                    depth -= 1;
                }

                if (depth == 0)
                {
                    verticalGroups.Add(group);
                    group = null;
                }

            }

            verticalGroups.Sort();
            return verticalGroups.Expand((_SemanticsSortGroup group) => =>group.SortedWithinVerticalGroup()).ToList();
        }



        internal static string _ConcatStrings(string thisString = default(string), string otherString = default(string), TextDirection thisTextDirection = default(TextDirection), TextDirection otherTextDirection = default(TextDirection))
        {
            if (otherString.IsEmpty()) return thisString;
            string nestedLabel = otherString;
            if (thisTextDirection != otherTextDirection && otherTextDirection != null)
            {
                switch (otherTextDirection) { case TextDirection.Rtl: nestedLabel = $"'{UnicodeDefaultClass.Unicode.RLE}{nestedLabel}{UnicodeDefaultClass.Unicode.PDF}'"; break; case TextDirection.Ltr: nestedLabel = $"'{UnicodeDefaultClass.Unicode.LRE}{nestedLabel}{UnicodeDefaultClass.Unicode.PDF}'"; break; }
            }

            if (thisString.IsEmpty()) return nestedLabel;
            return $"'{thisString}\n{nestedLabel}'";
        }



    }

    /// <Summary>
    /// Base class for all sort keys for [SemanticsProperties.sortKey] accessibility
    /// traversal order sorting.
    ///
    /// Sort keys are sorted by [name], then by the comparison that the subclass
    /// implements. If [SemanticsProperties.sortKey] is specified, sort keys within
    /// the same semantic group must all be of the same type.
    ///
    /// Keys with no [name] are compared to other keys with no [name], and will
    /// be traversed before those with a [name].
    ///
    /// If no sort key is applied to a semantics node, then it will be ordered using
    /// a platform dependent default algorithm.
    ///
    /// See also:
    ///
    ///  * [OrdinalSortKey] for a sort key that sorts using an ordinal.
    /// </Summary>
    public interface ISemanticsSortKey
    {
        int CompareTo(FlutterSDK.Semantics.Semantics.SemanticsSortKey other);
        int DoCompare(FlutterSDK.Semantics.Semantics.SemanticsSortKey other);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        string Name { get; }
    }


    public interface ISemanticsConfiguration { }

    public class SemanticsConfiguration
    {
        internal virtual bool _IsSemanticBoundary { get; set; }
        /// <Summary>
        /// Whether the configuration forces all children of the owning [RenderObject]
        /// that want to contribute semantic information to the semantics tree to do
        /// so in the form of explicit [SemanticsNode]s.
        ///
        /// When set to false children of the owning [RenderObject] are allowed to
        /// annotate [SemanticsNode]s of their parent with the semantic information
        /// they want to contribute to the semantic tree.
        /// When set to true the only way for children of the owning [RenderObject]
        /// to contribute semantic information to the semantic tree is to introduce
        /// new explicit [SemanticsNode]s to the tree.
        ///
        /// This setting is often used in combination with [isSemanticBoundary] to
        /// create semantic boundaries that are either writable or not for children.
        /// </Summary>
        public virtual bool ExplicitChildNodes { get; set; }
        /// <Summary>
        /// Whether the owning [RenderObject] makes other [RenderObject]s previously
        /// painted within the same semantic boundary unreachable for accessibility
        /// purposes.
        ///
        /// If set to true, the semantic information for all siblings and cousins of
        /// this node, that are earlier in a depth-first pre-order traversal, are
        /// dropped from the semantics tree up until a semantic boundary (as defined
        /// by [isSemanticBoundary]) is reached.
        ///
        /// If [isSemanticBoundary] and [isBlockingSemanticsOfPreviouslyPaintedNodes]
        /// is set on the same node, all previously painted siblings and cousins up
        /// until the next ancestor that is a semantic boundary are dropped.
        ///
        /// Paint order as established by [RenderObject.visitChildrenForSemantics] is
        /// used to determine if a node is previous to this one.
        /// </Summary>
        public virtual bool IsBlockingSemanticsOfPreviouslyPaintedNodes { get; set; }
        internal virtual bool _HasBeenAnnotated { get; set; }
        /// <Summary>
        /// The actions (with associated action handlers) that this configuration
        /// would like to contribute to the semantics tree.
        ///
        /// See also:
        ///
        ///  * [addAction] to add an action.
        /// </Summary>
        internal virtual Dictionary<SemanticsAction, object> _Actions { get; set; }
        internal virtual int _ActionsAsBits { get; set; }
        internal virtual VoidCallback _OnTap { get; set; }
        internal virtual VoidCallback _OnLongPress { get; set; }
        internal virtual VoidCallback _OnScrollLeft { get; set; }
        internal virtual VoidCallback _OnDismiss { get; set; }
        internal virtual VoidCallback _OnScrollRight { get; set; }
        internal virtual VoidCallback _OnScrollUp { get; set; }
        internal virtual VoidCallback _OnScrollDown { get; set; }
        internal virtual VoidCallback _OnIncrease { get; set; }
        internal virtual VoidCallback _OnDecrease { get; set; }
        internal virtual VoidCallback _OnCopy { get; set; }
        internal virtual VoidCallback _OnCut { get; set; }
        internal virtual VoidCallback _OnPaste { get; set; }
        internal virtual VoidCallback _OnShowOnScreen { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorForwardByCharacter { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorBackwardByCharacter { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorForwardByWord { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorBackwardByWord { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler _OnSetSelection { get; set; }
        internal virtual VoidCallback _OnDidGainAccessibilityFocus { get; set; }
        internal virtual VoidCallback _OnDidLoseAccessibilityFocus { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey _SortKey { get; set; }
        internal virtual int _IndexInParent { get; set; }
        internal virtual int _ScrollChildCount { get; set; }
        internal virtual int _ScrollIndex { get; set; }
        internal virtual int _PlatformViewId { get; set; }
        internal virtual int _MaxValueLength { get; set; }
        internal virtual int _CurrentValueLength { get; set; }
        internal virtual bool _IsMergingSemanticsOfDescendants { get; set; }
        internal virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> _CustomSemanticsActions { get; set; }
        internal virtual string _Label { get; set; }
        internal virtual string _Value { get; set; }
        internal virtual string _DecreasedValue { get; set; }
        internal virtual string _IncreasedValue { get; set; }
        internal virtual string _Hint { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides _HintOverrides { get; set; }
        internal virtual double _Elevation { get; set; }
        internal virtual double _Thickness { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual FlutterSDK.Services.Textediting.TextSelection _TextSelection { get; set; }
        internal virtual double _ScrollPosition { get; set; }
        internal virtual double _ScrollExtentMax { get; set; }
        internal virtual double _ScrollExtentMin { get; set; }
        internal virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> _TagsForChildren { get; set; }
        internal virtual int _Flags { get; set; }
        public virtual bool IsSemanticBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasBeenAnnotated { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnTap { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnLongPress { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnScrollLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnDismiss { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnScrollRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnScrollUp { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnScrollDown { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnIncrease { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnDecrease { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnCopy { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnCut { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnPaste { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnShowOnScreen { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByCharacter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByCharacter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByWord { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByWord { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler OnSetSelection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnDidGainAccessibilityFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnDidLoseAccessibilityFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int IndexInParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int ScrollChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int ScrollIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int PlatformViewId { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int MaxValueLength { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int CurrentValueLength { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsMergingSemanticsOfDescendants { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> CustomSemanticsActions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string Label { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DecreasedValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string IncreasedValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string Hint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverrides { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Elevation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Thickness { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ScopesRoute { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool NamesRoute { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsImage { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool LiveRegion { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsSelected { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsChecked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsToggled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsInMutuallyExclusiveGroup { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsFocusable { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsFocused { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsButton { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsLink { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsHeader { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsHidden { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsTextField { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsReadOnly { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsObscured { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsMultiline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasImplicitScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Textediting.TextSelection TextSelection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double ScrollPosition { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double ScrollExtentMax { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double ScrollExtentMin { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Semantics.Semantics.SemanticsTag> TagsForChildren { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Adds an `action` to the semantics tree.
        ///
        /// The provided `handler` is called to respond to the user triggered
        /// `action`.
        /// </Summary>
        private void _AddAction(SemanticsAction action, FlutterSDK.Semantics.Semantics._SemanticsActionHandler handler)
        {

            _Actions[action] = handler;
            _ActionsAsBits |= action.Index;
            _HasBeenAnnotated = true;
        }




        /// <Summary>
        /// Adds an `action` to the semantics tree, whose `handler` does not expect
        /// any arguments.
        ///
        /// The provided `handler` is called to respond to the user triggered
        /// `action`.
        /// </Summary>
        private void _AddArgumentlessAction(SemanticsAction action, VoidCallback handler)
        {

            _AddAction(action, (object args) =>
            {

                handler();
            }
            );
        }




        /// <Summary>
        /// Returns the action handler registered for [action] or null if none was
        /// registered.
        ///
        /// See also:
        ///
        ///  * [addAction] to add an action.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics._SemanticsActionHandler GetActionHandler(SemanticsAction action) => _Actions[action];



        private void _OnCustomSemanticsAction(object args)
        {
            CustomSemanticsAction action = SemanticsDefaultClass.CustomSemanticsAction.GetAction(args as int);
            if (action == null) return;
            VoidCallback callback = _CustomSemanticsActions[action];
            if (callback != null) callback();
        }




        /// <Summary>
        /// Specifies a [SemanticsTag] that this configuration wants to apply to all
        /// child [SemanticsNode]s.
        ///
        /// The tag is added to all [SemanticsNode] that pass through the
        /// [RenderObject] owning this configuration while looking to be attached to a
        /// parent [SemanticsNode].
        ///
        /// Tags are used to communicate to a parent [SemanticsNode] that a child
        /// [SemanticsNode] was passed through a particular [RenderObject]. The parent
        /// can use this information to determine the shape of the semantics tree.
        ///
        /// See also:
        ///
        ///  * [RenderSemanticsGestureHandler.excludeFromScrolling] for an example of
        ///    how tags are used.
        /// </Summary>
        public virtual void AddTagForChildren(FlutterSDK.Semantics.Semantics.SemanticsTag tag)
        {
            _TagsForChildren = (_TagsForChildren == null ? new Dictionary<SemanticsTag> { } : _TagsForChildren);
            _TagsForChildren.Add(tag);
        }




        private void _SetFlag(SemanticsFlag flag, bool value)
        {
            if (value)
            {
                _Flags |= flag.Index;
            }
            else
            {
                _Flags &= ~flag.Index;
            }

            _HasBeenAnnotated = true;
        }




        private bool _HasFlag(SemanticsFlag flag) => (_Flags & flag.Index) != 0;



        /// <Summary>
        /// Whether this configuration is compatible with the provided `other`
        /// configuration.
        ///
        /// Two configurations are said to be compatible if they can be added to the
        /// same [SemanticsNode] without losing any semantics information.
        /// </Summary>
        public virtual bool IsCompatibleWith(FlutterSDK.Semantics.Semantics.SemanticsConfiguration other)
        {
            if (other == null || !other.HasBeenAnnotated || !HasBeenAnnotated) return true;
            if (_ActionsAsBits & other._ActionsAsBits != 0) return false;
            if ((_Flags & other._Flags) != 0) return false;
            if (_PlatformViewId != null && other._PlatformViewId != null)
            {
                return false;
            }

            if (_MaxValueLength != null && other._MaxValueLength != null)
            {
                return false;
            }

            if (_CurrentValueLength != null && other._CurrentValueLength != null)
            {
                return false;
            }

            if (_Value != null && _Value.IsNotEmpty && other._Value != null && other._Value.IsNotEmpty) return false;
            return true;
        }




        /// <Summary>
        /// Absorb the semantic information from `child` into this configuration.
        ///
        /// This adds the semantic information of both configurations and saves the
        /// result in this configuration.
        ///
        /// The [RenderObject] owning the `child` configuration must be a descendant
        /// of the [RenderObject] that owns this configuration.
        ///
        /// Only configurations that have [explicitChildNodes] set to false can
        /// absorb other configurations and it is recommended to only absorb compatible
        /// configurations as determined by [isCompatibleWith].
        /// </Summary>
        public virtual void Absorb(FlutterSDK.Semantics.Semantics.SemanticsConfiguration child)
        {

            if (!child.HasBeenAnnotated) return;
            _Actions.AddAll(child._Actions);
            _CustomSemanticsActions.AddAll(child._CustomSemanticsActions);
            _ActionsAsBits |= child._ActionsAsBits;
            _Flags |= child._Flags;
            _TextSelection = (_TextSelection == null ? child._TextSelection : _TextSelection);
            _ScrollPosition = (_ScrollPosition == null ? child._ScrollPosition : _ScrollPosition);
            _ScrollExtentMax = (_ScrollExtentMax == null ? child._ScrollExtentMax : _ScrollExtentMax);
            _ScrollExtentMin = (_ScrollExtentMin == null ? child._ScrollExtentMin : _ScrollExtentMin);
            _HintOverrides = (_HintOverrides == null ? child._HintOverrides : _HintOverrides);
            _IndexInParent = (_IndexInParent == null ? child.IndexInParent : _IndexInParent);
            _ScrollIndex = (_ScrollIndex == null ? child._ScrollIndex : _ScrollIndex);
            _ScrollChildCount = (_ScrollChildCount == null ? child._ScrollChildCount : _ScrollChildCount);
            _PlatformViewId = (_PlatformViewId == null ? child._PlatformViewId : _PlatformViewId);
            _MaxValueLength = (_MaxValueLength == null ? child._MaxValueLength : _MaxValueLength);
            _CurrentValueLength = (_CurrentValueLength == null ? child._CurrentValueLength : _CurrentValueLength);
            TextDirection = (TextDirection == null ? child.TextDirection : TextDirection);
            _SortKey = (_SortKey == null ? child._SortKey : _SortKey);
            _Label = SemanticsDefaultClass._ConcatStrings(thisString: _Label, thisTextDirection: TextDirection, otherString: child._Label, otherTextDirection: child.TextDirection);
            if (_DecreasedValue == "" || _DecreasedValue == null) _DecreasedValue = child._DecreasedValue;
            if (_Value == "" || _Value == null) _Value = child._Value;
            if (_IncreasedValue == "" || _IncreasedValue == null) _IncreasedValue = child._IncreasedValue;
            _Hint = SemanticsDefaultClass._ConcatStrings(thisString: _Hint, thisTextDirection: TextDirection, otherString: child._Hint, otherTextDirection: child.TextDirection);
            _Thickness = Dart.Math.MathDefaultClass.Max(_Thickness, child._Thickness + child._Elevation);
            _HasBeenAnnotated = _HasBeenAnnotated || child._HasBeenAnnotated;
        }




        /// <Summary>
        /// Returns an exact copy of this configuration.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Copy()
        {
            return new SemanticsConfiguration().._IsSemanticBoundary = _IsSemanticBoundary..ExplicitChildNodes = ExplicitChildNodes..IsBlockingSemanticsOfPreviouslyPaintedNodes = IsBlockingSemanticsOfPreviouslyPaintedNodes.._HasBeenAnnotated = _HasBeenAnnotated.._IsMergingSemanticsOfDescendants = _IsMergingSemanticsOfDescendants.._TextDirection = _TextDirection.._SortKey = _SortKey.._Label = _Label.._IncreasedValue = _IncreasedValue.._Value = _Value.._DecreasedValue = _DecreasedValue.._Hint = _Hint.._HintOverrides = _HintOverrides.._Elevation = _Elevation.._Thickness = _Thickness.._Flags = _Flags.._TagsForChildren = _TagsForChildren.._TextSelection = _TextSelection.._ScrollPosition = _ScrollPosition.._ScrollExtentMax = _ScrollExtentMax.._ScrollExtentMin = _ScrollExtentMin.._ActionsAsBits = _ActionsAsBits.._IndexInParent = IndexInParent.._ScrollIndex = _ScrollIndex.._ScrollChildCount = _ScrollChildCount.._PlatformViewId = _PlatformViewId.._MaxValueLength = _MaxValueLength.._CurrentValueLength = _CurrentValueLength._Actions.AddAll(_Actions._CustomSemanticsActions.AddAll(_CustomSemanticsActions;
        }



    }
    public static class SemanticsConfigurationMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ISemanticsConfiguration, SemanticsConfiguration> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ISemanticsConfiguration, SemanticsConfiguration>();
        static SemanticsConfiguration GetOrCreate(ISemanticsConfiguration instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new SemanticsConfiguration();
                _table.Add(instance, value);
            }
            return (SemanticsConfiguration)value;
        }
        public static bool ExplicitChildNodesProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ExplicitChildNodes;
        public static bool IsBlockingSemanticsOfPreviouslyPaintedNodesProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsBlockingSemanticsOfPreviouslyPaintedNodes;
        public static bool IsSemanticBoundaryProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsSemanticBoundary;
        public static bool HasBeenAnnotatedProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).HasBeenAnnotated;
        public static VoidCallback OnTapProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnTap;
        public static VoidCallback OnLongPressProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnLongPress;
        public static VoidCallback OnScrollLeftProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnScrollLeft;
        public static VoidCallback OnDismissProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnDismiss;
        public static VoidCallback OnScrollRightProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnScrollRight;
        public static VoidCallback OnScrollUpProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnScrollUp;
        public static VoidCallback OnScrollDownProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnScrollDown;
        public static VoidCallback OnIncreaseProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnIncrease;
        public static VoidCallback OnDecreaseProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnDecrease;
        public static VoidCallback OnCopyProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnCopy;
        public static VoidCallback OnCutProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnCut;
        public static VoidCallback OnPasteProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnPaste;
        public static VoidCallback OnShowOnScreenProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnShowOnScreen;
        public static FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByCharacterProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnMoveCursorForwardByCharacter;
        public static FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByCharacterProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnMoveCursorBackwardByCharacter;
        public static FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByWordProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnMoveCursorForwardByWord;
        public static FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByWordProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnMoveCursorBackwardByWord;
        public static FlutterSDK.Semantics.Semantics.SetSelectionHandler OnSetSelectionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnSetSelection;
        public static VoidCallback OnDidGainAccessibilityFocusProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnDidGainAccessibilityFocus;
        public static VoidCallback OnDidLoseAccessibilityFocusProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnDidLoseAccessibilityFocus;
        public static FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKeyProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).SortKey;
        public static int IndexInParentProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IndexInParent;
        public static int ScrollChildCountProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollChildCount;
        public static int ScrollIndexProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollIndex;
        public static int PlatformViewIdProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).PlatformViewId;
        public static int MaxValueLengthProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).MaxValueLength;
        public static int CurrentValueLengthProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).CurrentValueLength;
        public static bool IsMergingSemanticsOfDescendantsProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsMergingSemanticsOfDescendants;
        public static Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> CustomSemanticsActionsProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).CustomSemanticsActions;
        public static string LabelProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Label;
        public static string ValueProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Value;
        public static string DecreasedValueProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).DecreasedValue;
        public static string IncreasedValueProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IncreasedValue;
        public static string HintProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Hint;
        public static FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverridesProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).HintOverrides;
        public static double ElevationProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Elevation;
        public static double ThicknessProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Thickness;
        public static bool ScopesRouteProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScopesRoute;
        public static bool NamesRouteProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).NamesRoute;
        public static bool IsImageProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsImage;
        public static bool LiveRegionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).LiveRegion;
        public static TextDirection TextDirectionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).TextDirection;
        public static bool IsSelectedProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsSelected;
        public static bool IsEnabledProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsEnabled;
        public static bool IsCheckedProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsChecked;
        public static bool IsToggledProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsToggled;
        public static bool IsInMutuallyExclusiveGroupProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsInMutuallyExclusiveGroup;
        public static bool IsFocusableProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsFocusable;
        public static bool IsFocusedProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsFocused;
        public static bool IsButtonProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsButton;
        public static bool IsLinkProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsLink;
        public static bool IsHeaderProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsHeader;
        public static bool IsHiddenProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsHidden;
        public static bool IsTextFieldProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsTextField;
        public static bool IsReadOnlyProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsReadOnly;
        public static bool IsObscuredProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsObscured;
        public static bool IsMultilineProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsMultiline;
        public static bool HasImplicitScrollingProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).HasImplicitScrolling;
        public static FlutterSDK.Services.Textediting.TextSelection TextSelectionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).TextSelection;
        public static double ScrollPositionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollPosition;
        public static double ScrollExtentMaxProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollExtentMax;
        public static double ScrollExtentMinProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollExtentMin;
        public static Iterable<FlutterSDK.Semantics.Semantics.SemanticsTag> TagsForChildrenProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).TagsForChildren;
        public static FlutterSDK.Semantics.Semantics._SemanticsActionHandler GetActionHandler(this ISemanticsConfiguration instance, SemanticsAction action) => GetOrCreate(instance).GetActionHandler(action);
        public static void AddTagForChildren(this ISemanticsConfiguration instance, FlutterSDK.Semantics.Semantics.SemanticsTag tag) => GetOrCreate(instance).AddTagForChildren(tag);
        public static bool IsCompatibleWith(this ISemanticsConfiguration instance, FlutterSDK.Semantics.Semantics.SemanticsConfiguration other) => GetOrCreate(instance).IsCompatibleWith(other);
        public static void Absorb(this ISemanticsConfiguration instance, FlutterSDK.Semantics.Semantics.SemanticsConfiguration child) => GetOrCreate(instance).Absorb(child);
        public static FlutterSDK.Semantics.Semantics.SemanticsConfiguration Copy(this ISemanticsConfiguration instance) => GetOrCreate(instance).Copy();
    }


    /// <Summary>
    /// A tag for a [SemanticsNode].
    ///
    /// Tags can be interpreted by the parent of a [SemanticsNode]
    /// and depending on the presence of a tag the parent can for example decide
    /// how to add the tagged node as a child. Tags are not sent to the engine.
    ///
    /// As an example, the [RenderSemanticsGestureHandler] uses tags to determine
    /// if a child node should be excluded from the scrollable area for semantic
    /// purposes.
    ///
    /// The provided [name] is only used for debugging. Two tags created with the
    /// same [name] and the `new` operator are not considered identical. However,
    /// two tags created with the same [name] and the `const` operator are always
    /// identical.
    /// </Summary>
    public class SemanticsTag
    {
        /// <Summary>
        /// Creates a [SemanticsTag].
        ///
        /// The provided [name] is only used for debugging. Two tags created with the
        /// same [name] and the `new` operator are not considered identical. However,
        /// two tags created with the same [name] and the `const` operator are always
        /// identical.
        /// </Summary>
        public SemanticsTag(string name)
        {
            this.Name = name;
        }
        /// <Summary>
        /// A human-readable name for this tag used for debugging.
        ///
        /// This string is not used to determine if two tags are identical.
        /// </Summary>
        public virtual string Name { get; set; }

    }


    /// <Summary>
    /// An identifier of a custom semantics action.
    ///
    /// Custom semantics actions can be provided to make complex user
    /// interactions more accessible. For instance, if an application has a
    /// drag-and-drop list that requires the user to press and hold an item
    /// to move it, users interacting with the application using a hardware
    /// switch may have difficulty. This can be made accessible by creating custom
    /// actions and pairing them with handlers that move a list item up or down in
    /// the list.
    ///
    /// In Android, these actions are presented in the local context menu. In iOS,
    /// these are presented in the radial context menu.
    ///
    /// Localization and text direction do not automatically apply to the provided
    /// label or hint.
    ///
    /// Instances of this class should either be instantiated with const or
    /// new instances cached in static fields.
    ///
    /// See also:
    ///
    ///  * [SemanticsProperties], where the handler for a custom action is provided.
    /// </Summary>
    public class CustomSemanticsAction
    {
        /// <Summary>
        /// Creates a new [CustomSemanticsAction].
        ///
        /// The [label] must not be null or the empty string.
        /// </Summary>
        public CustomSemanticsAction(string label = default(string))
        : base()
        {
            this.Label = label;
        }
        /// <Summary>
        /// Creates a new [CustomSemanticsAction] that overrides a standard semantics
        /// action.
        ///
        /// The [hint] must not be null or the empty string.
        /// </Summary>
        public static CustomSemanticsAction OverridingAction(string hint = default(string), SemanticsAction action = default(SemanticsAction))
        => new CustomSemanticsAction(hint, action);

        private CustomSemanticsAction(string hint, SemanticsAction action)
        : base()
        {
            this.Hint = hint;
            this.Action = action;
        }
        /// <Summary>
        /// The user readable name of this custom semantics action.
        /// </Summary>
        public virtual string Label { get; set; }
        /// <Summary>
        /// The hint description of this custom semantics action.
        /// </Summary>
        public virtual string Hint { get; set; }
        /// <Summary>
        /// The standard semantics action this action replaces.
        /// </Summary>
        public virtual SemanticsAction Action { get; set; }
        internal virtual int _NextId { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Semantics.Semantics.CustomSemanticsAction> _Actions { get; set; }
        internal virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, int> _Ids { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is CustomSemanticsAction && other.Label == Label && other.Hint == Hint && other.Action == Action;
        }





        /// <Summary>
        /// Get the identifier for a given `action`.
        /// </Summary>
        public virtual int GetIdentifier(FlutterSDK.Semantics.Semantics.CustomSemanticsAction action)
        {
            int result = _Ids[action];
            if (result == null)
            {
                result = _NextId++;
                _Ids[action] = result;
                _Actions[result] = action;
            }

            return result;
        }




        /// <Summary>
        /// Get the `action` for a given identifier.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction GetAction(int id)
        {
            return _Actions[id];
        }



    }


    /// <Summary>
    /// Summary information about a [SemanticsNode] object.
    ///
    /// A semantics node might [SemanticsNode.mergeAllDescendantsIntoThisNode],
    /// which means the individual fields on the semantics node don't fully describe
    /// the semantics at that node. This data structure contains the full semantics
    /// for the node.
    ///
    /// Typically obtained from [SemanticsNode.getSemanticsData].
    /// </Summary>
    public class SemanticsData : IDiagnosticable
    {
        /// <Summary>
        /// Creates a semantics data object.
        ///
        /// The [flags], [actions], [label], and [Rect] arguments must not be null.
        ///
        /// If [label] is not empty, then [textDirection] must also not be null.
        /// </Summary>
        public SemanticsData(int flags = default(int), int actions = default(int), string label = default(string), string increasedValue = default(string), string value = default(string), string decreasedValue = default(string), string hint = default(string), TextDirection textDirection = default(TextDirection), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), double elevation = default(double), double thickness = default(double), FlutterSDK.Services.Textediting.TextSelection textSelection = default(FlutterSDK.Services.Textediting.TextSelection), int scrollIndex = default(int), int scrollChildCount = default(int), double scrollPosition = default(double), double scrollExtentMax = default(double), double scrollExtentMin = default(double), int platformViewId = default(int), int maxValueLength = default(int), int currentValueLength = default(int), HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> tags = default(HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag>), Matrix4 transform = default(Matrix4), List<int> customSemanticsActionIds = default(List<int>))
        : base()
        {
            this.Flags = flags;
            this.Actions = actions;
            this.Label = label;
            this.IncreasedValue = increasedValue;
            this.Value = value;
            this.DecreasedValue = decreasedValue;
            this.Hint = hint;
            this.TextDirection = textDirection;
            this.Rect = rect;
            this.Elevation = elevation;
            this.Thickness = thickness;
            this.TextSelection = textSelection;
            this.ScrollIndex = scrollIndex;
            this.ScrollChildCount = scrollChildCount;
            this.ScrollPosition = scrollPosition;
            this.ScrollExtentMax = scrollExtentMax;
            this.ScrollExtentMin = scrollExtentMin;
            this.PlatformViewId = platformViewId;
            this.MaxValueLength = maxValueLength;
            this.CurrentValueLength = currentValueLength;
            this.Tags = tags;
            this.Transform = transform;
            this.CustomSemanticsActionIds = customSemanticsActionIds;
        }
        /// <Summary>
        /// A bit field of [SemanticsFlag]s that apply to this node.
        /// </Summary>
        public virtual int Flags { get; set; }
        /// <Summary>
        /// A bit field of [SemanticsAction]s that apply to this node.
        /// </Summary>
        public virtual int Actions { get; set; }
        /// <Summary>
        /// A textual description of this node.
        ///
        /// The reading direction is given by [textDirection].
        /// </Summary>
        public virtual string Label { get; set; }
        /// <Summary>
        /// A textual description for the current value of the node.
        ///
        /// The reading direction is given by [textDirection].
        /// </Summary>
        public virtual string Value { get; set; }
        /// <Summary>
        /// The value that [value] will become after performing a
        /// [SemanticsAction.increase] action.
        ///
        /// The reading direction is given by [textDirection].
        /// </Summary>
        public virtual string IncreasedValue { get; set; }
        /// <Summary>
        /// The value that [value] will become after performing a
        /// [SemanticsAction.decrease] action.
        ///
        /// The reading direction is given by [textDirection].
        /// </Summary>
        public virtual string DecreasedValue { get; set; }
        /// <Summary>
        /// A brief description of the result of performing an action on this node.
        ///
        /// The reading direction is given by [textDirection].
        /// </Summary>
        public virtual string Hint { get; set; }
        /// <Summary>
        /// The reading direction for the text in [label], [value], [hint],
        /// [increasedValue], and [decreasedValue].
        /// </Summary>
        public virtual TextDirection TextDirection { get; set; }
        /// <Summary>
        /// The currently selected text (or the position of the cursor) within [value]
        /// if this node represents a text field.
        /// </Summary>
        public virtual FlutterSDK.Services.Textediting.TextSelection TextSelection { get; set; }
        /// <Summary>
        /// The total number of scrollable children that contribute to semantics.
        ///
        /// If the number of children are unknown or unbounded, this value will be
        /// null.
        /// </Summary>
        public virtual int ScrollChildCount { get; set; }
        /// <Summary>
        /// The index of the first visible semantic child of a scroll node.
        /// </Summary>
        public virtual int ScrollIndex { get; set; }
        /// <Summary>
        /// Indicates the current scrolling position in logical pixels if the node is
        /// scrollable.
        ///
        /// The properties [scrollExtentMin] and [scrollExtentMax] indicate the valid
        /// in-range values for this property. The value for [scrollPosition] may
        /// (temporarily) be outside that range, e.g. during an overscroll.
        ///
        /// See also:
        ///
        ///  * [ScrollPosition.pixels], from where this value is usually taken.
        /// </Summary>
        public virtual double ScrollPosition { get; set; }
        /// <Summary>
        /// Indicates the maximum in-range value for [scrollPosition] if the node is
        /// scrollable.
        ///
        /// This value may be infinity if the scroll is unbound.
        ///
        /// See also:
        ///
        ///  * [ScrollPosition.maxScrollExtent], from where this value is usually taken.
        /// </Summary>
        public virtual double ScrollExtentMax { get; set; }
        /// <Summary>
        /// Indicates the minimum in-range value for [scrollPosition] if the node is
        /// scrollable.
        ///
        /// This value may be infinity if the scroll is unbound.
        ///
        /// See also:
        ///
        ///  * [ScrollPosition.minScrollExtent], from where this value is usually taken.
        /// </Summary>
        public virtual double ScrollExtentMin { get; set; }
        /// <Summary>
        /// The id of the platform view, whose semantics nodes will be added as
        /// children to this node.
        ///
        /// If this value is non-null, the SemanticsNode must not have any children
        /// as those would be replaced by the semantics nodes of the referenced
        /// platform view.
        ///
        /// See also:
        ///
        ///  * [AndroidView], which is the platform view for Android.
        ///  * [UiKitView], which is the platform view for iOS.
        /// </Summary>
        public virtual int PlatformViewId { get; set; }
        /// <Summary>
        /// The maximum number of characters that can be entered into an editable
        /// text field.
        ///
        /// For the purpose of this function a character is defined as one Unicode
        /// scalar value.
        ///
        /// This should only be set when [SemanticsFlag.isTextField] is set. Defaults
        /// to null, which means no limit is imposed on the text field.
        /// </Summary>
        public virtual int MaxValueLength { get; set; }
        /// <Summary>
        /// The current number of characters that have been entered into an editable
        /// text field.
        ///
        /// For the purpose of this function a character is defined as one Unicode
        /// scalar value.
        ///
        /// This should only be set when [SemanticsFlag.isTextField] is set. This must
        /// be set when [maxValueLength] is set.
        /// </Summary>
        public virtual int CurrentValueLength { get; set; }
        /// <Summary>
        /// The bounding box for this node in its coordinate system.
        /// </Summary>
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        /// <Summary>
        /// The set of [SemanticsTag]s associated with this node.
        /// </Summary>
        public virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> Tags { get; set; }
        /// <Summary>
        /// The transform from this node's coordinate system to its parent's coordinate system.
        ///
        /// By default, the transform is null, which represents the identity
        /// transformation (i.e., that this node has the same coordinate system as its
        /// parent).
        /// </Summary>
        public virtual Matrix4 Transform { get; set; }
        /// <Summary>
        /// The elevation of this node relative to the parent semantics node.
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.elevation] for a detailed discussion regarding
        ///    elevation and semantics.
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The extent of this node along the z-axis beyond its [elevation]
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.thickness] for a more detailed definition.
        /// </Summary>
        public virtual double Thickness { get; set; }
        /// <Summary>
        /// The identifiers for the custom semantics actions and standard action
        /// overrides for this node.
        ///
        /// The list must be sorted in increasing order.
        ///
        /// See also:
        ///
        ///  * [CustomSemanticsAction], for an explanation of custom actions.
        /// </Summary>
        public virtual List<int> CustomSemanticsActionIds { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Whether [flags] contains the given flag.
        /// </Summary>
        public virtual bool HasFlag(SemanticsFlag flag) => (Flags & flag.Index) != 0;



        /// <Summary>
        /// Whether [actions] contains the given action.
        /// </Summary>
        public virtual bool HasAction(SemanticsAction action) => (Actions & action.Index) != 0;



        public new string ToStringShort() => ObjectDefaultClass.ObjectRuntimeType(this, "SemanticsData");



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Rect>("rect", Rect, showName: false));
            properties.Add(new TransformProperty("transform", Transform, showName: false, defaultValue: null));
            properties.Add(new DoubleProperty("elevation", Elevation, defaultValue: 0.0));
            properties.Add(new DoubleProperty("thickness", Thickness, defaultValue: 0.0));
            List<string> actionSummary = new List<string>() { };
            List<string> customSemanticsActionSummary = CustomSemanticsActionIds.Map((int actionId) => =>SemanticsDefaultClass.CustomSemanticsAction.GetAction(actionId).Label).ToList();
            properties.Add(new IterableProperty<string>("actions", actionSummary, ifEmpty: null));
            properties.Add(new IterableProperty<string>("customActions", customSemanticsActionSummary, ifEmpty: null));
            List<string> flagSummary = new List<string>() { };
            properties.Add(new IterableProperty<string>("flags", flagSummary, ifEmpty: null));
            properties.Add(new StringProperty("label", Label, defaultValue: ""));
            properties.Add(new StringProperty("value", Value, defaultValue: ""));
            properties.Add(new StringProperty("increasedValue", IncreasedValue, defaultValue: ""));
            properties.Add(new StringProperty("decreasedValue", DecreasedValue, defaultValue: ""));
            properties.Add(new StringProperty("hint", Hint, defaultValue: ""));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
            if (TextSelection?.IsValid == true) properties.Add(new MessageProperty("textSelection", $"'[{TextSelection.Start}, {TextSelection.End}]'"));
            properties.Add(new IntProperty("platformViewId", PlatformViewId, defaultValue: null));
            properties.Add(new IntProperty("maxValueLength", MaxValueLength, defaultValue: null));
            properties.Add(new IntProperty("currentValueLength", CurrentValueLength, defaultValue: null));
            properties.Add(new IntProperty("scrollChildren", ScrollChildCount, defaultValue: null));
            properties.Add(new IntProperty("scrollIndex", ScrollIndex, defaultValue: null));
            properties.Add(new DoubleProperty("scrollExtentMin", ScrollExtentMin, defaultValue: null));
            properties.Add(new DoubleProperty("scrollPosition", ScrollPosition, defaultValue: null));
            properties.Add(new DoubleProperty("scrollExtentMax", ScrollExtentMax, defaultValue: null));
        }




        public new bool Equals(@Object other)
        {
            return other is SemanticsData && other.Flags == Flags && other.Actions == Actions && other.Label == Label && other.Value == Value && other.IncreasedValue == IncreasedValue && other.DecreasedValue == DecreasedValue && other.Hint == Hint && other.TextDirection == TextDirection && other.Rect == Rect && CollectionsDefaultClass.SetEquals(other.Tags, Tags) && other.ScrollChildCount == ScrollChildCount && other.ScrollIndex == ScrollIndex && other.TextSelection == TextSelection && other.ScrollPosition == ScrollPosition && other.ScrollExtentMax == ScrollExtentMax && other.ScrollExtentMin == ScrollExtentMin && other.PlatformViewId == PlatformViewId && other.MaxValueLength == MaxValueLength && other.CurrentValueLength == CurrentValueLength && other.Transform == Transform && other.Elevation == Elevation && other.Thickness == Thickness && _SortedListsEqual(other.CustomSemanticsActionIds, CustomSemanticsActionIds);
        }




        private bool _SortedListsEqual(List<int> left, List<int> right)
        {
            if (left == null && right == null) return true;
            if (left != null && right != null)
            {
                if (left.Count != right.Count) return false;
                for (int i = 0; i < left.Count; i++) if (left[i] != right[i]) return false;
                return true;
            }

            return false;
        }



    }


    public class _SemanticsDiagnosticableNode : FlutterSDK.Foundation.Diagnostics.DiagnosticableNode<FlutterSDK.Semantics.Semantics.SemanticsNode>
    {
        public _SemanticsDiagnosticableNode(string name = default(string), FlutterSDK.Semantics.Semantics.SemanticsNode value = default(FlutterSDK.Semantics.Semantics.SemanticsNode), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder = default(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder))
        : base(name: name, value: value, style: style)
        {
            this.ChildOrder = childOrder;
        }
        public virtual FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder ChildOrder { get; set; }

        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren()
        {
            if (Value != null) return Value.DebugDescribeChildren(childOrder: ChildOrder);
            return new List<DiagnosticsNode>() { };
        }



    }


    /// <Summary>
    /// Provides hint values which override the default hints on supported
    /// platforms.
    ///
    /// On iOS, these values are always ignored.
    /// </Summary>
    public class SemanticsHintOverrides : FlutterSDK.Foundation.Diagnostics.DiagnosticableTree
    {
        /// <Summary>
        /// Creates a semantics hint overrides.
        /// </Summary>
        public SemanticsHintOverrides(string onTapHint = default(string), string onLongPressHint = default(string))
        : base()
        {
            this.OnTapHint = onTapHint;
            this.OnLongPressHint = onLongPressHint;
        }
        /// <Summary>
        /// The hint text for a tap action.
        ///
        /// If null, the standard hint is used instead.
        ///
        /// The hint should describe what happens when a tap occurs, not the
        /// manner in which a tap is accomplished.
        ///
        /// Bad: 'Double tap to show movies'.
        /// Good: 'show movies'.
        /// </Summary>
        public virtual string OnTapHint { get; set; }
        /// <Summary>
        /// The hint text for a long press action.
        ///
        /// If null, the standard hint is used instead.
        ///
        /// The hint should describe what happens when a long press occurs, not
        /// the manner in which the long press is accomplished.
        ///
        /// Bad: 'Double tap and hold to show tooltip'.
        /// Good: 'show tooltip'.
        /// </Summary>
        public virtual string OnLongPressHint { get; set; }
        public virtual bool IsNotEmpty { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is SemanticsHintOverrides && other.OnTapHint == OnTapHint && other.OnLongPressHint == OnLongPressHint;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new StringProperty("onTapHint", OnTapHint, defaultValue: null));
            properties.Add(new StringProperty("onLongPressHint", OnLongPressHint, defaultValue: null));
        }



    }


    /// <Summary>
    /// Contains properties used by assistive technologies to make the application
    /// more accessible.
    ///
    /// The properties of this class are used to generate a [SemanticsNode]s in the
    /// semantics tree.
    /// </Summary>
    public class SemanticsProperties : FlutterSDK.Foundation.Diagnostics.DiagnosticableTree
    {
        /// <Summary>
        /// Creates a semantic annotation.
        /// </Summary>
        public SemanticsProperties(bool enabled = default(bool), bool @checked = default(bool), bool selected = default(bool), bool toggled = default(bool), bool button = default(bool), bool link = default(bool), bool header = default(bool), bool textField = default(bool), bool readOnly = default(bool), bool focusable = default(bool), bool focused = default(bool), bool inMutuallyExclusiveGroup = default(bool), bool hidden = default(bool), bool obscured = default(bool), bool multiline = default(bool), bool scopesRoute = default(bool), bool namesRoute = default(bool), bool image = default(bool), bool liveRegion = default(bool), int maxValueLength = default(int), int currentValueLength = default(int), string label = default(string), string value = default(string), string increasedValue = default(string), string decreasedValue = default(string), string hint = default(string), FlutterSDK.Semantics.Semantics.SemanticsHintOverrides hintOverrides = default(FlutterSDK.Semantics.Semantics.SemanticsHintOverrides), TextDirection textDirection = default(TextDirection), FlutterSDK.Semantics.Semantics.SemanticsSortKey sortKey = default(FlutterSDK.Semantics.Semantics.SemanticsSortKey), VoidCallback onTap = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), VoidCallback onScrollLeft = default(VoidCallback), VoidCallback onScrollRight = default(VoidCallback), VoidCallback onScrollUp = default(VoidCallback), VoidCallback onScrollDown = default(VoidCallback), VoidCallback onIncrease = default(VoidCallback), VoidCallback onDecrease = default(VoidCallback), VoidCallback onCopy = default(VoidCallback), VoidCallback onCut = default(VoidCallback), VoidCallback onPaste = default(VoidCallback), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByWord = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByWord = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.SetSelectionHandler onSetSelection = default(FlutterSDK.Semantics.Semantics.SetSelectionHandler), VoidCallback onDidGainAccessibilityFocus = default(VoidCallback), VoidCallback onDidLoseAccessibilityFocus = default(VoidCallback), VoidCallback onDismiss = default(VoidCallback), Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> customSemanticsActions = default(Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object>))
        {
            this.Enabled = enabled;
            this.@checked = @checked;
            this.Selected = selected;
            this.Toggled = toggled;
            this.Button = button;
            this.Link = link;
            this.Header = header;
            this.TextField = textField;
            this.ReadOnly = readOnly;
            this.Focusable = focusable;
            this.Focused = focused;
            this.InMutuallyExclusiveGroup = inMutuallyExclusiveGroup;
            this.Hidden = hidden;
            this.Obscured = obscured;
            this.Multiline = multiline;
            this.ScopesRoute = scopesRoute;
            this.NamesRoute = namesRoute;
            this.Image = image;
            this.LiveRegion = liveRegion;
            this.MaxValueLength = maxValueLength;
            this.CurrentValueLength = currentValueLength;
            this.Label = label;
            this.Value = value;
            this.IncreasedValue = increasedValue;
            this.DecreasedValue = decreasedValue;
            this.Hint = hint;
            this.HintOverrides = hintOverrides;
            this.TextDirection = textDirection;
            this.SortKey = sortKey;
            this.OnTap = onTap;
            this.OnLongPress = onLongPress;
            this.OnScrollLeft = onScrollLeft;
            this.OnScrollRight = onScrollRight;
            this.OnScrollUp = onScrollUp;
            this.OnScrollDown = onScrollDown;
            this.OnIncrease = onIncrease;
            this.OnDecrease = onDecrease;
            this.OnCopy = onCopy;
            this.OnCut = onCut;
            this.OnPaste = onPaste;
            this.OnMoveCursorForwardByCharacter = onMoveCursorForwardByCharacter;
            this.OnMoveCursorBackwardByCharacter = onMoveCursorBackwardByCharacter;
            this.OnMoveCursorForwardByWord = onMoveCursorForwardByWord;
            this.OnMoveCursorBackwardByWord = onMoveCursorBackwardByWord;
            this.OnSetSelection = onSetSelection;
            this.OnDidGainAccessibilityFocus = onDidGainAccessibilityFocus;
            this.OnDidLoseAccessibilityFocus = onDidLoseAccessibilityFocus;
            this.OnDismiss = onDismiss;
            this.CustomSemanticsActions = customSemanticsActions;
        }
        /// <Summary>
        /// If non-null, indicates that this subtree represents something that can be
        /// in an enabled or disabled state.
        ///
        /// For example, a button that a user can currently interact with would set
        /// this field to true. A button that currently does not respond to user
        /// interactions would set this field to false.
        /// </Summary>
        public virtual bool Enabled { get; set; }
        /// <Summary>
        /// If non-null, indicates that this subtree represents a checkbox
        /// or similar widget with a "checked" state, and what its current
        /// state is.
        ///
        /// This is mutually exclusive with [toggled].
        /// </Summary>
        public virtual bool @checked { get; set; }
        /// <Summary>
        /// If non-null, indicates that this subtree represents a toggle switch
        /// or similar widget with an "on" state, and what its current
        /// state is.
        ///
        /// This is mutually exclusive with [checked].
        /// </Summary>
        public virtual bool Toggled { get; set; }
        /// <Summary>
        /// If non-null indicates that this subtree represents something that can be
        /// in a selected or unselected state, and what its current state is.
        ///
        /// The active tab in a tab bar for example is considered "selected", whereas
        /// all other tabs are unselected.
        /// </Summary>
        public virtual bool Selected { get; set; }
        /// <Summary>
        /// If non-null, indicates that this subtree represents a button.
        ///
        /// TalkBack/VoiceOver provides users with the hint "button" when a button
        /// is focused.
        /// </Summary>
        public virtual bool Button { get; set; }
        /// <Summary>
        /// If non-null, indicates that this subtree represents a link.
        ///
        /// iOS's VoiceOver provides users with a unique hint when a link is focused.
        /// Android's Talkback will announce a link hint the same way it does a
        /// button.
        /// </Summary>
        public virtual bool Link { get; set; }
        /// <Summary>
        /// If non-null, indicates that this subtree represents a header.
        ///
        /// A header divides into sections. For example, an address book application
        /// might define headers A, B, C, etc. to divide the list of alphabetically
        /// sorted contacts into sections.
        /// </Summary>
        public virtual bool Header { get; set; }
        /// <Summary>
        /// If non-null, indicates that this subtree represents a text field.
        ///
        /// TalkBack/VoiceOver provide special affordances to enter text into a
        /// text field.
        /// </Summary>
        public virtual bool TextField { get; set; }
        /// <Summary>
        /// If non-null, indicates that this subtree is read only.
        ///
        /// Only applicable when [textField] is true
        ///
        /// TalkBack/VoiceOver will treat it as non-editable text field.
        /// </Summary>
        public virtual bool ReadOnly { get; set; }
        /// <Summary>
        /// If non-null, whether the node is able to hold input focus.
        ///
        /// If [focusable] is set to false, then [focused] must not be true.
        ///
        /// Input focus indicates that the node will receive keyboard events. It is not
        /// to be confused with accessibility focus. Accessibility focus is the
        /// green/black rectangular highlight that TalkBack/VoiceOver draws around the
        /// element it is reading, and is separate from input focus.
        /// </Summary>
        public virtual bool Focusable { get; set; }
        /// <Summary>
        /// If non-null, whether the node currently holds input focus.
        ///
        /// At most one node in the tree should hold input focus at any point in time,
        /// and it should not be set to true if [focusable] is false.
        ///
        /// Input focus indicates that the node will receive keyboard events. It is not
        /// to be confused with accessibility focus. Accessibility focus is the
        /// green/black rectangular highlight that TalkBack/VoiceOver draws around the
        /// element it is reading, and is separate from input focus.
        /// </Summary>
        public virtual bool Focused { get; set; }
        /// <Summary>
        /// If non-null, whether a semantic node is in a mutually exclusive group.
        ///
        /// For example, a radio button is in a mutually exclusive group because only
        /// one radio button in that group can be marked as [checked].
        /// </Summary>
        public virtual bool InMutuallyExclusiveGroup { get; set; }
        /// <Summary>
        /// If non-null, whether the node is considered hidden.
        ///
        /// Hidden elements are currently not visible on screen. They may be covered
        /// by other elements or positioned outside of the visible area of a viewport.
        ///
        /// Hidden elements cannot gain accessibility focus though regular touch. The
        /// only way they can be focused is by moving the focus to them via linear
        /// navigation.
        ///
        /// Platforms are free to completely ignore hidden elements and new platforms
        /// are encouraged to do so.
        ///
        /// Instead of marking an element as hidden it should usually be excluded from
        /// the semantics tree altogether. Hidden elements are only included in the
        /// semantics tree to work around platform limitations and they are mainly
        /// used to implement accessibility scrolling on iOS.
        /// </Summary>
        public virtual bool Hidden { get; set; }
        /// <Summary>
        /// If non-null, whether [value] should be obscured.
        ///
        /// This option is usually set in combination with [textField] to indicate
        /// that the text field contains a password (or other sensitive information).
        /// Doing so instructs screen readers to not read out the [value].
        /// </Summary>
        public virtual bool Obscured { get; set; }
        /// <Summary>
        /// Whether the [value] is coming from a field that supports multiline text
        /// editing.
        ///
        /// This option is only meaningful when [textField] is true to indicate
        /// whether it's a single-line or multiline text field.
        ///
        /// This option is null when [textField] is false.
        /// </Summary>
        public virtual bool Multiline { get; set; }
        /// <Summary>
        /// If non-null, whether the node corresponds to the root of a subtree for
        /// which a route name should be announced.
        ///
        /// Generally, this is set in combination with [explicitChildNodes], since
        /// nodes with this flag are not considered focusable by Android or iOS.
        ///
        /// See also:
        ///
        ///  * [SemanticsFlag.scopesRoute] for a description of how the announced
        ///    value is selected.
        /// </Summary>
        public virtual bool ScopesRoute { get; set; }
        /// <Summary>
        /// If non-null, whether the node contains the semantic label for a route.
        ///
        /// See also:
        ///
        ///  * [SemanticsFlag.namesRoute] for a description of how the name is used.
        /// </Summary>
        public virtual bool NamesRoute { get; set; }
        /// <Summary>
        /// If non-null, whether the node represents an image.
        ///
        /// See also:
        ///
        ///  * [SemanticsFlag.image], for the flag this setting controls.
        /// </Summary>
        public virtual bool Image { get; set; }
        /// <Summary>
        /// If non-null, whether the node should be considered a live region.
        ///
        /// On Android, when the label changes on a live region semantics node,
        /// TalkBack will make a polite announcement of the current label. This
        /// announcement occurs even if the node is not focused, but only if the label
        /// has changed since the last update.
        ///
        /// On iOS, no announcements are made but the node is marked as
        /// `UIAccessibilityTraitUpdatesFrequently`.
        ///
        /// An example of a live region is the [Snackbar] widget. When it appears
        /// on the screen it may be difficult to focus to read the label. A live
        /// region causes an initial polite announcement to be generated
        /// automatically.
        ///
        /// See also:
        ///
        ///  * [SemanticsFlag.liveRegion], the semantics flag this setting controls.
        ///  * [SemanticsConfiguration.liveRegion], for a full description of a live region.
        /// </Summary>
        public virtual bool LiveRegion { get; set; }
        /// <Summary>
        /// The maximum number of characters that can be entered into an editable
        /// text field.
        ///
        /// For the purpose of this function a character is defined as one Unicode
        /// scalar value.
        ///
        /// This should only be set when [textField] is true. Defaults to null,
        /// which means no limit is imposed on the text field.
        /// </Summary>
        public virtual int MaxValueLength { get; set; }
        /// <Summary>
        /// The current number of characters that have been entered into an editable
        /// text field.
        ///
        /// For the purpose of this function a character is defined as one Unicode
        /// scalar value.
        ///
        /// This should only be set when [textField] is true. Must be set when
        /// [maxValueLength] is set.
        /// </Summary>
        public virtual int CurrentValueLength { get; set; }
        /// <Summary>
        /// Provides a textual description of the widget.
        ///
        /// If a label is provided, there must either by an ambient [Directionality]
        /// or an explicit [textDirection] should be provided.
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.label] for a description of how this is exposed
        ///    in TalkBack and VoiceOver.
        /// </Summary>
        public virtual string Label { get; set; }
        /// <Summary>
        /// Provides a textual description of the value of the widget.
        ///
        /// If a value is provided, there must either by an ambient [Directionality]
        /// or an explicit [textDirection] should be provided.
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.value] for a description of how this is exposed
        ///    in TalkBack and VoiceOver.
        /// </Summary>
        public virtual string Value { get; set; }
        /// <Summary>
        /// The value that [value] will become after a [SemanticsAction.increase]
        /// action has been performed on this widget.
        ///
        /// If a value is provided, [onIncrease] must also be set and there must
        /// either be an ambient [Directionality] or an explicit [textDirection]
        /// must be provided.
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.increasedValue] for a description of how this
        ///    is exposed in TalkBack and VoiceOver.
        /// </Summary>
        public virtual string IncreasedValue { get; set; }
        /// <Summary>
        /// The value that [value] will become after a [SemanticsAction.decrease]
        /// action has been performed on this widget.
        ///
        /// If a value is provided, [onDecrease] must also be set and there must
        /// either be an ambient [Directionality] or an explicit [textDirection]
        /// must be provided.
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.decreasedValue] for a description of how this
        ///    is exposed in TalkBack and VoiceOver.
        /// </Summary>
        public virtual string DecreasedValue { get; set; }
        /// <Summary>
        /// Provides a brief textual description of the result of an action performed
        /// on the widget.
        ///
        /// If a hint is provided, there must either be an ambient [Directionality]
        /// or an explicit [textDirection] should be provided.
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.hint] for a description of how this is exposed
        ///    in TalkBack and VoiceOver.
        /// </Summary>
        public virtual string Hint { get; set; }
        /// <Summary>
        /// Provides hint values which override the default hints on supported
        /// platforms.
        ///
        /// On Android, If no hint overrides are used then default [hint] will be
        /// combined with the [label]. Otherwise, the [hint] will be ignored as long
        /// as there as at least one non-null hint override.
        ///
        /// On iOS, these are always ignored and the default [hint] is used instead.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverrides { get; set; }
        /// <Summary>
        /// The reading direction of the [label], [value], [hint], [increasedValue],
        /// and [decreasedValue].
        ///
        /// Defaults to the ambient [Directionality].
        /// </Summary>
        public virtual TextDirection TextDirection { get; set; }
        /// <Summary>
        /// Determines the position of this node among its siblings in the traversal
        /// sort order.
        ///
        /// This is used to describe the order in which the semantic node should be
        /// traversed by the accessibility services on the platform (e.g. VoiceOver
        /// on iOS and TalkBack on Android).
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.tap].
        ///
        /// This is the semantic equivalent of a user briefly tapping the screen with
        /// the finger without moving it. For example, a button should implement this
        /// action.
        ///
        /// VoiceOver users on iOS and TalkBack users on Android can trigger this
        /// action by double-tapping the screen while an element is focused.
        /// </Summary>
        public virtual VoidCallback OnTap { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.longPress].
        ///
        /// This is the semantic equivalent of a user pressing and holding the screen
        /// with the finger for a few seconds without moving it.
        ///
        /// VoiceOver users on iOS and TalkBack users on Android can trigger this
        /// action by double-tapping the screen without lifting the finger after the
        /// second tap.
        /// </Summary>
        public virtual VoidCallback OnLongPress { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.scrollLeft].
        ///
        /// This is the semantic equivalent of a user moving their finger across the
        /// screen from right to left. It should be recognized by controls that are
        /// horizontally scrollable.
        ///
        /// VoiceOver users on iOS can trigger this action by swiping left with three
        /// fingers. TalkBack users on Android can trigger this action by swiping
        /// right and then left in one motion path. On Android, [onScrollUp] and
        /// [onScrollLeft] share the same gesture. Therefore, only on of them should
        /// be provided.
        /// </Summary>
        public virtual VoidCallback OnScrollLeft { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.scrollRight].
        ///
        /// This is the semantic equivalent of a user moving their finger across the
        /// screen from left to right. It should be recognized by controls that are
        /// horizontally scrollable.
        ///
        /// VoiceOver users on iOS can trigger this action by swiping right with three
        /// fingers. TalkBack users on Android can trigger this action by swiping
        /// left and then right in one motion path. On Android, [onScrollDown] and
        /// [onScrollRight] share the same gesture. Therefore, only on of them should
        /// be provided.
        /// </Summary>
        public virtual VoidCallback OnScrollRight { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.scrollUp].
        ///
        /// This is the semantic equivalent of a user moving their finger across the
        /// screen from bottom to top. It should be recognized by controls that are
        /// vertically scrollable.
        ///
        /// VoiceOver users on iOS can trigger this action by swiping up with three
        /// fingers. TalkBack users on Android can trigger this action by swiping
        /// right and then left in one motion path. On Android, [onScrollUp] and
        /// [onScrollLeft] share the same gesture. Therefore, only on of them should
        /// be provided.
        /// </Summary>
        public virtual VoidCallback OnScrollUp { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.scrollDown].
        ///
        /// This is the semantic equivalent of a user moving their finger across the
        /// screen from top to bottom. It should be recognized by controls that are
        /// vertically scrollable.
        ///
        /// VoiceOver users on iOS can trigger this action by swiping down with three
        /// fingers. TalkBack users on Android can trigger this action by swiping
        /// left and then right in one motion path. On Android, [onScrollDown] and
        /// [onScrollRight] share the same gesture. Therefore, only on of them should
        /// be provided.
        /// </Summary>
        public virtual VoidCallback OnScrollDown { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.increase].
        ///
        /// This is a request to increase the value represented by the widget. For
        /// example, this action might be recognized by a slider control.
        ///
        /// If a [value] is set, [increasedValue] must also be provided and
        /// [onIncrease] must ensure that [value] will be set to [increasedValue].
        ///
        /// VoiceOver users on iOS can trigger this action by swiping up with one
        /// finger. TalkBack users on Android can trigger this action by pressing the
        /// volume up button.
        /// </Summary>
        public virtual VoidCallback OnIncrease { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.decrease].
        ///
        /// This is a request to decrease the value represented by the widget. For
        /// example, this action might be recognized by a slider control.
        ///
        /// If a [value] is set, [decreasedValue] must also be provided and
        /// [onDecrease] must ensure that [value] will be set to [decreasedValue].
        ///
        /// VoiceOver users on iOS can trigger this action by swiping down with one
        /// finger. TalkBack users on Android can trigger this action by pressing the
        /// volume down button.
        /// </Summary>
        public virtual VoidCallback OnDecrease { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.copy].
        ///
        /// This is a request to copy the current selection to the clipboard.
        ///
        /// TalkBack users on Android can trigger this action from the local context
        /// menu of a text field, for example.
        /// </Summary>
        public virtual VoidCallback OnCopy { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.cut].
        ///
        /// This is a request to cut the current selection and place it in the
        /// clipboard.
        ///
        /// TalkBack users on Android can trigger this action from the local context
        /// menu of a text field, for example.
        /// </Summary>
        public virtual VoidCallback OnCut { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.paste].
        ///
        /// This is a request to paste the current content of the clipboard.
        ///
        /// TalkBack users on Android can trigger this action from the local context
        /// menu of a text field, for example.
        /// </Summary>
        public virtual VoidCallback OnPaste { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.onMoveCursorForwardByCharacter].
        ///
        /// This handler is invoked when the user wants to move the cursor in a
        /// text field forward by one character.
        ///
        /// TalkBack users can trigger this by pressing the volume up key while the
        /// input focus is in a text field.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByCharacter { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.onMoveCursorBackwardByCharacter].
        ///
        /// This handler is invoked when the user wants to move the cursor in a
        /// text field backward by one character.
        ///
        /// TalkBack users can trigger this by pressing the volume down key while the
        /// input focus is in a text field.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByCharacter { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.onMoveCursorForwardByWord].
        ///
        /// This handler is invoked when the user wants to move the cursor in a
        /// text field backward by one word.
        ///
        /// TalkBack users can trigger this by pressing the volume down key while the
        /// input focus is in a text field.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByWord { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.onMoveCursorBackwardByWord].
        ///
        /// This handler is invoked when the user wants to move the cursor in a
        /// text field backward by one word.
        ///
        /// TalkBack users can trigger this by pressing the volume down key while the
        /// input focus is in a text field.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByWord { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.setSelection].
        ///
        /// This handler is invoked when the user either wants to change the currently
        /// selected text in a text field or change the position of the cursor.
        ///
        /// TalkBack users can trigger this handler by selecting "Move cursor to
        /// beginning/end" or "Select all" from the local context menu.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler OnSetSelection { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.didGainAccessibilityFocus].
        ///
        /// This handler is invoked when the node annotated with this handler gains
        /// the accessibility focus. The accessibility focus is the
        /// green (on Android with TalkBack) or black (on iOS with VoiceOver)
        /// rectangle shown on screen to indicate what element an accessibility
        /// user is currently interacting with.
        ///
        /// The accessibility focus is different from the input focus. The input focus
        /// is usually held by the element that currently responds to keyboard inputs.
        /// Accessibility focus and input focus can be held by two different nodes!
        ///
        /// See also:
        ///
        ///  * [onDidLoseAccessibilityFocus], which is invoked when the accessibility
        ///    focus is removed from the node.
        ///  * [FocusNode], [FocusScope], [FocusManager], which manage the input focus.
        /// </Summary>
        public virtual VoidCallback OnDidGainAccessibilityFocus { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.didLoseAccessibilityFocus].
        ///
        /// This handler is invoked when the node annotated with this handler
        /// loses the accessibility focus. The accessibility focus is
        /// the green (on Android with TalkBack) or black (on iOS with VoiceOver)
        /// rectangle shown on screen to indicate what element an accessibility
        /// user is currently interacting with.
        ///
        /// The accessibility focus is different from the input focus. The input focus
        /// is usually held by the element that currently responds to keyboard inputs.
        /// Accessibility focus and input focus can be held by two different nodes!
        ///
        /// See also:
        ///
        ///  * [onDidGainAccessibilityFocus], which is invoked when the node gains
        ///    accessibility focus.
        ///  * [FocusNode], [FocusScope], [FocusManager], which manage the input focus.
        /// </Summary>
        public virtual VoidCallback OnDidLoseAccessibilityFocus { get; set; }
        /// <Summary>
        /// The handler for [SemanticsAction.dismiss].
        ///
        /// This is a request to dismiss the currently focused node.
        ///
        /// TalkBack users on Android can trigger this action in the local context
        /// menu, and VoiceOver users on iOS can trigger this action with a standard
        /// gesture or menu option.
        /// </Summary>
        public virtual VoidCallback OnDismiss { get; set; }
        /// <Summary>
        /// A map from each supported [CustomSemanticsAction] to a provided handler.
        ///
        /// The handler associated with each custom action is called whenever a
        /// semantics event of type [SemanticsEvent.customEvent] is received. The
        /// provided argument will be an identifier used to retrieve an instance of
        /// a custom action which can then retrieve the correct handler from this map.
        ///
        /// See also:
        ///
        ///  * [CustomSemanticsAction], for an explanation of custom actions.
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> CustomSemanticsActions { get; set; }

        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<bool>("checked", Checked, defaultValue: null));
            properties.Add(new DiagnosticsProperty<bool>("selected", Selected, defaultValue: null));
            properties.Add(new StringProperty("label", Label, defaultValue: ""));
            properties.Add(new StringProperty("value", Value));
            properties.Add(new StringProperty("hint", Hint));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
            properties.Add(new DiagnosticsProperty<SemanticsSortKey>("sortKey", SortKey, defaultValue: null));
            properties.Add(new DiagnosticsProperty<SemanticsHintOverrides>("hintOverrides", HintOverrides));
        }




        public new string ToStringShort() => ObjectDefaultClass.ObjectRuntimeType(this, "SemanticsProperties");


    }


    /// <Summary>
    /// A node that represents some semantic data.
    ///
    /// The semantics tree is maintained during the semantics phase of the pipeline
    /// (i.e., during [PipelineOwner.flushSemantics]), which happens after
    /// compositing. The semantics tree is then uploaded into the engine for use
    /// by assistive technology.
    /// </Summary>
    public class SemanticsNode : FlutterSDK.Foundation.Node.AbstractNode, IDiagnosticableTreeMixin
    {
        /// <Summary>
        /// Creates a semantic node.
        ///
        /// Each semantic node has a unique identifier that is assigned when the node
        /// is created.
        /// </Summary>
        public SemanticsNode(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback showOnScreen = default(VoidCallback))
        : base()
        {
            this.Key = key;
        }
        /// <Summary>
        /// Creates a semantic node to represent the root of the semantics tree.
        ///
        /// The root node is assigned an identifier of zero.
        /// </Summary>
        public static SemanticsNode Root(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback showOnScreen = default(VoidCallback), FlutterSDK.Semantics.Semantics.SemanticsOwner owner = default(FlutterSDK.Semantics.Semantics.SemanticsOwner))
        => new SemanticsNode(key, showOnScreen, owner);

        private SemanticsNode(FlutterSDK.Foundation.Key.Key key, VoidCallback showOnScreen, FlutterSDK.Semantics.Semantics.SemanticsOwner owner)
        : base()
        {
            this.Key = key;
            Attach(owner);
        }


        internal virtual int _MaxFrameworkAccessibilityIdentifier { get; set; }
        internal virtual int _LastIdentifier { get; set; }
        /// <Summary>
        /// Uniquely identifies this node in the list of sibling nodes.
        ///
        /// Keys are used during the construction of the semantics tree. They are not
        /// transferred to the engine.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.Key Key { get; set; }
        /// <Summary>
        /// The unique identifier for this node.
        ///
        /// The root node has an id of zero. Other nodes are given a unique id when
        /// they are created.
        /// </Summary>
        public virtual int Id { get; set; }
        internal virtual VoidCallback _ShowOnScreen { get; set; }
        internal virtual Matrix4 _Transform { get; set; }
        internal virtual FlutterBinding.UI.Rect _Rect { get; set; }
        /// <Summary>
        /// The semantic clip from an ancestor that was applied to this node.
        ///
        /// Expressed in the coordinate system of the node. May be null if no clip has
        /// been applied.
        ///
        /// Descendant [SemanticsNode]s that are positioned outside of this rect will
        /// be excluded from the semantics tree. Descendant [SemanticsNode]s that are
        /// overlapping with this rect, but are outside of [parentPaintClipRect] will
        /// be included in the tree, but they will be marked as hidden because they
        /// are assumed to be not visible on screen.
        ///
        /// If this rect is null, all descendant [SemanticsNode]s outside of
        /// [parentPaintClipRect] will be excluded from the tree.
        ///
        /// If this rect is non-null it has to completely enclose
        /// [parentPaintClipRect]. If [parentPaintClipRect] is null this property is
        /// also null.
        /// </Summary>
        public virtual FlutterBinding.UI.Rect ParentSemanticsClipRect { get; set; }
        /// <Summary>
        /// The paint clip from an ancestor that was applied to this node.
        ///
        /// Expressed in the coordinate system of the node. May be null if no clip has
        /// been applied.
        ///
        /// Descendant [SemanticsNode]s that are positioned outside of this rect will
        /// either be excluded from the semantics tree (if they have no overlap with
        /// [parentSemanticsClipRect]) or they will be included and marked as hidden
        /// (if they are overlapping with [parentSemanticsClipRect]).
        ///
        /// This rect is completely enclosed by [parentSemanticsClipRect].
        ///
        /// If this rect is null [parentSemanticsClipRect] also has to be null.
        /// </Summary>
        public virtual FlutterBinding.UI.Rect ParentPaintClipRect { get; set; }
        /// <Summary>
        /// The elevation adjustment that the parent imposes on this node.
        ///
        /// The [elevation] property is relative to the elevation of the parent
        /// [SemanticsNode]. However, as [SemanticsConfiguration]s from various
        /// ascending [RenderObjects] are merged into each other to form that
        /// [SemanticsNode] the parent’s elevation may change. This requires an
        /// adjustment of the child’s relative elevation which is represented by this
        /// value.
        ///
        /// The value is rarely accessed directly. Instead, for most use cases the
        /// [elevation] value should be used, which includes this adjustment.
        ///
        /// See also:
        ///
        ///  * [elevation], the actual elevation of this [SemanticsNode].
        /// </Summary>
        public virtual double ElevationAdjustment { get; set; }
        /// <Summary>
        /// The index of this node within the parent's list of semantic children.
        ///
        /// This includes all semantic nodes, not just those currently in the
        /// child list. For example, if a scrollable has five children but the first
        /// two are not visible (and thus not included in the list of children), then
        /// the index of the last node will still be 4.
        /// </Summary>
        public virtual int IndexInParent { get; set; }
        internal virtual bool _IsMergedIntoParent { get; set; }
        internal virtual bool _MergeAllDescendantsIntoThisNode { get; set; }
        /// <Summary>
        /// Contains the children in inverse hit test order (i.e. paint order).
        /// </Summary>
        internal virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> _Children { get; set; }
        /// <Summary>
        /// A snapshot of `newChildren` passed to [_replaceChildren] that we keep in
        /// debug mode. It supports the assertion that user does not mutate the list
        /// of children.
        /// </Summary>
        internal virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> _DebugPreviousSnapshot { get; set; }
        internal virtual bool _Dead { get; set; }
        internal virtual bool _Dirty { get; set; }
        internal virtual Dictionary<SemanticsAction, object> _Actions { get; set; }
        internal virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> _CustomSemanticsActions { get; set; }
        internal virtual int _ActionsAsBits { get; set; }
        /// <Summary>
        /// The [SemanticsTag]s this node is tagged with.
        ///
        /// Tags are used during the construction of the semantics tree. They are not
        /// transferred to the engine.
        /// </Summary>
        public virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> Tags { get; set; }
        internal virtual int _Flags { get; set; }
        internal virtual string _Label { get; set; }
        internal virtual string _Value { get; set; }
        internal virtual string _DecreasedValue { get; set; }
        internal virtual string _IncreasedValue { get; set; }
        internal virtual string _Hint { get; set; }
        internal virtual double _Elevation { get; set; }
        internal virtual double _Thickness { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides _HintOverrides { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey _SortKey { get; set; }
        internal virtual FlutterSDK.Services.Textediting.TextSelection _TextSelection { get; set; }
        internal virtual bool _IsMultiline { get; set; }
        internal virtual int _ScrollChildCount { get; set; }
        internal virtual int _ScrollIndex { get; set; }
        internal virtual double _ScrollPosition { get; set; }
        internal virtual double _ScrollExtentMax { get; set; }
        internal virtual double _ScrollExtentMin { get; set; }
        internal virtual int _PlatformViewId { get; set; }
        internal virtual int _MaxValueLength { get; set; }
        internal virtual int _CurrentValueLength { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration _KEmptyConfig { get; set; }
        internal virtual List<uint> _KEmptyChildList { get; set; }
        internal virtual List<uint> _KEmptyCustomSemanticsActionsList { get; set; }
        internal virtual List<float> _KIdentityTransform { get; set; }
        public virtual object Transform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect Rect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsInvisible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsMergedIntoParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsPartOfNodeMerging { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool MergeAllDescendantsIntoThisNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasChildren { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int ChildrenCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsOwner Owner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsNode Parent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string Label { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DecreasedValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string IncreasedValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string Hint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Elevation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Thickness { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverrides { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Textediting.TextSelection TextSelection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsMultiline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int ScrollChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int ScrollIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double ScrollPosition { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double ScrollExtentMax { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double ScrollExtentMin { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int PlatformViewId { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int MaxValueLength { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int CurrentValueLength { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private int _GenerateNewId()
        {
            _LastIdentifier = (_LastIdentifier + 1) % _MaxFrameworkAccessibilityIdentifier;
            return _LastIdentifier;
        }




        private void _ReplaceChildren(List<FlutterSDK.Semantics.Semantics.SemanticsNode> newChildren)
        {



            if (_Children != null)
            {
                foreach (SemanticsNode child in _Children) child._Dead = true;
            }

            if (newChildren != null)
            {
                foreach (SemanticsNode child in newChildren)
                {

                    child._Dead = false;
                }

            }

            bool sawChange = false;
            if (_Children != null)
            {
                foreach (SemanticsNode child in _Children)
                {
                    if (child._Dead)
                    {
                        if (child.Parent == this)
                        {
                            DropChild(child);
                        }

                        sawChange = true;
                    }

                }

            }

            if (newChildren != null)
            {
                foreach (SemanticsNode child in newChildren)
                {
                    if (child.Parent != this)
                    {
                        if (child.Parent != null)
                        {
                            child.Parent?.DropChild(child);
                        }


                        AdoptChild(child);
                        sawChange = true;
                    }

                }

            }

            if (!sawChange && _Children != null)
            {


                for (int i = 0; i < _Children.Count; i++)
                {
                    if (_Children[i].Id != newChildren[i].Id)
                    {
                        sawChange = true;
                        break;
                    }

                }

            }

            _Children = newChildren;
            if (sawChange) _MarkDirty();
        }




        /// <Summary>
        /// Visits the immediate children of this node.
        ///
        /// This function calls visitor for each immediate child until visitor returns
        /// false. Returns true if all the visitor calls returned true, otherwise
        /// returns false.
        /// </Summary>
        public virtual void VisitChildren(FlutterSDK.Semantics.Semantics.SemanticsNodeVisitor visitor)
        {
            if (_Children != null)
            {
                foreach (SemanticsNode child in _Children)
                {
                    if (!visitor(child)) return;
                }

            }

        }




        /// <Summary>
        /// Visit all the descendants of this node.
        ///
        /// This function calls visitor for each descendant in a pre-order traversal
        /// until visitor returns false. Returns true if all the visitor calls
        /// returned true, otherwise returns false.
        /// </Summary>
        private bool _VisitDescendants(FlutterSDK.Semantics.Semantics.SemanticsNodeVisitor visitor)
        {
            if (_Children != null)
            {
                foreach (SemanticsNode child in _Children)
                {
                    if (!visitor(child) || !child._VisitDescendants(visitor)) return false;
                }

            }

            return true;
        }




        public new void RedepthChildren()
        {
            _Children?.ForEach(RedepthChild);
        }




        public new void Attach(FlutterSDK.Semantics.Semantics.SemanticsOwner owner)
        {
            base.Attach(owner);

            owner._Nodes[Id] = this;
            owner._DetachedNodes.Remove(this);
            if (_Dirty)
            {
                _Dirty = false;
                _MarkDirty();
            }

            if (_Children != null)
            {
                foreach (SemanticsNode child in _Children) child.Attach(owner);
            }

        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);

            owner._Nodes[Id] = this;
            owner._DetachedNodes.Remove(this);
            if (_Dirty)
            {
                _Dirty = false;
                _MarkDirty();
            }

            if (_Children != null)
            {
                foreach (SemanticsNode child in _Children) child.Attach(owner);
            }

        }




        public new void Detach()
        {


            Owner._Nodes.Remove(Id);
            Owner._DetachedNodes.Add(this);
            base.Detach();

            if (_Children != null)
            {
                foreach (SemanticsNode child in _Children)
                {
                    if (child.Parent == this) child.Detach();
                }

            }

            _MarkDirty();
        }




        private void _MarkDirty()
        {
            if (_Dirty) return;
            _Dirty = true;
            if (Attached)
            {

                Owner._DirtyNodes.Add(this);
            }

        }




        private bool _IsDifferentFromCurrentSemanticAnnotation(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            return _Label != config.Label || _Hint != config.Hint || _Elevation != config.Elevation || _Thickness != config.Thickness || _DecreasedValue != config.DecreasedValue || _Value != config.Value || _IncreasedValue != config.IncreasedValue || _Flags != config._Flags || _TextDirection != config.TextDirection || _SortKey != config._SortKey || _TextSelection != config._TextSelection || _ScrollPosition != config._ScrollPosition || _ScrollExtentMax != config._ScrollExtentMax || _ScrollExtentMin != config._ScrollExtentMin || _ActionsAsBits != config._ActionsAsBits || IndexInParent != config.IndexInParent || PlatformViewId != config.PlatformViewId || _MaxValueLength != config._MaxValueLength || _CurrentValueLength != config._CurrentValueLength || _MergeAllDescendantsIntoThisNode != config.IsMergingSemanticsOfDescendants;
        }




        /// <Summary>
        /// Whether this node is tagged with `tag`.
        /// </Summary>
        public virtual bool IsTagged(FlutterSDK.Semantics.Semantics.SemanticsTag tag) => Tags != null && Tags.Contains(tag);



        /// <Summary>
        /// Whether this node currently has a given [SemanticsFlag].
        /// </Summary>
        public virtual bool HasFlag(SemanticsFlag flag) => _Flags & flag.Index != 0;



        private bool _CanPerformAction(SemanticsAction action) => _Actions.ContainsKey(action);



        /// <Summary>
        /// Reconfigures the properties of this object to describe the configuration
        /// provided in the `config` argument and the children listed in the
        /// `childrenInInversePaintOrder` argument.
        ///
        /// The arguments may be null; this represents an empty configuration (all
        /// values at their defaults, no children).
        ///
        /// No reference is kept to the [SemanticsConfiguration] object, but the child
        /// list is used as-is and should therefore not be changed after this call.
        /// </Summary>
        public virtual void UpdateWith(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config = default(FlutterSDK.Semantics.Semantics.SemanticsConfiguration), List<FlutterSDK.Semantics.Semantics.SemanticsNode> childrenInInversePaintOrder = default(List<FlutterSDK.Semantics.Semantics.SemanticsNode>))
        {
            config = (config == null ? _KEmptyConfig : config);
            if (_IsDifferentFromCurrentSemanticAnnotation(config)) _MarkDirty();

            _Label = config.Label;
            _DecreasedValue = config.DecreasedValue;
            _Value = config.Value;
            _IncreasedValue = config.IncreasedValue;
            _Hint = config.Hint;
            _HintOverrides = config.HintOverrides;
            _Elevation = config.Elevation;
            _Thickness = config.Thickness;
            _Flags = config._Flags;
            _TextDirection = config.TextDirection;
            _SortKey = config.SortKey;
            _Actions = Dictionary<SemanticsAction, _SemanticsActionHandler>.From(config._Actions);
            _CustomSemanticsActions = Dictionary<CustomSemanticsAction, VoidCallback>.From(config._CustomSemanticsActions);
            _ActionsAsBits = config._ActionsAsBits;
            _TextSelection = config._TextSelection;
            _IsMultiline = config.IsMultiline;
            _ScrollPosition = config._ScrollPosition;
            _ScrollExtentMax = config._ScrollExtentMax;
            _ScrollExtentMin = config._ScrollExtentMin;
            _MergeAllDescendantsIntoThisNode = config.IsMergingSemanticsOfDescendants;
            _ScrollChildCount = config.ScrollChildCount;
            _ScrollIndex = config.ScrollIndex;
            IndexInParent = config.IndexInParent;
            _PlatformViewId = config._PlatformViewId;
            _MaxValueLength = config._MaxValueLength;
            _CurrentValueLength = config._CurrentValueLength;
            _ReplaceChildren(childrenInInversePaintOrder ?? new List<SemanticsNode>() { });


        }




        /// <Summary>
        /// Returns a summary of the semantics for this node.
        ///
        /// If this node has [mergeAllDescendantsIntoThisNode], then the returned data
        /// includes the information from this node's descendants. Otherwise, the
        /// returned data matches the data on this node.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.SemanticsData GetSemanticsData()
        {
            int flags = _Flags;
            int actions = _ActionsAsBits;
            string label = _Label;
            string hint = _Hint;
            string value = _Value;
            string increasedValue = _IncreasedValue;
            string decreasedValue = _DecreasedValue;
            TextDirection textDirection = _TextDirection;
            HashSet<SemanticsTag> mergedTags = Tags == null ? null : HashSet<SemanticsTag>.From(Tags);
            TextSelection textSelection = _TextSelection;
            int scrollChildCount = _ScrollChildCount;
            int scrollIndex = _ScrollIndex;
            double scrollPosition = _ScrollPosition;
            double scrollExtentMax = _ScrollExtentMax;
            double scrollExtentMin = _ScrollExtentMin;
            int platformViewId = _PlatformViewId;
            int maxValueLength = _MaxValueLength;
            int currentValueLength = _CurrentValueLength;
            double elevation = _Elevation;
            double thickness = _Thickness;
            HashSet<int> customSemanticsActionIds = new Dictionary<int> { };
            foreach (CustomSemanticsAction action in _CustomSemanticsActions.Keys) customSemanticsActionIds.Add(SemanticsDefaultClass.CustomSemanticsAction.GetIdentifier(action));
            if (HintOverrides != null)
            {
                if (HintOverrides.OnTapHint != null)
                {
                    CustomSemanticsAction action = CustomSemanticsAction.OverridingAction(hint: HintOverrides.OnTapHint, action: Dart.UiDefaultClass.SemanticsAction.Tap);
                    customSemanticsActionIds.Add(SemanticsDefaultClass.CustomSemanticsAction.GetIdentifier(action));
                }

                if (HintOverrides.OnLongPressHint != null)
                {
                    CustomSemanticsAction action = CustomSemanticsAction.OverridingAction(hint: HintOverrides.OnLongPressHint, action: Dart.UiDefaultClass.SemanticsAction.LongPress);
                    customSemanticsActionIds.Add(SemanticsDefaultClass.CustomSemanticsAction.GetIdentifier(action));
                }

            }

            if (MergeAllDescendantsIntoThisNode)
            {
                _VisitDescendants((SemanticsNode node) =>
                {

                    flags |= node._Flags;
                    actions |= node._ActionsAsBits;
                    textDirection = (textDirection == null ? node._TextDirection : textDirection);
                    textSelection = (textSelection == null ? node._TextSelection : textSelection);
                    scrollChildCount = (scrollChildCount == null ? node._ScrollChildCount : scrollChildCount);
                    scrollIndex = (scrollIndex == null ? node._ScrollIndex : scrollIndex);
                    scrollPosition = (scrollPosition == null ? node._ScrollPosition : scrollPosition);
                    scrollExtentMax = (scrollExtentMax == null ? node._ScrollExtentMax : scrollExtentMax);
                    scrollExtentMin = (scrollExtentMin == null ? node._ScrollExtentMin : scrollExtentMin);
                    platformViewId = (platformViewId == null ? node._PlatformViewId : platformViewId);
                    maxValueLength = (maxValueLength == null ? node._MaxValueLength : maxValueLength);
                    currentValueLength = (currentValueLength == null ? node._CurrentValueLength : currentValueLength);
                    if (value == "" || value == null) value = node._Value;
                    if (increasedValue == "" || increasedValue == null) increasedValue = node._IncreasedValue;
                    if (decreasedValue == "" || decreasedValue == null) decreasedValue = node._DecreasedValue;
                    if (node.Tags != null)
                    {
                        mergedTags = (mergedTags == null ? new Dictionary<SemanticsTag> { } : mergedTags);
                        mergedTags.AddAll(node.Tags);
                    }

                    if (node._CustomSemanticsActions != null)
                    {
                        foreach (CustomSemanticsAction action in _CustomSemanticsActions.Keys) customSemanticsActionIds.Add(SemanticsDefaultClass.CustomSemanticsAction.GetIdentifier(action));
                    }

                    if (node.HintOverrides != null)
                    {
                        if (node.HintOverrides.OnTapHint != null)
                        {
                            CustomSemanticsAction action = CustomSemanticsAction.OverridingAction(hint: node.HintOverrides.OnTapHint, action: Dart.UI.UiDefaultClass.SemanticsAction.Tap);
                            customSemanticsActionIds.Add(SemanticsDefaultClass.CustomSemanticsAction.GetIdentifier(action));
                        }

                        if (node.HintOverrides.OnLongPressHint != null)
                        {
                            CustomSemanticsAction action = CustomSemanticsAction.OverridingAction(hint: node.HintOverrides.OnLongPressHint, action: Dart.UiDefaultClass.SemanticsAction.LongPress);
                            customSemanticsActionIds.Add(SemanticsDefaultClass.CustomSemanticsAction.GetIdentifier(action));
                        }

                    }

                    label = SemanticsDefaultClass._ConcatStrings(thisString: label, thisTextDirection: textDirection, otherString: node._Label, otherTextDirection: node._TextDirection);
                    hint = SemanticsDefaultClass._ConcatStrings(thisString: hint, thisTextDirection: textDirection, otherString: node._Hint, otherTextDirection: node._TextDirection);
                    thickness = Dart.Math.MathDefaultClass.Max(thickness, node._Thickness + node._Elevation);
                    return true;
                }
                );
            }

            return new SemanticsData(flags: flags, actions: actions, label: label, value: value, increasedValue: increasedValue, decreasedValue: decreasedValue, hint: hint, textDirection: textDirection, rect: Rect, transform: Transform, elevation: elevation, thickness: thickness, tags: mergedTags, textSelection: textSelection, scrollChildCount: scrollChildCount, scrollIndex: scrollIndex, scrollPosition: scrollPosition, scrollExtentMax: scrollExtentMax, scrollExtentMin: scrollExtentMin, platformViewId: platformViewId, maxValueLength: maxValueLength, currentValueLength: currentValueLength, customSemanticsActionIds: customSemanticsActionIds.ToList();
            customSemanticsActionIds.ToList().Sort());
        }




        private List<float> _InitIdentityTransform()
        {
            return Matrix4.Identity().Storage;
        }




        private void _AddToUpdate(SemanticsUpdateBuilder builder, HashSet<int> customSemanticsActionIdsUpdate)
        {

            SemanticsData data = GetSemanticsData();
            List<uint> childrenInTraversalOrder = default(List<uint>);
            List<uint> childrenInHitTestOrder = default(List<uint>);
            if (!HasChildren || MergeAllDescendantsIntoThisNode)
            {
                childrenInTraversalOrder = _KEmptyChildList;
                childrenInHitTestOrder = _KEmptyChildList;
            }
            else
            {
                int childCount = _Children.Count;
                List<SemanticsNode> sortedChildren = _ChildrenInTraversalOrder();
                childrenInTraversalOrder = new List<uint>(childCount);
                for (int i = 0; i < childCount; i += 1)
                {
                    childrenInTraversalOrder[i] = sortedChildren[i].Id;
                }

                childrenInHitTestOrder = new List<uint>(childCount);
                for (int i = childCount - 1; i >= 0; i -= 1)
                {
                    childrenInHitTestOrder[i] = _Children[childCount - i - 1].Id;
                }

            }

            List<uint> customSemanticsActionIds = default(List<uint>);
            if (data.CustomSemanticsActionIds?.IsNotEmpty == true)
            {
                customSemanticsActionIds = new List<uint>(data.CustomSemanticsActionIds.Count);
                for (int i = 0; i < data.CustomSemanticsActionIds.Count; i++)
                {
                    customSemanticsActionIds[i] = data.CustomSemanticsActionIds[i];
                    customSemanticsActionIdsUpdate.Add(data.CustomSemanticsActionIds[i]);
                }

            }

            builder.UpdateNode(id: Id, flags: data.Flags, actions: data.Actions, rect: data.Rect, label: data.Label, value: data.Value, decreasedValue: data.DecreasedValue, increasedValue: data.IncreasedValue, hint: data.Hint, textDirection: data.TextDirection, textSelectionBase: data.TextSelection != null ? data.TextSelection.BaseOffset : -1, textSelectionExtent: data.TextSelection != null ? data.TextSelection.ExtentOffset : -1, platformViewId: data.PlatformViewId ?? -1, maxValueLength: data.MaxValueLength ?? -1, currentValueLength: data.CurrentValueLength ?? -1, scrollChildren: data.ScrollChildCount ?? 0, scrollIndex: data.ScrollIndex ?? 0, scrollPosition: data.ScrollPosition ?? Dart.CoreDefaultClass.Double.Nan, scrollExtentMax: data.ScrollExtentMax ?? Dart.CoreDefaultClass.Double.Nan, scrollExtentMin: data.ScrollExtentMin ?? Dart.CoreDefaultClass.Double.Nan, transform: data.Transform?.Storage ?? _KIdentityTransform, elevation: data.Elevation, thickness: data.Thickness, childrenInTraversalOrder: childrenInTraversalOrder, childrenInHitTestOrder: childrenInHitTestOrder, additionalActions: customSemanticsActionIds ?? _KEmptyCustomSemanticsActionsList);
            _Dirty = false;
        }




        /// <Summary>
        /// Builds a new list made of [_children] sorted in semantic traversal order.
        /// </Summary>
        private List<FlutterSDK.Semantics.Semantics.SemanticsNode> _ChildrenInTraversalOrder()
        {
            TextDirection inheritedTextDirection = TextDirection;
            SemanticsNode ancestor = Parent;
            while (inheritedTextDirection == null && ancestor != null)
            {
                inheritedTextDirection = ancestor.TextDirection;
                ancestor = ancestor.Parent;
            }

            List<SemanticsNode> childrenInDefaultOrder = default(List<SemanticsNode>);
            if (inheritedTextDirection != null)
            {
                childrenInDefaultOrder = SemanticsDefaultClass._ChildrenInDefaultOrder(_Children, inheritedTextDirection);
            }
            else
            {
                childrenInDefaultOrder = _Children;
            }

            List<_TraversalSortNode> everythingSorted = new List<_TraversalSortNode>() { };
            List<_TraversalSortNode> sortNodes = new List<_TraversalSortNode>() { };
            SemanticsSortKey lastSortKey = default(SemanticsSortKey);
            for (int position = 0; position < childrenInDefaultOrder.Count; position += 1)
            {
                SemanticsNode child = childrenInDefaultOrder[position];
                SemanticsSortKey sortKey = child.SortKey;
                lastSortKey = position > 0 ? childrenInDefaultOrder[position - 1].SortKey : null;
                bool isCompatibleWithPreviousSortKey = position == 0 || sortKey.GetType() == lastSortKey.GetType() && (sortKey == null || sortKey.Name == lastSortKey.Name);
                if (!isCompatibleWithPreviousSortKey && sortNodes.IsNotEmpty)
                {
                    if (lastSortKey != null)
                    {
                        sortNodes.Sort();
                    }

                    everythingSorted.AddAll(sortNodes);
                    sortNodes.Clear();
                }

                sortNodes.Add(new _TraversalSortNode(node: child, sortKey: sortKey, position: position));
            }

            if (lastSortKey != null)
            {
                sortNodes.Sort();
            }

            everythingSorted.AddAll(sortNodes);
            return everythingSorted.Map((_TraversalSortNode sortNode) => =>sortNode.Node).ToList();
        }




        /// <Summary>
        /// Sends a [SemanticsEvent] associated with this [SemanticsNode].
        ///
        /// Semantics events should be sent to inform interested parties (like
        /// the accessibility system of the operating system) about changes to the UI.
        ///
        /// For example, if this semantics node represents a scrollable list, a
        /// [ScrollCompletedSemanticsEvent] should be sent after a scroll action is completed.
        /// That way, the operating system can give additional feedback to the user
        /// about the state of the UI (e.g. on Android a ping sound is played to
        /// indicate a successful scroll in accessibility mode).
        /// </Summary>
        public virtual void SendEvent(FlutterSDK.Semantics.Semanticsevent.SemanticsEvent @event)
        {
            if (!Attached) return;
            SystemchannelsDefaultClass.SystemChannels.Accessibility.Send(@event.ToMap(nodeId: Id));
        }




        public new string ToStringShort() => $"'{ObjectDefaultClass.ObjectRuntimeType(this, "SemanticsNode")}#{Id}'";



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            bool hideOwner = true;
            if (_Dirty)
            {
                bool inDirtyNodes = Owner != null && Owner._DirtyNodes.Contains(this);
                properties.Add(new FlagProperty("inDirtyNodes", value: inDirtyNodes, ifTrue: "dirty", ifFalse: "STALE"));
                hideOwner = inDirtyNodes;
            }

            properties.Add(new DiagnosticsProperty<SemanticsOwner>("owner", Owner, level: hideOwner ? DiagnosticLevel.Hidden : DiagnosticLevel.Info));
            properties.Add(new FlagProperty("isMergedIntoParent", value: IsMergedIntoParent, ifTrue: "merged up ⬆️"));
            properties.Add(new FlagProperty("mergeAllDescendantsIntoThisNode", value: MergeAllDescendantsIntoThisNode, ifTrue: "merge boundary ⛔️"));
            Offset offset = Transform != null ? MatrixutilsDefaultClass.MatrixUtils.GetAsTranslation(Transform) : null;
            if (offset != null)
            {
                properties.Add(new DiagnosticsProperty<Rect>("rect", Rect.Shift(offset), showName: false));
            }
            else
            {
                double scale = Transform != null ? MatrixutilsDefaultClass.MatrixUtils.GetAsScale(Transform) : null;
                string description = default(string);
                if (scale != null)
                {
                    description = $"'{Rect} scaled by {scale.ToStringAsFixed(1)}x'";
                }
                else if (Transform != null && !MatrixutilsDefaultClass.MatrixUtils.IsIdentity(Transform))
                {
                    string matrix = Transform.ToString().Split('\n').ToList().Take(4).Map((string line) => =>line.Substring(4)).Join("; ");
                    description = $"'{Rect} with transform [{matrix}]'";
                }

                properties.Add(new DiagnosticsProperty<Rect>("rect", Rect, description: description, showName: false));
            }

            properties.Add(new IterableProperty<string>("tags", Tags?.Map((SemanticsTag tag) => =>tag.Name), defaultValue: null));
            List<string> actions = _Actions.Keys.Map((SemanticsAction action) => =>DiagnosticsDefaultClass.DescribeEnum(action)).ToList();
            _Actions.Keys.Map((SemanticsAction action) => =>DiagnosticsDefaultClass.DescribeEnum(action)).ToList().Sort();
            List<string> customSemanticsActions = _CustomSemanticsActions.Keys.Map((CustomSemanticsAction action) => =>action.Label).ToList();
            properties.Add(new IterableProperty<string>("actions", actions, ifEmpty: null));
            properties.Add(new IterableProperty<string>("customActions", customSemanticsActions, ifEmpty: null));
            List<string> flags = Dart.UI.UiDefaultClass.SemanticsFlag.Values.Values.Where((SemanticsFlag flag) => =>HasFlag(flag)).Map((SemanticsFlag flag) => =>flag.ToString().Substring("SemanticsFlag.".Length)).ToList();
            properties.Add(new IterableProperty<string>("flags", flags, ifEmpty: null));
            properties.Add(new FlagProperty("isInvisible", value: IsInvisible, ifTrue: "invisible"));
            properties.Add(new FlagProperty("isHidden", value: HasFlag(Dart.UI.UiDefaultClass.SemanticsFlag.IsHidden), ifTrue: "HIDDEN"));
            properties.Add(new StringProperty("label", _Label, defaultValue: ""));
            properties.Add(new StringProperty("value", _Value, defaultValue: ""));
            properties.Add(new StringProperty("increasedValue", _IncreasedValue, defaultValue: ""));
            properties.Add(new StringProperty("decreasedValue", _DecreasedValue, defaultValue: ""));
            properties.Add(new StringProperty("hint", _Hint, defaultValue: ""));
            properties.Add(new EnumProperty<TextDirection>("textDirection", _TextDirection, defaultValue: null));
            properties.Add(new DiagnosticsProperty<SemanticsSortKey>("sortKey", SortKey, defaultValue: null));
            if (_TextSelection?.IsValid == true) properties.Add(new MessageProperty("text selection", $"'[{_TextSelection.Start}, {_TextSelection.End}]'"));
            properties.Add(new IntProperty("platformViewId", PlatformViewId, defaultValue: null));
            properties.Add(new IntProperty("maxValueLength", MaxValueLength, defaultValue: null));
            properties.Add(new IntProperty("currentValueLength", CurrentValueLength, defaultValue: null));
            properties.Add(new IntProperty("scrollChildren", ScrollChildCount, defaultValue: null));
            properties.Add(new IntProperty("scrollIndex", ScrollIndex, defaultValue: null));
            properties.Add(new DoubleProperty("scrollExtentMin", ScrollExtentMin, defaultValue: null));
            properties.Add(new DoubleProperty("scrollPosition", ScrollPosition, defaultValue: null));
            properties.Add(new DoubleProperty("scrollExtentMax", ScrollExtentMax, defaultValue: null));
            properties.Add(new DoubleProperty("elevation", Elevation, defaultValue: 0.0));
            properties.Add(new DoubleProperty("thickness", Thickness, defaultValue: 0.0));
        }




        /// <Summary>
        /// Returns a string representation of this node and its descendants.
        ///
        /// The order in which the children of the [SemanticsNode] will be printed is
        /// controlled by the [childOrder] parameter.
        /// </Summary>
        public new string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel), FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder = default(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder))
        {

            return ToDiagnosticsNode(childOrder: childOrder).ToStringDeep(prefixLineOne: prefixLineOne, prefixOtherLines: prefixOtherLines, minLevel: minLevel);
        }




        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder = default(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder))
        {
            return new _SemanticsDiagnosticableNode(name: name, value: this, style: style, childOrder: childOrder);
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder = default(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder))
        {
            return DebugListChildrenInOrder(childOrder).Map((SemanticsNode node) => =>node.ToDiagnosticsNode(childOrder: childOrder)).ToList();
        }




        /// <Summary>
        /// Returns the list of direct children of this node in the specified order.
        /// </Summary>
        public virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> DebugListChildrenInOrder(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder)
        {

            if (_Children == null) return new List<SemanticsNode>() { };
            switch (childOrder) { case DebugSemanticsDumpOrder.InverseHitTest: return _Children; case DebugSemanticsDumpOrder.TraversalOrder: return _ChildrenInTraversalOrder(); }

            return null;
        }



    }


    /// <Summary>
    /// An edge of a box, such as top, bottom, left or right, used to compute
    /// [SemanticsNode]s that overlap vertically or horizontally.
    ///
    /// For computing horizontal overlap in an LTR setting we create two [_BoxEdge]
    /// objects for each [SemanticsNode]: one representing the left edge (marked
    /// with [isLeadingEdge] equal to true) and one for the right edge (with [isLeadingEdge]
    /// equal to false). Similarly, for vertical overlap we also create two objects
    /// for each [SemanticsNode], one for the top and one for the bottom edge.
    /// </Summary>
    public class _BoxEdge : IComparable<FlutterSDK.Semantics.Semantics._BoxEdge>
    {
        public _BoxEdge(bool isLeadingEdge = default(bool), double offset = default(double), FlutterSDK.Semantics.Semantics.SemanticsNode node = default(FlutterSDK.Semantics.Semantics.SemanticsNode))
        : base()
        {
            this.IsLeadingEdge = isLeadingEdge;
            this.Offset = offset;
            this.Node = node;
        }
        /// <Summary>
        /// True if the edge comes before the seconds edge along the traversal
        /// direction, and false otherwise.
        ///
        /// This field is never null.
        ///
        /// For example, in LTR traversal the left edge's [isLeadingEdge] is set to true,
        /// the right edge's [isLeadingEdge] is set to false. When considering vertical
        /// ordering of boxes, the top edge is the start edge, and the bottom edge is
        /// the end edge.
        /// </Summary>
        public virtual bool IsLeadingEdge { get; set; }
        /// <Summary>
        /// The offset from the start edge of the parent [SemanticsNode] in the
        /// direction of the traversal.
        /// </Summary>
        public virtual double Offset { get; set; }
        /// <Summary>
        /// The node whom this edge belongs.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.SemanticsNode Node { get; set; }

        public new int CompareTo(FlutterSDK.Semantics.Semantics._BoxEdge other)
        {
            return (Offset - other.Offset).Sign.ToInt();
        }



    }


    /// <Summary>
    /// A group of [nodes] that are disjoint vertically or horizontally from other
    /// nodes that share the same [SemanticsNode] parent.
    ///
    /// The [nodes] are sorted among each other separately from other nodes.
    /// </Summary>
    public class _SemanticsSortGroup : Comparable<FlutterSDK.Semantics.Semantics._SemanticsSortGroup>
    {
        public _SemanticsSortGroup(double startOffset = default(double), TextDirection textDirection = default(TextDirection))
        : base()
        {
            this.StartOffset = startOffset;
            this.TextDirection = textDirection;
        }
        /// <Summary>
        /// The offset from the start edge of the parent [SemanticsNode] in the
        /// direction of the traversal.
        ///
        /// This value is equal to the [_BoxEdge.offset] of the first node in the
        /// [nodes] list being considered.
        /// </Summary>
        public virtual double StartOffset { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        /// <Summary>
        /// The nodes that are sorted among each other.
        /// </Summary>
        public virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> Nodes { get; set; }

        public new int CompareTo(FlutterSDK.Semantics.Semantics._SemanticsSortGroup other)
        {
            return (StartOffset - other.StartOffset).Sign.ToInt();
        }




        /// <Summary>
        /// Sorts this group assuming that [nodes] belong to the same vertical group.
        ///
        /// This method breaks up this group into horizontal [_SemanticsSortGroup]s
        /// then sorts them using [sortedWithinKnot].
        /// </Summary>
        public virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> SortedWithinVerticalGroup()
        {
            List<_BoxEdge> edges = new List<_BoxEdge>() { };
            foreach (SemanticsNode child in Nodes)
            {
                Rect childRect = child.Rect.Deflate(0.1);
                edges.Add(new _BoxEdge(isLeadingEdge: true, offset: SemanticsDefaultClass._PointInParentCoordinates(child, childRect.TopLeft).Dx, node: child));
                edges.Add(new _BoxEdge(isLeadingEdge: false, offset: SemanticsDefaultClass._PointInParentCoordinates(child, childRect.BottomRight).Dx, node: child));
            }

            edges.Sort();
            List<_SemanticsSortGroup> horizontalGroups = new List<_SemanticsSortGroup>() { };
            _SemanticsSortGroup group = default(_SemanticsSortGroup);
            int depth = 0;
            foreach (_BoxEdge edge in edges)
            {
                if (edge.IsLeadingEdge)
                {
                    depth += 1;
                    group = (group == null ? new _SemanticsSortGroup(startOffset: edge.Offset, textDirection: TextDirection) : group);
                    group.Nodes.Add(edge.Node);
                }
                else
                {
                    depth -= 1;
                }

                if (depth == 0)
                {
                    horizontalGroups.Add(group);
                    group = null;
                }

            }

            horizontalGroups.Sort();
            if (TextDirection == TextDirection.Rtl)
            {
                horizontalGroups = horizontalGroups.Reversed.ToList();
            }

            return horizontalGroups.Expand((_SemanticsSortGroup group) => =>group.SortedWithinKnot()).ToList();
        }




        /// <Summary>
        /// Sorts [nodes] where nodes intersect both vertically and horizontally.
        ///
        /// In the special case when [nodes] contains one or less nodes, this method
        /// returns [nodes] unchanged.
        ///
        /// This method constructs a graph, where vertices are [SemanticsNode]s and
        /// edges are "traversed before" relation between pairs of nodes. The sort
        /// order is the topological sorting of the graph, with the original order of
        /// [nodes] used as the tie breaker.
        ///
        /// Whether a node is traversed before another node is determined by the
        /// vector that connects the two nodes' centers. If the vector "points to the
        /// right or down", defined as the [Offset.direction] being between `-pi/4`
        /// and `3*pi/4`), then the semantics node whose center is at the end of the
        /// vector is said to be traversed after.
        /// </Summary>
        public virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> SortedWithinKnot()
        {
            if (Nodes.Count <= 1)
            {
                return Nodes;
            }

            Dictionary<int, SemanticsNode> nodeMap = new Dictionary<int, SemanticsNode> { };
            Dictionary<int, int> edges = new Dictionary<int, int> { };
            foreach (SemanticsNode node in Nodes)
            {
                nodeMap[node.Id] = node;
                Offset center = SemanticsDefaultClass._PointInParentCoordinates(node, node.Rect.Center);
                foreach (SemanticsNode nextNode in Nodes)
                {
                    if (Dart.CoreDefaultClass.Identical(node, nextNode) || edges[nextNode.Id] == node.Id)
                    {
                        continue;
                    }

                    Offset nextCenter = SemanticsDefaultClass._PointInParentCoordinates(nextNode, nextNode.Rect.Center);
                    Offset centerDelta = nextCenter - center;
                    double direction = centerDelta.Direction;
                    bool isLtrAndForward = TextDirection == TextDirection.Ltr && -Math.Dart.MathDefaultClass.Pi / 4 < direction && direction < 3 * Math.Dart.MathDefaultClass.Pi / 4;
                    bool isRtlAndForward = TextDirection == TextDirection.Rtl && (direction < -3 * Math.Dart.MathDefaultClass.Pi / 4 || direction > 3 * Math.Dart.MathDefaultClass.Pi / 4);
                    if (isLtrAndForward || isRtlAndForward)
                    {
                        edges[node.Id] = nextNode.Id;
                    }

                }

            }

            List<int> sortedIds = new List<int>() { };
            HashSet<int> visitedIds = new Dictionary<int> { };
            List<SemanticsNode> startNodes = Nodes.ToList();
            Nodes.ToList().Sort((SemanticsNode a, SemanticsNode b) =>
            {
                Offset aTopLeft = SemanticsDefaultClass._PointInParentCoordinates(a, a.Rect.TopLeft);
                Offset bTopLeft = SemanticsDefaultClass._PointInParentCoordinates(b, b.Rect.TopLeft);
                int verticalDiff = aTopLeft.Dy.CompareTo(bTopLeft.Dy);
                if (verticalDiff != 0)
                {
                    return -verticalDiff;
                }

                return -aTopLeft.Dx.CompareTo(bTopLeft.Dx);
            }
            );
            void Search(int id)
            {
                if (visitedIds.Contains(id))
                {
                    return;
                }

                visitedIds.Add(id);
                if (edges.ContainsKey(id))
                {
                    Search(edges[id]);
                }

                sortedIds.Add(id);
            }

            startNodes.Map((SemanticsNode node) => =>node.Id).ForEach(Search);
            return sortedIds.Map((int id) => =>nodeMap[id]).ToList().Reversed.ToList();
        }



    }


    /// <Summary>
    /// The implementation of [Comparable] that implements the ordering of
    /// [SemanticsNode]s in the accessibility traversal.
    ///
    /// [SemanticsNode]s are sorted prior to sending them to the engine side.
    ///
    /// This implementation considers a [node]'s [sortKey] and its position within
    /// the list of its siblings. [sortKey] takes precedence over position.
    /// </Summary>
    public class _TraversalSortNode : IComparable<FlutterSDK.Semantics.Semantics._TraversalSortNode>
    {
        public _TraversalSortNode(FlutterSDK.Semantics.Semantics.SemanticsNode node = default(FlutterSDK.Semantics.Semantics.SemanticsNode), FlutterSDK.Semantics.Semantics.SemanticsSortKey sortKey = default(FlutterSDK.Semantics.Semantics.SemanticsSortKey), int position = default(int))
        : base()
        {
            this.Node = node;
            this.SortKey = sortKey;
            this.Position = position;
        }
        /// <Summary>
        /// The node whose position this sort node determines.
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.SemanticsNode Node { get; set; }
        /// <Summary>
        /// Determines the position of this node among its siblings.
        ///
        /// Sort keys take precedence over other attributes, such as
        /// [position].
        /// </Summary>
        public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey { get; set; }
        /// <Summary>
        /// Position within the list of siblings as determined by the default sort
        /// order.
        /// </Summary>
        public virtual int Position { get; set; }

        public new int CompareTo(FlutterSDK.Semantics.Semantics._TraversalSortNode other)
        {
            if (SortKey == null || other?.SortKey == null)
            {
                return Position - other.Position;
            }

            return SortKey.CompareTo(other.SortKey);
        }



    }


    /// <Summary>
    /// Owns [SemanticsNode] objects and notifies listeners of changes to the
    /// render tree semantics.
    ///
    /// To listen for semantic updates, call [PipelineOwner.ensureSemantics] to
    /// obtain a [SemanticsHandle]. This will create a [SemanticsOwner] if
    /// necessary.
    /// </Summary>
    public class SemanticsOwner : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        public SemanticsOwner()
        { }
        internal virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsNode> _DirtyNodes { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Semantics.Semantics.SemanticsNode> _Nodes { get; set; }
        internal virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsNode> _DetachedNodes { get; set; }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsNode RootSemanticsNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Dispose()
        {
            _DirtyNodes.Clear();
            _Nodes.Clear();
            _DetachedNodes.Clear();
            base.Dispose();
        }




        /// <Summary>
        /// Update the semantics using [Window.updateSemantics].
        /// </Summary>
        public virtual void SendSemanticsUpdate()
        {
            if (_DirtyNodes.IsEmpty()) return;
            HashSet<int> customSemanticsActionIds = new Dictionary<int> { };
            List<SemanticsNode> visitedNodes = new List<SemanticsNode>() { };
            while (_DirtyNodes.IsNotEmpty)
            {
                List<SemanticsNode> localDirtyNodes = _DirtyNodes.Where((SemanticsNode node) => =>!_DetachedNodes.Contains(node)).ToList();
                _DirtyNodes.Clear();
                _DetachedNodes.Clear();
                localDirtyNodes.Sort((SemanticsNode a, SemanticsNode b) => =>a.Depth - b.Depth);
                visitedNodes.AddAll(localDirtyNodes);
                foreach (SemanticsNode node in localDirtyNodes)
                {


                    if (node.IsPartOfNodeMerging)
                    {

                        if (node.Parent != null && node.Parent.IsPartOfNodeMerging) node.Parent._MarkDirty();
                    }

                }

            }

            visitedNodes.Sort((SemanticsNode a, SemanticsNode b) => =>a.Depth - b.Depth);
            Dart.UI.SemanticsUpdateBuilder builder = new Ui.SemanticsUpdateBuilder();
            foreach (SemanticsNode node in visitedNodes)
            {

                if (node._Dirty && node.Attached) node._AddToUpdate(builder, customSemanticsActionIds);
            }

            _DirtyNodes.Clear();
            foreach (int actionId in customSemanticsActionIds)
            {
                CustomSemanticsAction action = SemanticsDefaultClass.CustomSemanticsAction.GetAction(actionId);
                builder.UpdateCustomAction(id: actionId, label: action.Label, hint: action.Hint, overrideId: action.Action?.Index ?? -1);
            }

            BindingDefaultClass.SemanticsBinding.Instance.Window.UpdateSemantics(builder.Build());
            NotifyListeners();
        }




        private FlutterSDK.Semantics.Semantics._SemanticsActionHandler _GetSemanticsActionHandlerForId(int id, SemanticsAction action)
        {
            SemanticsNode result = _Nodes[id];
            if (result != null && result.IsPartOfNodeMerging && !result._CanPerformAction(action))
            {
                result._VisitDescendants((SemanticsNode node) =>
                {
                    if (node._CanPerformAction(action))
                    {
                        result = node;
                        return false;
                    }

                    return true;
                }
                );
            }

            if (result == null || !result._CanPerformAction(action)) return null;
            return result._Actions[action];
        }




        /// <Summary>
        /// Asks the [SemanticsNode] with the given id to perform the given action.
        ///
        /// If the [SemanticsNode] has not indicated that it can perform the action,
        /// this function does nothing.
        ///
        /// If the given `action` requires arguments they need to be passed in via
        /// the `args` parameter.
        /// </Summary>
        public virtual void PerformAction(int id, SemanticsAction action, object args = default(object))
        {

            _SemanticsActionHandler handler = _GetSemanticsActionHandlerForId(id, action);
            if (handler != null)
            {
                handler(args);
                return;
            }

            if (action == Dart.UiDefaultClass.SemanticsAction.ShowOnScreen && _Nodes[id]._ShowOnScreen != null) _Nodes[id]._ShowOnScreen();
        }




        private FlutterSDK.Semantics.Semantics._SemanticsActionHandler _GetSemanticsActionHandlerForPosition(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterBinding.UI.Offset position, SemanticsAction action)
        {
            if (node.Transform != null)
            {
                Matrix4 inverse = Matrix4.Identity();
                if (inverse.CopyInverse(node.Transform) == 0.0) return null;
                position = MatrixutilsDefaultClass.MatrixUtils.TransformPoint(inverse, position);
            }

            if (!node.Rect.Contains(position)) return null;
            if (node.MergeAllDescendantsIntoThisNode)
            {
                SemanticsNode result = default(SemanticsNode);
                node._VisitDescendants((SemanticsNode child) =>
                {
                    if (child._CanPerformAction(action))
                    {
                        result = child;
                        return false;
                    }

                    return true;
                }
                );
                return result?._Actions[action];
            }

            if (node.HasChildren)
            {
                foreach (SemanticsNode child in node._Children.Reversed)
                {
                    _SemanticsActionHandler handler = _GetSemanticsActionHandlerForPosition(child, position, action);
                    if (handler != null) return handler;
                }

            }

            return node._Actions[action];
        }




        /// <Summary>
        /// Asks the [SemanticsNode] at the given position to perform the given action.
        ///
        /// If the [SemanticsNode] has not indicated that it can perform the action,
        /// this function does nothing.
        ///
        /// If the given `action` requires arguments they need to be passed in via
        /// the `args` parameter.
        /// </Summary>
        public virtual void PerformActionAt(FlutterBinding.UI.Offset position, SemanticsAction action, object args = default(object))
        {

            SemanticsNode node = RootSemanticsNode;
            if (node == null) return;
            _SemanticsActionHandler handler = _GetSemanticsActionHandlerForPosition(node, position, action);
            if (handler != null) handler(args);
        }




    }


    /// <Summary>
    /// Base class for all sort keys for [SemanticsProperties.sortKey] accessibility
    /// traversal order sorting.
    ///
    /// Sort keys are sorted by [name], then by the comparison that the subclass
    /// implements. If [SemanticsProperties.sortKey] is specified, sort keys within
    /// the same semantic group must all be of the same type.
    ///
    /// Keys with no [name] are compared to other keys with no [name], and will
    /// be traversed before those with a [name].
    ///
    /// If no sort key is applied to a semantics node, then it will be ordered using
    /// a platform dependent default algorithm.
    ///
    /// See also:
    ///
    ///  * [OrdinalSortKey] for a sort key that sorts using an ordinal.
    /// </Summary>
    public class SemanticsSortKey : IComparable<FlutterSDK.Semantics.Semantics.SemanticsSortKey>, IDiagnosticable
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public SemanticsSortKey(string name = default(string))
        {
            this.Name = name;
        }
        /// <Summary>
        /// An optional name that will group this sort key with other sort keys of the
        /// same [name].
        ///
        /// Sort keys must have the same `runtimeType` when compared.
        ///
        /// Keys with no [name] are compared to other keys with no [name], and will
        /// be traversed before those with a [name].
        /// </Summary>
        public virtual string Name { get; set; }

        public new int CompareTo(FlutterSDK.Semantics.Semantics.SemanticsSortKey other)
        {

            if (Name == other.Name)
            {
                return DoCompare(other);
            }

            if (Name == null && other.Name != null)
            {
                return -1;
            }
            else if (Name != null && other.Name == null)
            {
                return 1;
            }

            return Name.CompareTo(other.Name);
        }




        /// <Summary>
        /// The implementation of [compareTo].
        ///
        /// The argument is guaranteed to be of the same type as this object and have
        /// the same [name].
        ///
        /// The method should return a negative number if this object comes earlier in
        /// the sort order than the argument; and a positive number if it comes later
        /// in the sort order. Returning zero causes the system to use default sort
        /// order.
        /// </Summary>
        public virtual int DoCompare(FlutterSDK.Semantics.Semantics.SemanticsSortKey other)
        {
            return default(int);
        }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new StringProperty("name", Name, defaultValue: null));
        }



    }


    /// <Summary>
    /// A [SemanticsSortKey] that sorts simply based on the `double` value it is
    /// given.
    ///
    /// The [OrdinalSortKey] compares itself with other [OrdinalSortKey]s
    /// to sort based on the order it is given.
    ///
    /// [OrdinalSortKey]s are sorted by the optional [name], then by their [order].
    /// If [SemanticsProperties.sortKey] is a [OrdinalSortKey], then all the other
    /// speficied sort keys in the same semantics group must also be
    /// [OrdinalSortKey]s.
    ///
    /// Keys with no [name] are compared to other keys with no [name], and will
    /// be traversed before those with a [name].
    ///
    /// The ordinal value [order] is typically a whole number, though it can be
    /// fractional, e.g. in order to fit between two other consecutive whole
    /// numbers. The value must be finite (it cannot be [double.nan],
    /// [double.infinity], or [double.negativeInfinity]).
    /// </Summary>
    public class OrdinalSortKey : FlutterSDK.Semantics.Semantics.SemanticsSortKey
    {
        /// <Summary>
        /// Creates a const semantics sort key that uses a [double] as its key value.
        ///
        /// The [order] must be a finite number, and must not be null.
        /// </Summary>
        public OrdinalSortKey(double order, string name = default(string))
        : base(name: name)
        {
            this.Order = order;
        }
        /// <Summary>
        /// Determines the placement of this key in a sequence of keys that defines
        /// the order in which this node is traversed by the platform's accessibility
        /// services.
        ///
        /// Lower values will be traversed first. Keys with the same [name] will be
        /// grouped together and sorted by name first, and then sorted by [order].
        /// </Summary>
        public virtual double Order { get; set; }

        public new int DoCompare(FlutterSDK.Semantics.Semantics.OrdinalSortKey other)
        {
            if (other.Order == null || Order == null || other.Order == Order) return 0;
            return Order.CompareTo(other.Order);
        }


        public new int DoCompare(FlutterSDK.Semantics.Semantics.SemanticsSortKey other)
        {
            if (other.Order == null || Order == null || other.Order == Order) return 0;
            return Order.CompareTo(other.Order);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DoubleProperty("order", Order, defaultValue: null));
        }



    }


    /// <Summary>
    /// Used by [debugDumpSemanticsTree] to specify the order in which child nodes
    /// are printed.
    /// </Summary>
    public enum DebugSemanticsDumpOrder
    {

        /// <Summary>
        /// Print nodes in inverse hit test order.
        ///
        /// In inverse hit test order, the last child of a [SemanticsNode] will be
        /// asked first if it wants to respond to a user's interaction, followed by
        /// the second last, etc. until a taker is found.
        /// </Summary>
        InverseHitTest,
        /// <Summary>
        /// Print nodes in semantic traversal order.
        ///
        /// This is the order in which a user would navigate the UI using the "next"
        /// and "previous" gestures.
        /// </Summary>
        TraversalOrder,
    }

}
