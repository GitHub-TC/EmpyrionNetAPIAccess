using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public class RequestTracker
    {
        private static object _nextAvailableSequenceNumberLock = new object();
        private static int _nextAvailableSequenceNumber = new Random().Next(10000);
        private ConcurrentDictionary<ushort, object/*TaskCompletionSource<T>*/> _taskCompletionSourcesById = new ConcurrentDictionary<ushort, object>();

        internal async Task<Tuple<ushort, Task<T>>> GetNewTaskCompletionSourceAsync<T>()
        {
            return await Task.Factory.StartNew(GetNewTaskCompletionSource<T>);
        }

        internal Tuple<ushort, Task<T>> GetNewTaskCompletionSource<T>()
        {
            var taskCompletionSource = new TaskCompletionSource<T>();
            AddTaskCompletionSourceToConcurrentDictionary(taskCompletionSource, out ushort newSequenceNumber);
            return new Tuple<ushort, Task<T>>(newSequenceNumber, taskCompletionSource.Task);
        }

        private void AddTaskCompletionSourceToConcurrentDictionary<T>(TaskCompletionSource<T> source, out ushort newSequenceNumber)
        {
            if (_nextAvailableSequenceNumber == ushort.MaxValue)
                lock (_nextAvailableSequenceNumberLock)
                    _nextAvailableSequenceNumber = 12340;

            newSequenceNumber = (ushort)Interlocked.Increment(ref _nextAvailableSequenceNumber);
            while (!_taskCompletionSourcesById.TryAdd(newSequenceNumber, source))
            {
                newSequenceNumber = (ushort)Interlocked.Increment(ref _nextAvailableSequenceNumber);
            }
        }

        internal bool TryHandleEvent(Eleon.Modding.CmdId eventId, ushort seqNr, object data)
        {
            if (!_taskCompletionSourcesById.TryRemove(seqNr, out object taskCompletionSource))
                return false;

            if (eventId == Eleon.Modding.CmdId.Event_Error)
            {
                Eleon.Modding.ErrorInfo eInfo = (Eleon.Modding.ErrorInfo)data;
                System.Reflection.MethodInfo setException = taskCompletionSource.GetType().GetMethod("SetException", new Type[] { typeof(Exception) });

                setException.Invoke(taskCompletionSource, new[]
                {
                    new Exception(eInfo.errorType.ToString())
                });
                return true;
            }
            else
            {
                System.Reflection.MethodInfo setResult = taskCompletionSource.GetType().GetMethod("SetResult");
                try
                {
                    setResult.Invoke(taskCompletionSource, new[] { data });
                    return true;
                }
                catch (Exception error)
                {
                    System.Reflection.MethodInfo setException = taskCompletionSource.GetType().GetMethod("SetException", new Type[] { typeof(Exception) });
                    setException.Invoke(taskCompletionSource, new[] { error });
                }
                return false;
            }
        }
    }
}
