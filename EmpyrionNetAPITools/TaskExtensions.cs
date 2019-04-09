using System;
using System.Threading;

namespace EmpyrionNetAPITools.Extensions
{
    public static class TaskTools
    {

        public static ManualResetEvent Intervall(int aMillisecondsIntervall, Action aAction)
        {
            var localExit = new ManualResetEvent(false);
            new Thread(() => {
                bool isLocalExit = false;
                while (!isLocalExit)
                {
                    try
                    {
                        aAction();
                    }
                    catch (Exception Error)
                    {
                        Console.WriteLine(Error);
                    }
                    isLocalExit = localExit.WaitOne(aMillisecondsIntervall);
                }
            }).Start();
            return localExit;
        }

        public static void Delay(int aSeconds, Action aAction)
        {
            Delay(new TimeSpan(0,0, aSeconds), aAction);
        }

        public static ManualResetEvent Delay(TimeSpan aExecAfterTimeout, Action aAction)
        {
            var localExit = new ManualResetEvent(false);
            new Thread(() => {
                try
                {
                    localExit.WaitOne(aExecAfterTimeout);
                    aAction();
                }
                catch (Exception Error)
                {
                    Console.WriteLine(Error);
                }
            }).Start();
            return localExit;
        }

    }
}
