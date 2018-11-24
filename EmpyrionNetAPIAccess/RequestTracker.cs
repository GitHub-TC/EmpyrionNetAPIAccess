using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public class RequestTracker
    {
        private static object _nextAvailableIdLock = new object();
        private static int _nextAvailableId = 12340;
        private Dictionary<ushort, object/*TaskCompletionSource<T>*/> _taskCompletionSourcesById = new Dictionary<ushort, object>();

        internal Tuple<ushort, Task<T>> GetNewTaskCompletionSource<T>()
        {
            if (_nextAvailableId == ushort.MaxValue) lock(_nextAvailableIdLock) _nextAvailableId = 12340;

            var newId = (ushort)Interlocked.Increment(ref _nextAvailableId);

            var taskCompletionSource = new TaskCompletionSource<T>();
            _taskCompletionSourcesById[newId] = taskCompletionSource;

            return new Tuple<ushort, Task<T>>(newId, taskCompletionSource.Task);
        }

        internal bool TryHandleEvent(Eleon.Modding.CmdId eventId, ushort seqNr, object data)
        {
            bool trackingIdFound = _taskCompletionSourcesById.ContainsKey(seqNr);

            if (trackingIdFound)
            {
                object taskCompletionSource = _taskCompletionSourcesById[seqNr];
                _taskCompletionSourcesById.Remove(seqNr);

                if (eventId == Eleon.Modding.CmdId.Event_Error)
                {
                    Eleon.Modding.ErrorInfo eInfo = (Eleon.Modding.ErrorInfo)data;
                    System.Reflection.MethodInfo setException = taskCompletionSource.GetType().GetMethod("SetException", new Type[] { typeof(Exception) });
                    setException.Invoke(taskCompletionSource, new[] { new Exception(eInfo.errorType.ToString()) });
                }
                else
                {
                    System.Reflection.MethodInfo setResult = taskCompletionSource.GetType().GetMethod("SetResult");
                    setResult.Invoke(taskCompletionSource, new[] { data });
                }
            }

            return trackingIdFound;
        }
    }
}
