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
namespace FlutterSDK.Gestures.Arena
{
    internal static class ArenaDefaultClass
    {
    }

    /// <Summary>
    /// An interface to pass information to an arena.
    ///
    /// A given [GestureArenaMember] can have multiple entries in multiple arenas
    /// with different pointer ids.
    /// </Summary>
    public interface IGestureArenaEntry
    {
        void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition);
    }


    public interface IGestureArenaMember { }

    public class GestureArenaMember
    {

        /// <Summary>
        /// Called when this member wins the arena for the given pointer id.
        /// </Summary>
        public virtual void AcceptGesture(int pointer)
        {
        }


        /// <Summary>
        /// Called when this member loses the arena for the given pointer id.
        /// </Summary>
        public virtual void RejectGesture(int pointer)
        {
        }

    }
    public static class GestureArenaMemberMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IGestureArenaMember, GestureArenaMember> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IGestureArenaMember, GestureArenaMember>();
        static GestureArenaMember GetOrCreate(IGestureArenaMember instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new GestureArenaMember();
                _table.Add(instance, value);
            }
            return (GestureArenaMember)value;
        }
        public static void AcceptGesture(this IGestureArenaMember instance, int pointer) => GetOrCreate(instance).AcceptGesture(pointer);
        public static void RejectGesture(this IGestureArenaMember instance, int pointer) => GetOrCreate(instance).RejectGesture(pointer);
    }


    public interface I_GestureArena { }

    public class _GestureArena
    {
        public virtual List<FlutterSDK.Gestures.Arena.GestureArenaMember> Members { get; set; }
        public virtual bool IsOpen { get; set; }
        public virtual bool IsHeld { get; set; }
        public virtual bool HasPendingSweep { get; set; }
        /// <Summary>
        /// If a member attempts to win while the arena is still open, it becomes the
        /// "eager winner". We look for an eager winner when closing the arena to new
        /// participants, and if there is one, we resolve the arena in its favor at
        /// that time.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Arena.GestureArenaMember EagerWinner { get; set; }

        public virtual void Add(FlutterSDK.Gestures.Arena.GestureArenaMember member)
        {

            Members.Add(member);
        }




    }
    public static class _GestureArenaMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<I_GestureArena, _GestureArena> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<I_GestureArena, _GestureArena>();
        static _GestureArena GetOrCreate(I_GestureArena instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new _GestureArena();
                _table.Add(instance, value);
            }
            return (_GestureArena)value;
        }
        public static List<FlutterSDK.Gestures.Arena.GestureArenaMember> MembersProperty(this I_GestureArena instance) => GetOrCreate(instance).Members;
        public static bool IsOpenProperty(this I_GestureArena instance) => GetOrCreate(instance).IsOpen;
        public static bool IsHeldProperty(this I_GestureArena instance) => GetOrCreate(instance).IsHeld;
        public static bool HasPendingSweepProperty(this I_GestureArena instance) => GetOrCreate(instance).HasPendingSweep;
        public static FlutterSDK.Gestures.Arena.GestureArenaMember EagerWinnerProperty(this I_GestureArena instance) => GetOrCreate(instance).EagerWinner;
        public static void Add(this I_GestureArena instance, FlutterSDK.Gestures.Arena.GestureArenaMember member) => GetOrCreate(instance).Add(member);
        public static string ToString(this I_GestureArena instance) => GetOrCreate(instance).ToString();
    }


    public interface IGestureArenaManager { }

    public class GestureArenaManager
    {
        internal virtual Dictionary<int, FlutterSDK.Gestures.Arena._GestureArena> _Arenas { get; set; }

        /// <Summary>
        /// Adds a new member (e.g., gesture recognizer) to the arena.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Arena.GestureArenaEntry Add(int pointer, FlutterSDK.Gestures.Arena.GestureArenaMember member)
        {
            _GestureArena state = _Arenas.PutIfAbsent(pointer, () =>
            {

                return new _GestureArena();
            }
            );
            state.Add(member);

            return GestureArenaEntry._(this, pointer, member);
        }




        /// <Summary>
        /// Prevents new members from entering the arena.
        ///
        /// Called after the framework has finished dispatching the pointer down event.
        /// </Summary>
        public virtual void Close(int pointer)
        {
            _GestureArena state = _Arenas[pointer];
            if (state == null) return;
            state.IsOpen = false;

            _TryToResolveArena(pointer, state);
        }




        /// <Summary>
        /// Forces resolution of the arena, giving the win to the first member.
        ///
        /// Sweep is typically after all the other processing for a [PointerUpEvent]
        /// have taken place. It ensures that multiple passive gestures do not cause a
        /// stalemate that prevents the user from interacting with the app.
        ///
        /// Recognizers that wish to delay resolving an arena past [PointerUpEvent]
        /// should call [hold] to delay sweep until [release] is called.
        ///
        /// See also:
        ///
        ///  * [hold]
        ///  * [release]
        /// </Summary>
        public virtual void Sweep(int pointer)
        {
            _GestureArena state = _Arenas[pointer];
            if (state == null) return;

            if (state.IsHeld)
            {
                state.HasPendingSweep = true;

                return;
            }


            _Arenas.Remove(pointer);
            if (state.Members.IsNotEmpty)
            {

                state.Members.First.AcceptGesture(pointer);
                for (int i = 1; i < state.Members.Count; i++) state.Members[i].RejectGesture(pointer);
            }

        }




        /// <Summary>
        /// Prevents the arena from being swept.
        ///
        /// Typically, a winner is chosen in an arena after all the other
        /// [PointerUpEvent] processing by [sweep]. If a recognizer wishes to delay
        /// resolving an arena past [PointerUpEvent], the recognizer can [hold] the
        /// arena open using this function. To release such a hold and let the arena
        /// resolve, call [release].
        ///
        /// See also:
        ///
        ///  * [sweep]
        ///  * [release]
        /// </Summary>
        public virtual void Hold(int pointer)
        {
            _GestureArena state = _Arenas[pointer];
            if (state == null) return;
            state.IsHeld = true;

        }




        /// <Summary>
        /// Releases a hold, allowing the arena to be swept.
        ///
        /// If a sweep was attempted on a held arena, the sweep will be done
        /// on release.
        ///
        /// See also:
        ///
        ///  * [sweep]
        ///  * [hold]
        /// </Summary>
        public virtual void Release(int pointer)
        {
            _GestureArena state = _Arenas[pointer];
            if (state == null) return;
            state.IsHeld = false;

            if (state.HasPendingSweep) Sweep(pointer);
        }




        /// <Summary>
        /// Reject or accept a gesture recognizer.
        ///
        /// This is called by calling [GestureArenaEntry.resolve] on the object returned from [add].
        /// </Summary>
        private void _Resolve(int pointer, FlutterSDK.Gestures.Arena.GestureArenaMember member, FlutterSDK.Gestures.Arena.GestureDisposition disposition)
        {
            _GestureArena state = _Arenas[pointer];
            if (state == null) return;


            if (disposition == GestureDisposition.Rejected)
            {
                state.Members.Remove(member);
                member.RejectGesture(pointer);
                if (!state.IsOpen) _TryToResolveArena(pointer, state);
            }
            else
            {

                if (state.IsOpen)
                {
                    state.EagerWinner = (state.EagerWinner == null ? member : state.EagerWinner);
                }
                else
                {

                    _ResolveInFavorOf(pointer, state, member);
                }

            }

        }




        private void _TryToResolveArena(int pointer, FlutterSDK.Gestures.Arena._GestureArena state)
        {


            if (state.Members.Count == 1)
            {
                Dart.AsyncDefaultClass.ScheduleMicrotask(() => =>_ResolveByDefault(pointer, state));
            }
            else if (state.Members.IsEmpty())
            {
                _Arenas.Remove(pointer);

            }
            else if (state.EagerWinner != null)
            {

                _ResolveInFavorOf(pointer, state, state.EagerWinner);
            }

        }




        private void _ResolveByDefault(int pointer, FlutterSDK.Gestures.Arena._GestureArena state)
        {
            if (!_Arenas.ContainsKey(pointer)) return;


            List<GestureArenaMember> members = state.Members;

            _Arenas.Remove(pointer);

            state.Members.First.AcceptGesture(pointer);
        }




        private void _ResolveInFavorOf(int pointer, FlutterSDK.Gestures.Arena._GestureArena state, FlutterSDK.Gestures.Arena.GestureArenaMember member)
        {




            _Arenas.Remove(pointer);
            foreach (GestureArenaMember rejectedMember in state.Members)
            {
                if (rejectedMember != member) rejectedMember.RejectGesture(pointer);
            }

            member.AcceptGesture(pointer);
        }




        private bool _DebugLogDiagnostic(int pointer, string message, FlutterSDK.Gestures.Arena._GestureArena state = default(FlutterSDK.Gestures.Arena._GestureArena))
        {

            return true;
        }



    }
    public static class GestureArenaManagerMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IGestureArenaManager, GestureArenaManager> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IGestureArenaManager, GestureArenaManager>();
        static GestureArenaManager GetOrCreate(IGestureArenaManager instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new GestureArenaManager();
                _table.Add(instance, value);
            }
            return (GestureArenaManager)value;
        }
        public static FlutterSDK.Gestures.Arena.GestureArenaEntry Add(this IGestureArenaManager instance, int pointer, FlutterSDK.Gestures.Arena.GestureArenaMember member) => GetOrCreate(instance).Add(pointer, member);
        public static void Close(this IGestureArenaManager instance, int pointer) => GetOrCreate(instance).Close(pointer);
        public static void Sweep(this IGestureArenaManager instance, int pointer) => GetOrCreate(instance).Sweep(pointer);
        public static void Hold(this IGestureArenaManager instance, int pointer) => GetOrCreate(instance).Hold(pointer);
        public static void Release(this IGestureArenaManager instance, int pointer) => GetOrCreate(instance).Release(pointer);
    }


    /// <Summary>
    /// An interface to pass information to an arena.
    ///
    /// A given [GestureArenaMember] can have multiple entries in multiple arenas
    /// with different pointer ids.
    /// </Summary>
    public class GestureArenaEntry
    {
        internal GestureArenaEntry(FlutterSDK.Gestures.Arena.GestureArenaManager _arena, int _pointer, FlutterSDK.Gestures.Arena.GestureArenaMember _member)
        {
            this._Arena = _arena;
            this._Pointer = _pointer;
            this._Member = _member;
        }
        internal virtual FlutterSDK.Gestures.Arena.GestureArenaManager _Arena { get; set; }
        internal virtual int _Pointer { get; set; }
        internal virtual FlutterSDK.Gestures.Arena.GestureArenaMember _Member { get; set; }

        /// <Summary>
        /// Call this member to claim victory (with accepted) or admit defeat (with rejected).
        ///
        /// It's fine to attempt to resolve a gesture recognizer for an arena that is
        /// already resolved.
        /// </Summary>
        public virtual void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition)
        {
            _Arena._Resolve(_Pointer, _Member, disposition);
        }



    }


    /// <Summary>
    /// Whether the gesture was accepted or rejected.
    /// </Summary>
    public enum GestureDisposition
    {

        /// <Summary>
        /// This gesture was accepted as the interpretation of the user's input.
        /// </Summary>
        Accepted,
        /// <Summary>
        /// This gesture was rejected as the interpretation of the user's input.
        /// </Summary>
        Rejected,
    }

}
