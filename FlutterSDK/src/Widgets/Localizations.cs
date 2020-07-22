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
namespace FlutterSDK.Widgets.Localizations
{
    internal static class LocalizationsDefaultClass
    {
        internal static Future<Dictionary<Type, object>> _LoadAll(Locale locale, Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> allDelegates)
        {
            Dictionary<Type, object> output = new Dictionary<Type, object> { };
            List<_Pending> pendingList = default(List<_Pending>);
            HashSet<Type> types = new Dictionary<Type> { };
            List<LocalizationsDelegate<object>> delegates = new List<LocalizationsDelegate<object>>() { };
            foreach (LocalizationsDelegate<object> delegate  in allDelegates){
                if (!types.Contains(delegate.Type) && delegate.IsSupported(locale))
                {
                    types.Add(delegate.Type);
                    delegates.Add(delegate);
                }

            }

            foreach (LocalizationsDelegate<object> delegate  in delegates){
                Future<object> inputValue = delegate.Load(locale);
                object completedValue = default(object);
                Future<object> futureValue = inputValue.Then((object value) =>
                {
                    return completedValue = value;
                }
                );
                if (completedValue != null)
                {
                    Type type = delegate.Type;

                    output[type] = completedValue;
                }
                else
                {
                    pendingList = (pendingList == null ? new List<_Pending>() { } : pendingList);
                    pendingList.Add(new _Pending(delegate, futureValue));
                }

            }

            if (pendingList == null) return new SynchronousFuture<Dictionary<Type, object>>(output);
            return Dart:asyncDefaultClass.Future.Wait(pendingList.Map((_Pending p) => =>p.FutureValue)).Then((List<object> values) =>
            {

                for (int i = 0; i < values.Count; i += 1)
                {
                    Type type = pendingList[i].Delegate.Type;

                    output[type] = values[i];
                }

                return output;
            }
            );
        }



    }

    /// <Summary>
    /// A factory for a set of localized resources of type `T`, to be loaded by a
    /// [Localizations] widget.
    ///
    /// Typical applications have one [Localizations] widget which is created by the
    /// [WidgetsApp] and configured with the app's `localizationsDelegates`
    /// parameter (a list of delegates). The delegate's [type] is used to identify
    /// the object created by an individual delegate's [load] method.
    /// </Summary>
    public interface ILocalizationsDelegate<T>
    {
        bool IsSupported(Locale locale);
        Future<T> Load(Locale locale);
        bool ShouldReload(FlutterSDK.Widgets.Localizations.LocalizationsDelegate<T> old);
        string ToString();
        Type Type { get; }
    }


    public interface IWidgetsLocalizations { }

    public class WidgetsLocalizations
    {
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// The `WidgetsLocalizations` from the closest [Localizations] instance
        /// that encloses the given context.
        ///
        /// This method is just a convenient shorthand for:
        /// `Localizations.of<WidgetsLocalizations>(context, WidgetsLocalizations)`.
        ///
        /// References to the localized resources defined by this class are typically
        /// written in terms of this method. For example:
        ///
        /// ```dart
        /// textDirection: WidgetsLocalizations.of(context).textDirection,
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Widgets.Localizations.WidgetsLocalizations Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return LocalizationsDefaultClass.Localizations.Of(context, LocalizationsDefaultClass.WidgetsLocalizations);
        }



    }
    public static class WidgetsLocalizationsMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IWidgetsLocalizations, WidgetsLocalizations> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IWidgetsLocalizations, WidgetsLocalizations>();
        static WidgetsLocalizations GetOrCreate(IWidgetsLocalizations instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new WidgetsLocalizations();
                _table.Add(instance, value);
            }
            return (WidgetsLocalizations)value;
        }
        public static TextDirection TextDirectionProperty(this IWidgetsLocalizations instance) => GetOrCreate(instance).TextDirection;
        public static FlutterSDK.Widgets.Localizations.WidgetsLocalizations Of(this IWidgetsLocalizations instance, FlutterSDK.Widgets.Framework.BuildContext context) => GetOrCreate(instance).Of(context);
    }


    public class _Pending
    {
        public _Pending(FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object> @delegate, Future<object> futureValue)
        {
            this.@delegate = @delegate;
            this.FutureValue = futureValue;
        }
        public virtual FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object> @delegate { get; set; }
        public virtual Future<object> FutureValue { get; set; }
    }


    /// <Summary>
    /// A factory for a set of localized resources of type `T`, to be loaded by a
    /// [Localizations] widget.
    ///
    /// Typical applications have one [Localizations] widget which is created by the
    /// [WidgetsApp] and configured with the app's `localizationsDelegates`
    /// parameter (a list of delegates). The delegate's [type] is used to identify
    /// the object created by an individual delegate's [load] method.
    /// </Summary>
    public class LocalizationsDelegate<T>
    {
        public LocalizationsDelegate()
        {

        }
        public virtual Type Type { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Whether resources for the given locale can be loaded by this delegate.
        ///
        /// Return true if the instance of `T` loaded by this delegate's [load]
        /// method supports the given `locale`'s language.
        /// </Summary>
        public virtual bool IsSupported(Locale locale)
        {
            return default(bool);
        }


        /// <Summary>
        /// Start loading the resources for `locale`. The returned future completes
        /// when the resources have finished loading.
        ///
        /// It's assumed that the this method will return an object that contains
        /// a collection of related resources (typically defined with one method per
        /// resource). The object will be retrieved with [Localizations.of].
        /// </Summary>
        public virtual Future<T> Load(Locale locale)
        {
            return default(Future<T>);
        }


        /// <Summary>
        /// Returns true if the resources for this delegate should be loaded
        /// again by calling the [load] method.
        ///
        /// This method is called whenever its [Localizations] widget is
        /// rebuilt. If it returns true then dependent widgets will be rebuilt
        /// after [load] has completed.
        /// </Summary>
        public virtual bool ShouldReload(FlutterSDK.Widgets.Localizations.LocalizationsDelegate<T> old)
        {
            return default(bool);
        }


    }


    public class _WidgetsLocalizationsDelegate : FlutterSDK.Widgets.Localizations.LocalizationsDelegate<FlutterSDK.Widgets.Localizations.WidgetsLocalizations>
    {
        public _WidgetsLocalizationsDelegate()
        {

        }

        public new bool IsSupported(Locale locale) => true;



        public new Future<FlutterSDK.Widgets.Localizations.WidgetsLocalizations> Load(Locale locale) => LocalizationsDefaultClass.DefaultWidgetsLocalizations.Load(locale);



        public new bool ShouldReload(FlutterSDK.Widgets.Localizations._WidgetsLocalizationsDelegate old) => false;



    }


    /// <Summary>
    /// US English localizations for the widgets library.
    ///
    /// See also:
    ///
    ///  * [GlobalWidgetsLocalizations], which provides widgets localizations for
    ///    many languages.
    ///  * [WidgetsApp.delegates], which automatically includes
    ///    [DefaultWidgetsLocalizations.delegate] by default.
    /// </Summary>
    public class DefaultWidgetsLocalizations : IWidgetsLocalizations
    {
        public DefaultWidgetsLocalizations()
        {

        }
        public virtual FlutterSDK.Widgets.Localizations.LocalizationsDelegate<FlutterSDK.Widgets.Localizations.WidgetsLocalizations> @delegate { get; set; }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates an object that provides US English resource values for the
        /// lowest levels of the widgets library.
        ///
        /// The [locale] parameter is ignored.
        ///
        /// This method is typically used to create a [LocalizationsDelegate].
        /// The [WidgetsApp] does so by default.
        /// </Summary>
        public virtual Future<FlutterSDK.Widgets.Localizations.WidgetsLocalizations> Load(Locale locale)
        {
            return new SynchronousFuture<WidgetsLocalizations>(new DefaultWidgetsLocalizations());
        }



    }


    public class _LocalizationsScope : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        public _LocalizationsScope(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Locale locale = default(Locale), FlutterSDK.Widgets.Localizations._LocalizationsState localizationsState = default(FlutterSDK.Widgets.Localizations._LocalizationsState), Dictionary<Type, object> typeToResources = default(Dictionary<Type, object>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Locale = locale;
            this.LocalizationsState = localizationsState;
            this.TypeToResources = typeToResources;
        }
        public virtual Locale Locale { get; set; }
        public virtual FlutterSDK.Widgets.Localizations._LocalizationsState LocalizationsState { get; set; }
        public virtual Dictionary<Type, object> TypeToResources { get; set; }

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Localizations._LocalizationsScope old)
        {
            return TypeToResources != old.TypeToResources;
        }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {
            return TypeToResources != old.TypeToResources;
        }



    }


    /// <Summary>
    /// Defines the [Locale] for its `child` and the localized resources that the
    /// child depends on.
    ///
    /// Localized resources are loaded by the list of [LocalizationsDelegate]
    /// `delegates`. Each delegate is essentially a factory for a collection
    /// of localized resources. There are multiple delegates because there are
    /// multiple sources for localizations within an app.
    ///
    /// Delegates are typically simple subclasses of [LocalizationsDelegate] that
    /// override [LocalizationsDelegate.load]. For example a delegate for the
    /// `MyLocalizations` class defined below would be:
    ///
    /// ```dart
    /// class _MyDelegate extends LocalizationsDelegate<MyLocalizations> {
    ///   @override
    ///   Future<MyLocalizations> load(Locale locale) => MyLocalizations.load(locale);
    ///
    ///   @override
    ///   bool shouldReload(MyLocalizationsDelegate old) => false;
    /// }
    /// ```
    ///
    /// Each delegate can be viewed as a factory for objects that encapsulate a
    /// a set of localized resources. These objects are retrieved with
    /// by runtime type with [Localizations.of].
    ///
    /// The [WidgetsApp] class creates a `Localizations` widget so most apps
    /// will not need to create one. The widget app's `Localizations` delegates can
    /// be initialized with [WidgetsApp.localizationsDelegates]. The [MaterialApp]
    /// class also provides a `localizationsDelegates` parameter that's just
    /// passed along to the [WidgetsApp].
    ///
    /// Apps should retrieve collections of localized resources with
    /// `Localizations.of<MyLocalizations>(context, MyLocalizations)`,
    /// where MyLocalizations is an app specific class defines one function per
    /// resource. This is conventionally done by a static `.of` method on the
    /// MyLocalizations class.
    ///
    /// For example, using the `MyLocalizations` class defined below, one would
    /// lookup a localized title string like this:
    /// ```dart
    /// MyLocalizations.of(context).title()
    /// ```
    /// If `Localizations` were to be rebuilt with a new `locale` then
    /// the widget subtree that corresponds to [BuildContext] `context` would
    /// be rebuilt after the corresponding resources had been loaded.
    ///
    /// This class is effectively an [InheritedWidget]. If it's rebuilt with
    /// a new `locale` or a different list of delegates or any of its
    /// delegates' [LocalizationsDelegate.shouldReload()] methods returns true,
    /// then widgets that have created a dependency by calling
    /// `Localizations.of(context)` will be rebuilt after the resources
    /// for the new locale have been loaded.
    ///
    /// {@tool snippet}
    ///
    /// This following class is defined in terms of the
    /// [Dart `intl` package](https://github.com/dart-lang/intl). Using the `intl`
    /// package isn't required.
    ///
    /// ```dart
    /// class MyLocalizations {
    ///   MyLocalizations(this.locale);
    ///
    ///   final Locale locale;
    ///
    ///   static Future<MyLocalizations> load(Locale locale) {
    ///     return initializeMessages(locale.toString())
    ///       .then((void _) {
    ///         return MyLocalizations(locale);
    ///       });
    ///   }
    ///
    ///   static MyLocalizations of(BuildContext context) {
    ///     return Localizations.of<MyLocalizations>(context, MyLocalizations);
    ///   }
    ///
    ///   String title() => Intl.message('<title>', name: 'title', locale: locale.toString());
    ///   // ... more Intl.message() methods like title()
    /// }
    /// ```
    /// {@end-tool}
    /// A class based on the `intl` package imports a generated message catalog that provides
    /// the `initializeMessages()` function and the per-locale backing store for `Intl.message()`.
    /// The message catalog is produced by an `intl` tool that analyzes the source code for
    /// classes that contain `Intl.message()` calls. In this case that would just be the
    /// `MyLocalizations` class.
    ///
    /// One could choose another approach for loading localized resources and looking them up while
    /// still conforming to the structure of this example.
    /// </Summary>
    public class Localizations : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public Localizations(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Locale locale = default(Locale), List<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> delegates = default(List<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Locale = locale;
            this.Delegates = delegates;
            this.Child = child;
        }
        public static Localizations Override(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), Locale locale = default(Locale), List<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> delegates = default(List<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Localizations();
            List<LocalizationsDelegate<object>> mergedDelegates = LocalizationsDefaultClass.Localizations._DelegatesOf(context);
            if (delegates != null) mergedDelegates.InsertAll(0, delegates);
            return new Localizations(key: key, locale: locale ?? LocalizationsDefaultClass.Localizations.LocaleOf(context), delegates: mergedDelegates, child: child);
        }


        public virtual Locale Locale { get; set; }
        public virtual List<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> Delegates { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        /// <Summary>
        /// The locale of the Localizations widget for the widget tree that
        /// corresponds to [BuildContext] `context`.
        ///
        /// If no [Localizations] widget is in scope then the [Localizations.localeOf]
        /// method will throw an exception, unless the `nullOk` argument is set to
        /// true, in which case it returns null.
        /// </Summary>
        public virtual Locale LocaleOf(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {


            _LocalizationsScope scope = context.DependOnInheritedWidgetOfExactType();
            if (nullOk && scope == null) return null;

            return scope.LocalizationsState.Locale;
        }




        private List<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> _DelegatesOf(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            _LocalizationsScope scope = context.DependOnInheritedWidgetOfExactType();

            return List<LocalizationsDelegate<object>>.From(scope.LocalizationsState.Widget.Delegates);
        }




        /// <Summary>
        /// Returns the localized resources object of the given `type` for the widget
        /// tree that corresponds to the given `context`.
        ///
        /// Returns null if no resources object of the given `type` exists within
        /// the given `context`.
        ///
        /// This method is typically used by a static factory method on the `type`
        /// class. For example Flutter's MaterialLocalizations class looks up Material
        /// resources with a method defined like this:
        ///
        /// ```dart
        /// static MaterialLocalizations of(BuildContext context) {
        ///    return Localizations.of<MaterialLocalizations>(context, MaterialLocalizations);
        /// }
        /// ```
        /// </Summary>
        public virtual T Of<T>(FlutterSDK.Widgets.Framework.BuildContext context, Type type)
        {


            _LocalizationsScope scope = context.DependOnInheritedWidgetOfExactType();
            return scope?.LocalizationsState?.ResourcesFor(type);
        }




        public new FlutterSDK.Widgets.Localizations._LocalizationsState CreateState() => new _LocalizationsState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Locale>("locale", Locale));
            properties.Add(new IterableProperty<LocalizationsDelegate<object>>("delegates", Delegates));
        }



    }


    public class _LocalizationsState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Localizations.Localizations>
    {
        public _LocalizationsState()
        { }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _LocalizedResourcesScopeKey { get; set; }
        internal virtual Dictionary<Type, object> _TypeToResources { get; set; }
        internal virtual Locale _Locale { get; set; }
        public virtual Locale Locale { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual TextDirection _TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            Load(Widget.Locale);
        }




        private bool _AnyDelegatesShouldReload(FlutterSDK.Widgets.Localizations.Localizations old)
        {
            if (Widget.Delegates.Count != old.Delegates.Count) return true;
            List<LocalizationsDelegate<object>> delegates = Widget.Delegates.ToList();
            List<LocalizationsDelegate<object>> oldDelegates = old.Delegates.ToList();
            for (int i = 0; i < delegates.Count; i += 1)
            {
                LocalizationsDelegate<object>   delegate= delegates[i];
                LocalizationsDelegate<object> oldDelegate = oldDelegates[i];
                if (delegate.GetType() != oldDelegate.GetType() || delegate.ShouldReload(oldDelegate)) return true;
            }

            return false;
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Localizations.Localizations old)
        {
            base.DidUpdateWidget(old);
            if (Widget.Locale != old.Locale || (Widget.Delegates == null && old.Delegates != null) || (Widget.Delegates != null && old.Delegates == null) || (Widget.Delegates != null && _AnyDelegatesShouldReload(old))) Load(Widget.Locale);
        }




        public virtual void Load(Locale locale)
        {
            Iterable<LocalizationsDelegate<object>> delegates = Widget.Delegates;
            if (delegates == null || delegates.IsEmpty())
            {
                _Locale = locale;
                return;
            }

            Dictionary<Type, object> typeToResources = default(Dictionary<Type, object>);
            Future<Dictionary<Type, object>> typeToResourcesFuture = LocalizationsDefaultClass._LoadAll(locale, delegates).Then((Dictionary<Type, object> value) =>
            {
                return typeToResources = value;
            }
            );
            if (typeToResources != null)
            {
                _TypeToResources = typeToResources;
                _Locale = locale;
            }
            else
            {
                BindingDefaultClass.RendererBinding.Instance.DeferFirstFrame();
                typeToResourcesFuture.Then((Dictionary<Type, object> value) =>
                {
                    if (Mounted)
                    {
                        SetState(() =>
                        {
                            _TypeToResources = value;
                            _Locale = locale;
                        }
                        );
                    }

                    BindingDefaultClass.RendererBinding.Instance.AllowFirstFrame();
                }
                );
            }

        }




        public virtual T ResourcesFor<T>(Type type)
        {

            T resources = _TypeToResources[type] as T;
            return resources;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (_Locale == null) return new Container();
            return new Semantics(textDirection: _TextDirection, child: new _LocalizationsScope(key: _LocalizedResourcesScopeKey, locale: _Locale, localizationsState: this, typeToResources: _TypeToResources, child: new Directionality(textDirection: _TextDirection, child: Widget.Child)));
        }



    }

}
