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
namespace FlutterSDK.Animation.Listenerhelpers{
internal static class ListenerhelpersDefaultClass{
}

public interface IAnimationLazyListenerMixin{}

public class AnimationLazyListenerMixin{
internal virtual int _ListenerCounter{get;set;}
public virtual bool IsListening{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

public virtual void DidRegisterListener(){ throw new NotImplementedException(); }


public virtual void DidUnregisterListener(){ throw new NotImplementedException(); }


public virtual void DidStartListening(){ throw new NotImplementedException(); }


public virtual void DidStopListening(){ throw new NotImplementedException(); }

}
public static class AnimationLazyListenerMixinMixin {
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


public interface IAnimationEagerListenerMixin{}

public class AnimationEagerListenerMixin{

public virtual void DidRegisterListener(){ throw new NotImplementedException(); }


public virtual void DidUnregisterListener(){ throw new NotImplementedException(); }


public virtual void Dispose(){ throw new NotImplementedException(); }

}
public static class AnimationEagerListenerMixinMixin {
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


public interface IAnimationLocalListenersMixin{}

public class AnimationLocalListenersMixin{
internal virtual FlutterSDK.Foundation.Observerlist.ObserverList<object> _Listeners{get;set;}

public virtual void DidRegisterListener(){ throw new NotImplementedException(); }


public virtual void DidUnregisterListener(){ throw new NotImplementedException(); }


public virtual void AddListener(VoidCallback listener){ throw new NotImplementedException(); }


public virtual void RemoveListener(VoidCallback listener){ throw new NotImplementedException(); }


public virtual void NotifyListeners(){ throw new NotImplementedException(); }

}
public static class AnimationLocalListenersMixinMixin {
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
public static void AddListener(this IAnimationLocalListenersMixin instance,VoidCallback listener) => GetOrCreate(instance).AddListener(listener);
public static void RemoveListener(this IAnimationLocalListenersMixin instance,VoidCallback listener) => GetOrCreate(instance).RemoveListener(listener);
public static void NotifyListeners(this IAnimationLocalListenersMixin instance) => GetOrCreate(instance).NotifyListeners();
}


public interface IAnimationLocalStatusListenersMixin{}

public class AnimationLocalStatusListenersMixin{
internal virtual FlutterSDK.Foundation.Observerlist.ObserverList<object> _StatusListeners{get;set;}

public virtual void DidRegisterListener(){ throw new NotImplementedException(); }


public virtual void DidUnregisterListener(){ throw new NotImplementedException(); }


public virtual void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


public virtual void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


public virtual void NotifyStatusListeners(FlutterSDK.Animation.Animation.AnimationStatus status){ throw new NotImplementedException(); }

}
public static class AnimationLocalStatusListenersMixinMixin {
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
public static void AddStatusListener(this IAnimationLocalStatusListenersMixin instance,FlutterSDK.Animation.Animation.AnimationStatusListener listener) => GetOrCreate(instance).AddStatusListener(listener);
public static void RemoveStatusListener(this IAnimationLocalStatusListenersMixin instance,FlutterSDK.Animation.Animation.AnimationStatusListener listener) => GetOrCreate(instance).RemoveStatusListener(listener);
public static void NotifyStatusListeners(this IAnimationLocalStatusListenersMixin instance,FlutterSDK.Animation.Animation.AnimationStatus status) => GetOrCreate(instance).NotifyStatusListeners(status);
}

}
