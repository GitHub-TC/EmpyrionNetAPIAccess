using Eleon.Modding;
using System.Collections.Generic;
using System.Linq;
using System;
using EmpyrionNetAPIDefinitions;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{

    public partial class Broker
    {
        public ModGameAPI api { get; set; }
        public bool verbose { get; set; }
        public LogLevel LogLevel { get; set; }

        private RequestTracker _requestTracker = new RequestTracker();

        public Task<T> SendRequest<T>(Eleon.Modding.CmdId cmdID, object data)
        {
            var result = _requestTracker.GetNewTaskCompletionSource<T>();

            api.Game_Request(cmdID, result.Item1, data);

            return result.Item2;
        }

        public Task SendRequest(Eleon.Modding.CmdId cmdID, object data)
        {
            var result = _requestTracker.GetNewTaskCompletionSource<object>();

            api.Game_Request(cmdID, result.Item1, data);

            return result.Item2;
        }

        public bool HandleGameEvent(CmdId eventId, ushort seqNr, object data)
        {
            if (eventTable.TryGetValue(eventId, out Delegate handler))
            {
                try
                {
                    handler.DynamicInvoke(new object[] { data });
                }
                catch (Exception Error)
                {
                    log($"HandleGameEvent: CmdId:{eventId} seqNr:{seqNr} data:{data} => {Error}");
                }
            }

            return _requestTracker.TryHandleEvent(eventId, seqNr, data);
        }

        public void log(string message)
        {
            log(message, LogLevel.Debug);
        }

        public void log(string message, LogLevel aLevel)
        {
            if (verbose && LogLevel <= aLevel)
                api.Console_Write(message);
        }

        public void log(System.Func<string> message)
        {
            log(message, LogLevel.Debug);
        }

        public void log(System.Func<string> message, LogLevel aLevel)
        {
            if (verbose && LogLevel <= aLevel)
                api.Console_Write(message());
        }
        public void noOpErrorHandler(ErrorInfo info) { }
    }
}
