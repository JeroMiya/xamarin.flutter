using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FlutterBinding.Engine
{
    public class TaskRunners
    {
        public TaskRunners(
            string label,
            TaskRunner platform,
            TaskRunner gpu,
            TaskRunner ui,
            TaskRunner io)
        {
            Label = label;
            PlatformTaskRunner = platform;
            GPUTaskRunner = gpu;
            UITaskRunner = ui;
            IOTaskRunner = io;
        }

        public string Label { get; }

        public TaskRunner PlatformTaskRunner { get; }
        public TaskRunner UITaskRunner { get; }
        public TaskRunner IOTaskRunner { get; }
        public TaskRunner GPUTaskRunner { get; }

        public bool IsValid() => PlatformTaskRunner != null && GPUTaskRunner != null && UITaskRunner != null && IOTaskRunner != null;
    }

    public class TaskRunner : IDisposable
    {
        private readonly EventWaitHandle _wh = new AutoResetEvent(false);
        private readonly Thread _worker;
        private readonly object _locker = new object();
        private readonly Queue<Action> _tasks = new Queue<Action>();
        private readonly List<DelayedTask> _delayedTasks = new List<DelayedTask>();
        private int _order = 0;
        private bool _terminated = false;

        public TaskRunner()
        {
            _worker = new Thread(Work);
            _worker.Start();
        }

        public virtual void PostTask(Action task)
        {
            EnqueueTask(task);
        }

        public void PostTaskForTime(Action task, TimePoint targetTime)
        {
            var order = Interlocked.Increment(ref _order);
            var delayedTask = new DelayedTask(order, task, targetTime);
            lock (_locker)
            {
                _delayedTasks.Add(delayedTask);
                _wh.Set();
            }
        }

        public virtual void PostDelayedTask(Action task, TimeDelta delay)
        {
            PostTaskForTime(task, DateTime.Now + delay._timeSpan);
        }

        public bool RunsTasksOnCurrentThread => Thread.CurrentThread == _worker;

        public static void RunNowOrPostTask(TaskRunner runner, Action task)
        {
            if (runner.RunsTasksOnCurrentThread)
                task();
            else
                runner.EnqueueTask(task);
        }

        private void EnqueueTask(Action action)
        {
            if (_terminated)
                return;

            lock (_locker)
                _tasks.Enqueue(action);
            _wh.Set();
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

                Action task = null;
                lock (_locker)
                {
                    if (_tasks.Count > 0)
                    {
                        task = _tasks.Dequeue();
                    }
                    else if (_delayedTasks.Count > 0)
                    {
                        foreach (var delayedTask in _delayedTasks.OrderBy(dt => dt.TargetTime).ToList())
                        {
                            if (delayedTask.TargetTime <= TimePoint.Now())
                            {
                                task = delayedTask.Task;
                                _delayedTasks.Remove(delayedTask);
                                break;
                            }
                        }
                    }
                }

                if (task != null)
                {
                    try
                    {
                        task();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
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
            public Action Task { get; }
            public TimePoint TargetTime { get; }

            public DelayedTask(
                int order,
                Action task,
                TimePoint targetTime)
            {
                Order = order;
                Task = task;
                TargetTime = targetTime;
            }
        };
    }
}
