using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FlutterBinding.Engine
{
    public class TaskRunners
    {
        public static TaskRunners Instance { get; private set; }

        [Flags]
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public enum Type
        {
            Platform = 1 << 0,
            UI = 1 << 1,
            GPU = 1 << 2,
            IO = 1 << 3
        };

        public TaskRunners(string prefix, Type typeMask)
        {
            Label              = prefix;

            PlatformTaskRunner = new TaskRunner(prefix + ".platform");
            UITaskRunner = new TaskRunner(prefix + ".ui");

            GPUTaskRunner = typeMask.HasFlag(Type.GPU) ? new TaskRunner(prefix + ".gpu") : UITaskRunner;
            IOTaskRunner = typeMask.HasFlag(Type.IO) ? new TaskRunner(prefix + ".io") : PlatformTaskRunner;

            Instance = Instance ?? this;
        }

        public string Label { get; }

        public TaskRunner PlatformTaskRunner { get; }
        // ReSharper disable InconsistentNaming
        public TaskRunner UITaskRunner { get; }
        public TaskRunner IOTaskRunner { get; }
        public TaskRunner GPUTaskRunner { get; }
        // ReSharper restore InconsistentNaming

        public bool IsValid() => PlatformTaskRunner != null && GPUTaskRunner != null && UITaskRunner != null && IOTaskRunner != null;
    }

    public class TaskRunner : IDisposable
    {
        private readonly EventWaitHandle _wh = new AutoResetEvent(false);
        private readonly Thread _worker;
        private readonly object _locker = new object();
        private readonly Queue<TaskAction> _tasks = new Queue<TaskAction>();
        private readonly List<DelayedTask> _delayedTasks = new List<DelayedTask>();
        private int _order = 0;
        private bool _terminated = false;

        public TaskRunner(string name)
        {
            _worker = new Thread(Work) {Name = name};
            _worker.Start();
        }

        public virtual void PostTask(Action task)
        {
            EnqueueTask(task);
        }

        public Task PostTaskForTime(Action task, TimePoint targetTime)
        {
            var order = Interlocked.Increment(ref _order);
            var tcs = new TaskCompletionSource<bool>();
            var delayedTask = new DelayedTask(order, task, tcs, targetTime);
            lock (_locker)
            {
                _delayedTasks.Add(delayedTask);
                _wh.Set();
            }

            return tcs.Task;
        }

        public virtual void PostDelayedTask(Action task, TimeDelta delay)
        {
            PostTaskForTime(task, DateTime.Now + delay._timeSpan);
        }

        public bool RunsTasksOnCurrentThread => Thread.CurrentThread == _worker;

        public static Task RunNowOrPostTask(TaskRunner runner, Action task)
        {
            if (runner.RunsTasksOnCurrentThread)
            {
                task();
                return Task.FromResult(true);
            }

            return runner.EnqueueTask(task);
        }

        public Task RunNowOrPostTask(Action task)
        {
            if (RunsTasksOnCurrentThread)
            {
                task();
                return Task.FromResult(true);
            }

            return EnqueueTask(task);
        }

        private Task EnqueueTask(Action action)
        {
            if (_terminated)
                return Task.FromResult(false);

            var tcs = new TaskCompletionSource<bool>();
            lock (_locker)
            {
                _tasks.Enqueue(new TaskAction(action, tcs));
            }

            _wh.Set();
            return tcs.Task;
        }

        public void RunExpiredTasksNow()
        {
            _wh.Set();
        }

        public void Terminate()
        {
            _terminated = true;
            _wh.Set();
        }

        private void Work()
        {
            while (true)
            {
                if (_terminated)
                    return;

                Action action = null;
                TaskCompletionSource<bool> tcs = null;
                lock (_locker)
                {
                    if (_tasks.Count > 0)
                    {
                        var taskAction = _tasks.Dequeue();
                        action = taskAction.Action;
                        tcs    = taskAction.Tcs;
                    }
                    else if (_delayedTasks.Count > 0)
                    {
                        foreach (var delayedTask in _delayedTasks.OrderBy(dt => dt.TargetTime).ToList())
                        {
                            if (delayedTask.TargetTime <= TimePoint.Now())
                            {
                                action = delayedTask.Action;
                                tcs    = delayedTask.Tcs;
                                _delayedTasks.Remove(delayedTask);
                                break;
                            }
                        }
                    }
                }

                if (action != null)
                {
                    try
                    {
                        action();
                        tcs.SetResult(true);
                    }
                    catch (Exception e)
                    {
                        FLog.Error(e.ToString());
                        tcs.SetException(e);
                    }
                }
                else
                {
                    // Find next delayed task
                    DelayedTask next = null;
                    lock (_locker)
                    {
                        // TODO: Linq is not the quickest.  Try faster
                        next = _delayedTasks
                              .OrderBy(dt => dt.TargetTime)
                              .ThenBy(dt => dt.Order)
                              .FirstOrDefault();
                    }

                    if (next != null)
                    {
                        var timeSpan = next.TargetTime - TimePoint.Now();
                        _wh.WaitOne(timeSpan);
                    }
                    else
                    {
                        _wh.WaitOne(); // No more tasks - wait for a signal
                    }
                }
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            EnqueueTask(null); // Signal the consumer to exit.
            _worker.Join();    // Wait for the consumer's thread to finish.
            _wh.Close();       // Release any OS resources.
        }

        private class DelayedTask
        {
            public int Order { get; }
            public Action Action { get; }
            public TaskCompletionSource<bool> Tcs { get; }
            public TimePoint TargetTime { get; }

            public DelayedTask(
                int order,
                Action task,
                TaskCompletionSource<bool> tcs,
                TimePoint targetTime)
            {
                Order      = order;
                Action     = task;
                Tcs        = tcs;
                TargetTime = targetTime;
            }
        };

        private class TaskAction
        {
            public Action Action { get; }
            public TaskCompletionSource<bool> Tcs { get; }

            public TaskAction(Action action, TaskCompletionSource<bool> tcs)
            {
                Action = action;
                Tcs    = tcs;
            }
        }
    }
}
