using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmpyrionNetAPITools.Extensions
{
    public static class TaskTools
    {
        public static Action<string> Log { get; set; } = Console.WriteLine;

        public static async Task<TResult> For<TResult>(TimeSpan timeout, Task<TResult> task)
        {
            using (var timeoutCancellationTokenSource = new CancellationTokenSource())
            {
                try
                {
                    var completedTask = await Task.WhenAny(task, Task.Delay(timeout.Ticks == 0 ? new TimeSpan(0, 0, 1) : timeout, timeoutCancellationTokenSource.Token));
                    if (completedTask == task)
                    {
                        timeoutCancellationTokenSource.Cancel();
                        return await task;  // Very important in order to propagate exceptions
                    }
                    else
                    {
                        if (timeout.Ticks == 0) return await Task.FromResult(default(TResult));
                        throw new TimeoutException("The operation has timed out.");
                    }
                }
                catch (TimeoutException)
                {
                    if (timeout.Ticks > 0) throw;
                    return await Task.FromResult(default(TResult));
                }
            }
        }

        public static ManualResetEvent Intervall(int aMillisecondsIntervall, Action aAction)
        {
            return Intervall(aMillisecondsIntervall, aAction, null);
        }

        public static ManualResetEvent Intervall(int aMillisecondsIntervall, Action aAction, string name)
        {
            var localExit = new ManualResetEvent(false);
            try
            {
                new Thread(() =>
                {
                    bool isLocalExit = false;
                    while (!isLocalExit)
                    {
                        try
                        {
                            aAction();
                        }
                        catch (Exception Error)
                        {
                            Log(Error.ToString());
                        }
                        isLocalExit = localExit.WaitOne(aMillisecondsIntervall);
                    }
                })
                {
                    IsBackground = true,
                    Name = name
                }.Start();
            }
            catch (Exception ThreadError)
            {
                Log(ThreadError.ToString());
            }
            return localExit;
        }

        public static void Delay(int aSeconds, Action aAction)
        {
            Delay(new TimeSpan(0,0, aSeconds), aAction);
        }

        public static ManualResetEvent Delay(TimeSpan aExecAfterTimeout, Action aAction)
        {
            return Delay(aExecAfterTimeout, aAction, null);
        }

        public static ManualResetEvent Delay(TimeSpan aExecAfterTimeout, Action aAction, string name)
        {
            var localExit = new ManualResetEvent(false);
            try
            {
                new Thread(() =>
                {
                    try
                    {
                        localExit.WaitOne(aExecAfterTimeout);
                        aAction();
                    }
                    catch (Exception Error)
                    {
                        Log(Error.ToString());
                    }
                })
                {
                    IsBackground = true,
                    Name = name
                }.Start();
            }
            catch (Exception ThreadError)
            {
                Log(ThreadError.ToString());
            }
            return localExit;
        }

    }
}
