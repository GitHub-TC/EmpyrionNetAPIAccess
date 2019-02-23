using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public class RequestTracker
    {
        private static object _nextAvailableIdLock = new object();
        private static int _nextAvailableId = 12340;
        private ConcurrentDictionary<ushort, object/*TaskCompletionSource<T>*/> _taskCompletionSourcesById = new ConcurrentDictionary<ushort, object>();

        internal Tuple<ushort, Task<T>> GetNewTaskCompletionSource<T>()
        {
            if (_nextAvailableId == ushort.MaxValue) lock(_nextAvailableIdLock) _nextAvailableId = 12340;

            var newId = (ushort)Interlocked.Increment(ref _nextAvailableId);

            var taskCompletionSource = new TaskCompletionSource<T>();
            while(!_taskCompletionSourcesById.TryAdd(newId, taskCompletionSource))
            {
                newId = (ushort)Interlocked.Increment(ref _nextAvailableId);
            }

            return new Tuple<ushort, Task<T>>(newId, taskCompletionSource.Task);
        }

        internal bool TryHandleEvent(Eleon.Modding.CmdId eventId, ushort seqNr, object data)
        {
            bool trackingIdFound = _taskCompletionSourcesById.TryRemove(seqNr, out object taskCompletionSource);
            if (!trackingIdFound) return false;

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

            return true;
        }
    }
}
