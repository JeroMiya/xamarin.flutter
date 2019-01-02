using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlutterBinding.Extensions
{
    public static class TaskExtensions
    {
        public static async Task<TResult> TimeoutAfter<TResult>(this Task<TResult> task, int timeout, CancellationTokenSource cancellationToken)
        {
            // create timeout task
            var timeoutTask = Task.Delay(TimeSpan.FromSeconds(timeout), cancellationToken.Token);

            // wait until either task completes
            var completedTask = await Task.WhenAny(task, timeoutTask);

            // if the timeout task finished first, cancel the other task and throw an exception
            if (completedTask == timeoutTask)
            {
                cancellationToken.Cancel();
                throw new TimeoutException("The operation has timed out.");
            }

            return await task; // very important in order to propagate exceptions
        }

        public static void FireAndForget(this Task task)
        {
            if (task is null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            task.ConfigureAwait(false);
            task.ContinueWith(
                t =>
                {
                    if (Debugger.IsAttached)
                        Debugger.Break();
                },
                TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}
