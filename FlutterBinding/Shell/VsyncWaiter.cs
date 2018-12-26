using System;
using FlutterBinding.Engine;

namespace FlutterBinding.Shell
{
    public abstract class VsyncWaiter
    {
        public delegate void Callback(TimePoint frameStartTime, TimePoint frameTargetTime);

        protected VsyncWaiter(TaskRunners taskRunners)
        {
            _taskRunners = taskRunners;
        }

        public void AsyncWaitForVsync(Callback callback)
        {
            _callback = callback;
            AwaitVSync();
        }

        public void FireCallback(TimePoint frameStartTime, TimePoint frameTargetTime)
        {
            _taskRunners.UITaskRunner.PostTask(() => { _callback?.Invoke(frameStartTime, frameTargetTime); });
        }

        protected readonly TaskRunners _taskRunners;
        protected Callback _callback;

        protected abstract void AwaitVSync();

        public static TimePoint SnapToNextTick(
            TimePoint value,
            TimePoint tickPhase,
            TimeDelta tickInterval)
        {
            TimeDelta offset = (tickPhase - value) % tickInterval;
            if (offset != TimeSpan.Zero)
                offset = offset + tickInterval;
            return value + offset;
        }

        //FML_DISALLOW_COPY_AND_ASSIGN(VsyncWaiter);
    }

    public sealed class VsyncWaiterFallback : VsyncWaiter
    {
        private static readonly TimeDelta interval = TimeSpan.FromSeconds(1.0 / 60.0);

        public VsyncWaiterFallback(TaskRunners taskRunners) : base(taskRunners)
        {
            _phase = TimePoint.Now();
        }

        private TimePoint _phase;

        // |shell::VsyncWaiter|
        protected override void AwaitVSync()
        {
            TimePoint now = TimePoint.Now();
            TimePoint next = SnapToNextTick(now, _phase, interval);

            _taskRunners.UITaskRunner.PostDelayedTask(
                () =>
                {
                    var frameTime = TimePoint.Now();
                    FireCallback(frameTime, frameTime + interval);
                },
                next - now);
        }

        //FML_DISALLOW_COPY_AND_ASSIGN(VsyncWaiterFallback);
    };
}
