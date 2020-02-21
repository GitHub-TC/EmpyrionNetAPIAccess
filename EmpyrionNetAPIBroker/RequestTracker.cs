using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public class RequestTracker
    {
        private static object _nextAvailableSequenceNumberLock = new object();
        private static int _nextAvailableSequenceNumber = new Random().Next(10000);
        private ConcurrentDictionary<ushort, object/*TaskCompletionSource<T>*/> _taskCompletionSourcesById = new ConcurrentDictionary<ushort, object>();

        /// <summary>
        /// There is no expected GameEvent to handle these Requests
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fn"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        internal async Task<T> GetNewTaskCompletionSourceAsync<T>(Func<ushort, T> fn, CancellationToken ct = default(CancellationToken))        
        {
            var tcs1 = new TaskCompletionSource<T>(ct);
            var tuple = GetNewTaskCompletionSource(tcs1);

#pragma warning disable CS4014
            Task.Factory.StartNew(() => tcs1.SetResult(fn(tuple.Item1)), ct);
#pragma warning restore CS4014

            return await tuple.Item2;
        }

        /// <summary>
        /// The TaskCompletionSource will ultimately be completed in the scope of TryHandleEvent as the Mod handles the raised GameEvent 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ct"></param>
        /// <returns></returns>
        internal async Task<Tuple<ushort, Task<T>>> GetNewTaskCompletionSourceAsync<T>(CancellationToken ct = default(CancellationToken))
        {
            return await Task.Factory.StartNew(() => GetNewTaskCompletionSource(new TaskCompletionSource<T>(ct)), ct);
        }

        internal Tuple<ushort, Task<T>> GetNewTaskCompletionSource<T>(TaskCompletionSource<T> taskCompletionSource)
        {
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

            if (eventId == Eleon.Modding.CmdId.Event_Error && data is Eleon.Modding.ErrorInfo eInfo)
            {
                System.Reflection.MethodInfo setException = taskCompletionSource.GetType().GetMethod("TrySetException", new Type[] { typeof(Exception) });

                setException.Invoke(taskCompletionSource, new[]
                {
                    new Exception(eInfo.errorType.ToString())
                });
                return true;
            }
            else
            {
                try
                {
                    if (taskCompletionSource is TaskCompletionSource<bool> tcs1)
                    {
                        tcs1.TrySetCanceled();
                    }
                    else
                    {
                        System.Reflection.MethodInfo setResult = taskCompletionSource.GetType().GetMethod("TrySetResult");
                        setResult.Invoke(taskCompletionSource, new[] { data });
                    }
                    return true;
                }
                catch (Exception error)
                {
                    System.Reflection.MethodInfo setException = taskCompletionSource.GetType().GetMethod("TrySetException", new Type[] { typeof(Exception) });
                    setException.Invoke(taskCompletionSource, new[] { error });
                }
                return false;
            }
        }
    }
}
