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
namespace FlutterSDK.Animation.Listenerhelpers
{
    internal static class ListenerhelpersDefaultClass
    {
    }

    public interface IAnimationLazyListenerMixin { }

    public class AnimationLazyListenerMixin
    {
        internal virtual int _ListenerCounter { get; set; }
        public virtual bool IsListening { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Calls [didStartListening] every time a registration of a listener causes
        /// an empty list of listeners to become non-empty.
        ///
        /// See also:
        ///
        ///  * [didUnregisterListener], which may cause the listener list to
        ///    become empty again, and in turn cause this method to call
        ///    [didStartListening] again.
        /// </Summary>
        public virtual void DidRegisterListener()
        {

            if (_ListenerCounter == 0) DidStartListening();
            _ListenerCounter += 1;
        }




        /// <Summary>
        /// Calls [didStopListening] when an only remaining listener is unregistered,
        /// thus making the list empty.
        ///
        /// See also:
        ///
        ///  * [didRegisterListener], which causes the listener list to become non-empty.
        /// </Summary>
        public virtual void DidUnregisterListener()
        {

            _ListenerCounter -= 1;
            if (_ListenerCounter == 0) DidStopListening();
        }




        /// <Summary>
        /// Called when the number of listeners changes from zero to one.
        /// </Summary>
        public virtual void DidStartListening()
        {
        }


        /// <Summary>
        /// Called when the number of listeners changes from one to zero.
        /// </Summary>
        public virtual void DidStopListening()
        {
        }

    }
    public static class AnimationLazyListenerMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IAnimationLazyListenerMixin, AnimationLazyListenerMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IAnimationLazyListenerMixin, AnimationLazyListenerMixin>();
        static AnimationLazyListenerMixin GetOrCreate(IAnimationLazyListenerMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new AnimationLazyListenerMixin();
                _table.Add(instance, value);
            }
            return (AnimationLazyListenerMixin)value;
        }
        public static bool IsListeningProperty(this IAnimationLazyListenerMixin instance) => GetOrCreate(instance).IsListening;
        public static void DidRegisterListener(this IAnimationLazyListenerMixin instance) => GetOrCreate(instance).DidRegisterListener();
        public static void DidUnregisterListener(this IAnimationLazyListenerMixin instance) => GetOrCreate(instance).DidUnregisterListener();
        public static void DidStartListening(this IAnimationLazyListenerMixin instance) => GetOrCreate(instance).DidStartListening();
        public static void DidStopListening(this IAnimationLazyListenerMixin instance) => GetOrCreate(instance).DidStopListening();
    }


    public interface IAnimationEagerListenerMixin { }

    public class AnimationEagerListenerMixin
    {

        /// <Summary>
        /// This implementation ignores listener registrations.
        /// </Summary>
        public virtual void DidRegisterListener()
        {
        }




        /// <Summary>
        /// This implementation ignores listener registrations.
        /// </Summary>
        public virtual void DidUnregisterListener()
        {
        }




        /// <Summary>
        /// Release the resources used by this object. The object is no longer usable
        /// after this method is called.
        /// </Summary>
        public virtual void Dispose()
        {
        }



    }
    public static class AnimationEagerListenerMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IAnimationEagerListenerMixin, AnimationEagerListenerMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IAnimationEagerListenerMixin, AnimationEagerListenerMixin>();
        static AnimationEagerListenerMixin GetOrCreate(IAnimationEagerListenerMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new AnimationEagerListenerMixin();
                _table.Add(instance, value);
            }
            return (AnimationEagerListenerMixin)value;
        }
        public static void DidRegisterListener(this IAnimationEagerListenerMixin instance) => GetOrCreate(instance).DidRegisterListener();
        public static void DidUnregisterListener(this IAnimationEagerListenerMixin instance) => GetOrCreate(instance).DidUnregisterListener();
        public static void Dispose(this IAnimationEagerListenerMixin instance) => GetOrCreate(instance).Dispose();
    }


    public interface IAnimationLocalListenersMixin { }

    public class AnimationLocalListenersMixin
    {
        internal virtual FlutterSDK.Foundation.Observerlist.ObserverList<object> _Listeners { get; set; }

        /// <Summary>
        /// Called immediately before a listener is added via [addListener].
        ///
        /// At the time this method is called the registered listener is not yet
        /// notified by [notifyListeners].
        /// </Summary>
        public virtual void DidRegisterListener()
        {
        }


        /// <Summary>
        /// Called immediately after a listener is removed via [removeListener].
        ///
        /// At the time this method is called the removed listener is no longer
        /// notified by [notifyListeners].
        /// </Summary>
        public virtual void DidUnregisterListener()
        {
        }


        /// <Summary>
        /// Calls the listener every time the value of the animation changes.
        ///
        /// Listeners can be removed with [removeListener].
        /// </Summary>
        public virtual void AddListener(VoidCallback listener)
        {
            DidRegisterListener();
            _Listeners.Add(listener);
        }




        /// <Summary>
        /// Stop calling the listener every time the value of the animation changes.
        ///
        /// Listeners can be added with [addListener].
        /// </Summary>
        public virtual void RemoveListener(VoidCallback listener)
        {
            bool removed = _Listeners.Remove(listener);
            if (removed)
            {
                DidUnregisterListener();
            }

        }




        /// <Summary>
        /// Calls all the listeners.
        ///
        /// If listeners are added or removed during this function, the modifications
        /// will not change which listeners are called during this iteration.
        /// </Summary>
        public virtual void NotifyListeners()
        {
            List<VoidCallback> localListeners = List<VoidCallback>.From(_Listeners);
            foreach (VoidCallback listener in localListeners)
            {
                InformationCollector collector = default(InformationCollector);

                try
                {
                    if (_Listeners.Contains(listener)) listener();
                }
                catch (exception,stack){
                    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: stack, library: "animation library", context: new ErrorDescription($"'while notifying listeners for {GetType()}'"), informationCollector: collector));
                }

                }

            }



        }
        public static class AnimationLocalListenersMixinMixin
        {
            static System.Runtime.CompilerServices.ConditionalWeakTable<IAnimationLocalListenersMixin, AnimationLocalListenersMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IAnimationLocalListenersMixin, AnimationLocalListenersMixin>();
            static AnimationLocalListenersMixin GetOrCreate(IAnimationLocalListenersMixin instance)
            {
                if (!_table.TryGetValue(instance, out var value))
                {
                    value = new AnimationLocalListenersMixin();
                    _table.Add(instance, value);
                }
                return (AnimationLocalListenersMixin)value;
            }
            public static void DidRegisterListener(this IAnimationLocalListenersMixin instance) => GetOrCreate(instance).DidRegisterListener();
            public static void DidUnregisterListener(this IAnimationLocalListenersMixin instance) => GetOrCreate(instance).DidUnregisterListener();
            public static void AddListener(this IAnimationLocalListenersMixin instance, VoidCallback listener) => GetOrCreate(instance).AddListener(listener);
            public static void RemoveListener(this IAnimationLocalListenersMixin instance, VoidCallback listener) => GetOrCreate(instance).RemoveListener(listener);
            public static void NotifyListeners(this IAnimationLocalListenersMixin instance) => GetOrCreate(instance).NotifyListeners();
        }


        public interface IAnimationLocalStatusListenersMixin { }

        public class AnimationLocalStatusListenersMixin
        {
            internal virtual FlutterSDK.Foundation.Observerlist.ObserverList<object> _StatusListeners { get; set; }

            /// <Summary>
            /// Called immediately before a status listener is added via [addStatusListener].
            ///
            /// At the time this method is called the registered listener is not yet
            /// notified by [notifyStatusListeners].
            /// </Summary>
            public virtual void DidRegisterListener()
            {
            }


            /// <Summary>
            /// Called immediately after a status listener is removed via [removeStatusListener].
            ///
            /// At the time this method is called the removed listener is no longer
            /// notified by [notifyStatusListeners].
            /// </Summary>
            public virtual void DidUnregisterListener()
            {
            }


            /// <Summary>
            /// Calls listener every time the status of the animation changes.
            ///
            /// Listeners can be removed with [removeStatusListener].
            /// </Summary>
            public virtual void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
            {
                DidRegisterListener();
                _StatusListeners.Add(listener);
            }




            /// <Summary>
            /// Stops calling the listener every time the status of the animation changes.
            ///
            /// Listeners can be added with [addStatusListener].
            /// </Summary>
            public virtual void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
            {
                bool removed = _StatusListeners.Remove(listener);
                if (removed)
                {
                    DidUnregisterListener();
                }

            }




            /// <Summary>
            /// Calls all the status listeners.
            ///
            /// If listeners are added or removed during this function, the modifications
            /// will not change which listeners are called during this iteration.
            /// </Summary>
            public virtual void NotifyStatusListeners(FlutterSDK.Animation.Animation.AnimationStatus status)
            {
                List<AnimationStatusListener> localListeners = List<AnimationStatusListener>.From(_StatusListeners);
                foreach (AnimationStatusListener listener in localListeners)
                {
                    try
                    {
                        if (_StatusListeners.Contains(listener)) listener(status);
                    }
                    catch (exception,stack){
                        InformationCollector collector = default(InformationCollector);

                        AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: stack, library: "animation library", context: new ErrorDescription($"'while notifying status listeners for {GetType()}'"), informationCollector: collector));
                    }

                    }

                }



            }
            public static class AnimationLocalStatusListenersMixinMixin
            {
                static System.Runtime.CompilerServices.ConditionalWeakTable<IAnimationLocalStatusListenersMixin, AnimationLocalStatusListenersMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IAnimationLocalStatusListenersMixin, AnimationLocalStatusListenersMixin>();
                static AnimationLocalStatusListenersMixin GetOrCreate(IAnimationLocalStatusListenersMixin instance)
                {
                    if (!_table.TryGetValue(instance, out var value))
                    {
                        value = new AnimationLocalStatusListenersMixin();
                        _table.Add(instance, value);
                    }
                    return (AnimationLocalStatusListenersMixin)value;
                }
                public static void DidRegisterListener(this IAnimationLocalStatusListenersMixin instance) => GetOrCreate(instance).DidRegisterListener();
                public static void DidUnregisterListener(this IAnimationLocalStatusListenersMixin instance) => GetOrCreate(instance).DidUnregisterListener();
                public static void AddStatusListener(this IAnimationLocalStatusListenersMixin instance, FlutterSDK.Animation.Animation.AnimationStatusListener listener) => GetOrCreate(instance).AddStatusListener(listener);
                public static void RemoveStatusListener(this IAnimationLocalStatusListenersMixin instance, FlutterSDK.Animation.Animation.AnimationStatusListener listener) => GetOrCreate(instance).RemoveStatusListener(listener);
                public static void NotifyStatusListeners(this IAnimationLocalStatusListenersMixin instance, FlutterSDK.Animation.Animation.AnimationStatus status) => GetOrCreate(instance).NotifyStatusListeners(status);
            }

        }
