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
namespace FlutterSDK.Animation.Animation{
public delegate void AnimationStatusListener(FlutterSDK.Animation.Animation.AnimationStatus status);
internal static class AnimationDefaultClass{
}

public interface IAnimation<T>{
void AddListener(VoidCallback listener);
void RemoveListener(VoidCallback listener);
void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener);
void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener);
Animation<U> Drive<U>(FlutterSDK.Animation.Tween.Animatable<U> child);
string ToString();
string ToStringDetails();
FlutterSDK.Animation.Animation.AnimationStatus Status{get;}
T Value{get;}
bool IsDismissed{get;}
bool IsCompleted{get;}
}


public class Animation<T> : FlutterSDK.Foundation.Changenotifier.Listenable,IValueListenable<T>
{
#region constructors
public Animation()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual T Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsDismissed{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsCompleted{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void AddListener(VoidCallback listener){ throw new NotImplementedException(); }


public new void RemoveListener(VoidCallback listener){ throw new NotImplementedException(); }


public virtual void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


public virtual void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


public virtual Animation<U> Drive<U>(FlutterSDK.Animation.Tween.Animatable<U> child){ throw new NotImplementedException(); }



public virtual string ToStringDetails(){ throw new NotImplementedException(); }

#endregion
}


public enum AnimationStatus{

Dismissed,
Forward,
Reverse,
Completed,
}

}
