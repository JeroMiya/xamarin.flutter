using System;
using System.Threading;
using FlutterBinding.Engine;

namespace FlutterBinding.Shell
{
    public abstract class VsyncWaiter
    {
        public delegate void Callback(TimePoint frame_start_time, TimePoint frame_target_time);

        protected VsyncWaiter(TaskRunners task_runners)
        {
            task_runners_ = task_runners;
        }

        public void AsyncWaitForVsync(Callback callback)
        {
            lock (callback_mutex_)
            {
                callback_ = callback;
            }
            AwaitVSync();
        }

        public void FireCallback(TimePoint frame_start_time, TimePoint frame_target_time)
        {
            Callback callback;

            lock (callback_mutex_)
            {
                callback = callback_;
            }

            if (callback == null)
                return;

            task_runners_.UITaskRunner.PostTask(() => { callback(frame_start_time, frame_target_time); });
        }

        protected TaskRunners task_runners_;
        protected Object callback_mutex_ = new object();
        protected Callback callback_;

        protected abstract void AwaitVSync();

        //FML_DISALLOW_COPY_AND_ASSIGN(VsyncWaiter);
    }
}