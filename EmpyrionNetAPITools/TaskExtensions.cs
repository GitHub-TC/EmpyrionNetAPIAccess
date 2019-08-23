using System;
using System.Threading;

namespace EmpyrionNetAPITools.Extensions
{
    public static class TaskTools
    {
        public static Action<string> Log { get; set; } = Console.WriteLine;

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
