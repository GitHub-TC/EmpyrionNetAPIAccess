﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public static class TaskWait
    {

        public static async Task<TResult> For<TResult>(int seconds, Task<TResult> task)
        {
            return await For(new TimeSpan(0, 0, 0, seconds), task);
        }

        public static async Task<TResult> For<TResult>(TimeSpan timeout, Task<TResult> task)
        {
            if(timeout.Ticks == 0) return await task;

            using (var timeoutCancellationTokenSource = new CancellationTokenSource())
            {

                var completedTask = await Task.WhenAny(task, Task.Delay(timeout, timeoutCancellationTokenSource.Token));
                if (completedTask == task)
                {
                    timeoutCancellationTokenSource.Cancel();
                    return await task;  // Very important in order to propagate exceptions
                }
                else
                {
                    throw new TimeoutException("The operation has timed out.");
                }
            }
        }

        public static async Task For(int seconds, Task task)
        {
            await For(new TimeSpan(0, 0, 0, seconds), task);
        }

        public static async Task For(TimeSpan timeout, Task task)
        {

            using (var timeoutCancellationTokenSource = new CancellationTokenSource())
            {

                var completedTask = await Task.WhenAny(task, Task.Delay(timeout, timeoutCancellationTokenSource.Token));
                if (completedTask == task)
                {
                    timeoutCancellationTokenSource.Cancel();
                    await task;  // Very important in order to propagate exceptions
                }
                else
                {
                    throw new TimeoutException("The operation has timed out.");
                }
            }
        }

        public static void Delay(int aSeconds, Action aAction)
        {
            Delay(new TimeSpan(0,0, aSeconds), aAction);
        }

        public static void Delay(TimeSpan aExecAfterTimeout, Action aAction)
        {
            new Thread(() => {
                try
                {
                Thread.Sleep((int)aExecAfterTimeout.TotalMilliseconds);
                aAction();
                }
                catch (Exception Error)
                {
                    Console.WriteLine(Error);
                }
            }).Start();
        }

    }
}
