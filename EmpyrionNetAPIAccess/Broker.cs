using Eleon.Modding;
using EmpyrionNetAPIDefinitions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public partial class Broker
    {
        public ModGameAPI api { get; set; }
        public LogLevel LogLevel { get; set; } = LogLevel.Message;

        private RequestTracker _requestTracker = new RequestTracker();
        
        public async Task<TResult> SendRequestAsync<TArg, TResult>(CmdId cmdID, TArg data, CancellationToken ct = default(CancellationToken))
            where TArg : class, new()
            where TResult : class, new()
        {
            ct.ThrowIfCancellationRequested();

            var result = await _requestTracker.GetNewTaskCompletionSourceAsync<TResult>(ct);

            api.Game_Request(cmdID, result.Item1, data);

            return await result.Item2;
        }

        public async Task<TResult> SendRequestAsync<TResult>(CmdId cmdID, CancellationToken ct = default(CancellationToken))
            where TResult : class, new()
        {
            ct.ThrowIfCancellationRequested();

            var result = await _requestTracker.GetNewTaskCompletionSourceAsync<TResult>(ct);

            api.Game_Request(cmdID, result.Item1, null);            

            return await result.Item2;
        }

        public async Task<bool> SendRequestAsync(CmdId cmdID, object data, CancellationToken ct = default(CancellationToken))
        {
            ct.ThrowIfCancellationRequested();

            return await _requestTracker.GetNewTaskCompletionSourceAsync((seqNbr) => api.Game_Request(cmdID, seqNbr, data), ct);
        }

        public async Task<bool> SendRequestAsync(CmdId cmdID, CancellationToken ct = default(CancellationToken))
        {
            ct.ThrowIfCancellationRequested();

            return await _requestTracker.GetNewTaskCompletionSourceAsync((seqNbr) => api.Game_Request(cmdID, seqNbr, null), ct);
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
                    Log($"HandleGameEvent: CmdId:{eventId} seqNr:{seqNr} data:{data} => {Error}");
                }
            }

            return _requestTracker.TryHandleEvent(eventId, seqNr, data);
        }

        public void Log(string message)
        {
            Log(message, LogLevel.Message);
        }

        public void Log(string message, LogLevel aLevel)
        {
            if (LogLevel <= aLevel) api.Console_Write(message);
        }

        public void Log(Func<string> message)
        {
            Log(message, LogLevel.Debug);
        }

        public void Log(Func<string> message, LogLevel aLevel)
        {
            if (LogLevel <= aLevel) api.Console_Write(message());
        }
        public void noOpErrorHandler(ErrorInfo info) { }
    }
}
