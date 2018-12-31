using System;
using Android.Views;
using FlutterBinding.Engine;

namespace Flutter.Shell.Droid
{
    public class VsyncWaiterAndroid : FlutterBinding.Shell.VsyncWaiter
    {
        public VsyncWaiterAndroid(TaskRunners taskRunners) : base(taskRunners)
        {
        }

        public class FrameCallback : Java.Lang.Object, Choreographer.IFrameCallback
        {
            private readonly Action<long> _onDoFrame;
            public FrameCallback(Action<long> onDoFrame) => _onDoFrame = onDoFrame;
            public void DoFrame(long frameTimeNanos) => _onDoFrame?.Invoke(frameTimeNanos);
        }

        protected override void AwaitVSync()
        {
            Choreographer.Instance.PostFrameCallback(
                new FrameCallback(
                    frameTimeNanos =>
                    {
                        var frameTime = TimePoint.FromEpochDelta(TimeDelta.FromMicroseconds(frameTimeNanos));
                        var targetTime = TimePoint.FromEpochDelta(TimeDelta.FromMicroseconds(frameTimeNanos + RefreshPeriodNanos));

                        FireCallback(frameTime, targetTime);
                    }));
        }
    }
}