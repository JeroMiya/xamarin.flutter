using System;
using FlutterBinding.Engine;

namespace FlutterBinding.Shell
{
    public abstract class VsyncWaiter
    {
        public delegate void Callback(TimePoint frameStartTime, TimePoint frameTargetTime);

        protected VsyncWaiter(TaskRunners taskRunners)
        {
            _task_runners = taskRunners;
        }

        public void AsyncWaitForVsync(Callback callback)
        {
            _callback = callback;
            AwaitVSync();
        }

        public void FireCallback(TimePoint frameStartTime, TimePoint frameTargetTime)
        {
            _task_runners.UITaskRunner.PostTask(() => { _callback?.Invoke(frameStartTime, frameTargetTime); });
        }

        protected readonly TaskRunners _task_runners;
        protected Callback _callback;

        protected abstract void AwaitVSync();

        public static TimePoint SnapToNextTick(
            TimePoint value,
            TimePoint tick_phase,
            TimeDelta tick_interval)
        {
            TimeDelta offset = (tick_phase - value) % tick_interval;
            if (offset != TimeSpan.Zero)
                offset = offset + tick_interval;
            return value + offset;
        }

        //FML_DISALLOW_COPY_AND_ASSIGN(VsyncWaiter);
    }

    public sealed class VsyncWaiterFallback : VsyncWaiter
    {
        private static readonly TimeDelta interval = TimeSpan.FromSeconds(1.0 / 60.0);

        public VsyncWaiterFallback(TaskRunners taskRunners) : base(taskRunners)
        {
            phase_ = TimePoint.Now();
        }

        private TimePoint phase_;
    
        // |shell::VsyncWaiter|
        protected override void AwaitVSync()
        {
            TimePoint now = TimePoint.Now();
            TimePoint next = SnapToNextTick(now, phase_, interval);

            _task_runners.UITaskRunner.PostDelayedTask(
                    () =>
                    {
                        var frame_time = TimePoint.Now();
                        FireCallback(frame_time, frame_time + interval);
                    }, next - now);
        }

        //FML_DISALLOW_COPY_AND_ASSIGN(VsyncWaiterFallback);
    };
}