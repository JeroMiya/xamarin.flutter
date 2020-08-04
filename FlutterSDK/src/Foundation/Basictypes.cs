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
namespace FlutterSDK.Foundation.Basictypes
{
    /// <Summary>
    /// Signature for callbacks that report that an underlying value has changed.
    ///
    /// See also:
    ///
    ///  * [ValueSetter], for callbacks that report that a value has been set.
    /// </Summary>
    public delegate void ValueChanged<T>(T value);
    /// <Summary>
    /// Signature for callbacks that report that a value has been set.
    ///
    /// This is the same signature as [ValueChanged], but is used when the
    /// callback is called even if the underlying value has not changed.
    /// For example, service extensions use this callback because they
    /// call the callback whenever the extension is called with a
    /// value, regardless of whether the given value is new or not.
    ///
    /// See also:
    ///
    ///  * [ValueGetter], the getter equivalent of this signature.
    ///  * [AsyncValueSetter], an asynchronous version of this signature.
    /// </Summary>
    public delegate void ValueSetter<T>(T value);
    /// <Summary>
    /// Signature for callbacks that are to report a value on demand.
    ///
    /// See also:
    ///
    ///  * [ValueSetter], the setter equivalent of this signature.
    ///  * [AsyncValueGetter], an asynchronous version of this signature.
    /// </Summary>
    public delegate T ValueGetter<T>();
    /// <Summary>
    /// Signature for callbacks that filter an iterable.
    /// </Summary>
    public delegate Iterable<T> IterableFilter<T>(Iterable<T> input);
    /// <Summary>
    /// Signature of callbacks that have no arguments and return no data, but that
    /// return a [Future] to indicate when their work is complete.
    ///
    /// See also:
    ///
    ///  * [VoidCallback], a synchronous version of this signature.
    ///  * [AsyncValueGetter], a signature for asynchronous getters.
    ///  * [AsyncValueSetter], a signature for asynchronous setters.
    /// </Summary>
    public delegate Future<object> AsyncCallback();
    /// <Summary>
    /// Signature for callbacks that report that a value has been set and return a
    /// [Future] that completes when the value has been saved.
    ///
    /// See also:
    ///
    ///  * [ValueSetter], a synchronous version of this signature.
    ///  * [AsyncValueGetter], the getter equivalent of this signature.
    /// </Summary>
    public delegate Future<object> AsyncValueSetter<T>(T value);
    /// <Summary>
    /// Signature for callbacks that are to asynchronously report a value on demand.
    ///
    /// See also:
    ///
    ///  * [ValueGetter], a synchronous version of this signature.
    ///  * [AsyncValueSetter], the setter equivalent of this signature.
    /// </Summary>
    public delegate Future<T> AsyncValueGetter<T>();
    internal static class BasictypesDefaultClass
    {
    }

    /// <Summary>
    /// A lazy caching version of [Iterable].
    ///
    /// This iterable is efficient in the following ways:
    ///
    ///  * It will not walk the given iterator more than you ask for.
    ///
    ///  * If you use it twice (e.g. you check [isNotEmpty], then
    ///    use [single]), it will only walk the given iterator
    ///    once. This caching will even work efficiently if you are
    ///    running two side-by-side iterators on the same iterable.
    ///
    ///  * [toList] uses its EfficientLength variant to create its
    ///    list quickly.
    ///
    /// It is inefficient in the following ways:
    ///
    ///  * The first iteration through has caching overhead.
    ///
    ///  * It requires more memory than a non-caching iterator.
    ///
    ///  * The [length] and [toList] properties immediately pre-cache the
    ///    entire list. Using these fields therefore loses the laziness of
    ///    the iterable. However, it still gets cached.
    ///
    /// The caching behavior is propagated to the iterators that are
    /// created by [map], [where], [expand], [take], [takeWhile], [skip],
    /// and [skipWhile], and is used by the built-in methods that use an
    /// iterator like [isNotEmpty] and [single].
    ///
    /// Because a CachingIterable only walks the underlying data once, it
    /// cannot be used multiple times with the underlying data changing
    /// between each use. You must create a new iterable each time. This
    /// also applies to any iterables derived from this one, e.g. as
    /// returned by `where`.
    /// </Summary>
    public class CachingIterable<E> : IterableBase<E>
    {
        /// <Summary>
        /// Creates a CachingIterable using the given [Iterator] as the
        /// source of data. The iterator must be non-null and must not throw
        /// exceptions.
        ///
        /// Since the argument is an [Iterator], not an [Iterable], it is
        /// guaranteed that the underlying data set will only be walked
        /// once. If you have an [Iterable], you can pass its [iterator]
        /// field as the argument to this constructor.
        ///
        /// You can use a `sync*` function with this as follows:
        ///
        /// ```dart
        /// Iterable<int> range(int start, int end) sync* {
        ///   for (int index = start; index <= end; index += 1)
        ///     yield index;
        ///  }
        ///
        /// Iterable<int> i = CachingIterable<int>(range(1, 5).iterator);
        /// print(i.length); // walks the list
        /// print(i.length); // efficient
        /// ```
        /// </Summary>
        public CachingIterable(Iterator<E> _prefillIterator)
        {
            this._PrefillIterator = _prefillIterator;
        }
        internal virtual Iterator<E> _PrefillIterator { get; set; }
        internal virtual List<E> _Results { get; set; }
        public virtual Iterator<E> Iterator { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int Length { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new Iterable<T> Map<T>(Func<T, E> f)
        {
            return new CachingIterable<T>(base.Map(f).Iterator);
        }




        public new Iterable<E> Where(Func<bool, E> test)
        {
            return new CachingIterable<E>(base.Where(test).Iterator);
        }




        public new Iterable<T> Expand<T>(Func<Iterable<T>, E> f)
        {
            return new CachingIterable<T>(base.Expand(f).Iterator);
        }




        public new Iterable<E> Take(int count)
        {
            return new CachingIterable<E>(base.Take(count).Iterator);
        }




        public new Iterable<E> TakeWhile(Func<bool, E> test)
        {
            return new CachingIterable<E>(base.TakeWhile(test).Iterator);
        }




        public new Iterable<E> Skip(int count)
        {
            return new CachingIterable<E>(base.Skip(count).Iterator);
        }




        public new Iterable<E> SkipWhile(Func<bool, E> test)
        {
            return new CachingIterable<E>(base.SkipWhile(test).Iterator);
        }




        public new List<E> ToList(bool growable = true)
        {
            _PrecacheEntireList();
            return List<E>.From(_Results, growable: growable);
        }




        private void _PrecacheEntireList()
        {
            while (_FillNext())
            {
            }

        }




        private bool _FillNext()
        {
            if (!_PrefillIterator.MoveNext()) return false;
            _Results.Add(_PrefillIterator.Current);
            return true;
        }



    }


    public class _LazyListIterator<E> : IIterator<E>
    {
        public _LazyListIterator(FlutterSDK.Foundation.Basictypes.CachingIterable<E> _owner)
        : base()
        {
            this._Owner = _owner;
        }
        internal virtual FlutterSDK.Foundation.Basictypes.CachingIterable<E> _Owner { get; set; }
        internal virtual int _Index { get; set; }
        public virtual E Current { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool MoveNext()
        {
            if (_Index >= _Owner._Results.Count) return false;
            _Index += 1;
            if (_Index == _Owner._Results.Count) return _Owner._FillNext();
            return true;
        }



    }


    /// <Summary>
    /// A factory interface that also reports the type of the created objects.
    /// </Summary>
    public class Factory<T>
    {
        /// <Summary>
        /// Creates a new factory.
        ///
        /// The `constructor` parameter must not be null.
        /// </Summary>
        public Factory(FlutterSDK.Foundation.Basictypes.ValueGetter<T> constructor)
        : base()
        {
            this.Constructor = constructor;
        }
        /// <Summary>
        /// Creates a new object of type T.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueGetter<T> Constructor { get; set; }
        public virtual Type Type { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    }

}
