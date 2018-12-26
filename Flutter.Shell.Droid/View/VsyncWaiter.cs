using Android.Views;
using System;

namespace Flutter.Shell.Droid.View
{
    public class FrameCallback : Java.Lang.Object, Choreographer.IFrameCallback
    {
        private readonly Action<long> _onDoFrame;

        public FrameCallback(Action<long> onDoFrame)
        {
            _onDoFrame = onDoFrame;
        }

        /// <inheritdoc />
        public void DoFrame(long frameTimeNanos)
        {
            _onDoFrame(frameTimeNanos);
        }
    }

    public class VsyncWaiter
    {
        // This estimate will be updated by FlutterView when it is attached to a Display.
        public static long RefreshPeriodNanos = 1000000000 / 60;

        // This should also be updated by FlutterView when it is attached to a Display.
        // The initial value of 0.0 indicates unknown refresh rate.
        public static float RefreshRateFps = 0.0f;

        public static void AsyncWaitForVsync(long cookie)
        {
            Choreographer.Instance.PostFrameCallback(
                new FrameCallback(
                    (frameTimeNanos) => { nativeOnVsync(frameTimeNanos, frameTimeNanos + RefreshPeriodNanos, cookie); }));
        }

        // TODO: native
        private static void nativeOnVsync(long frameTimeNanos, long frameTargetTimeNanos, long cookie);
    }
}
