using Eleon.Modding;
using EmpyrionNetAPITools.Extensions;
using System;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public partial class Broker
    {
        public async Task<GlobalStructureInfo> Request_GlobalStructure_Info(Id id)
        {
            return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<GlobalStructureInfo>(CmdId.Request_GlobalStructure_List + 100, id));
        }

        public async Task<GlobalStructureInfo> Request_GlobalStructure_Info(Timeouts timeoutSeconds, Id id)
        {
            try
            {
                return await TaskTools.For(new TimeSpan(0, 0, (int)timeoutSeconds), SendRequestAsync<GlobalStructureInfo>(CmdId.Request_GlobalStructure_List + 100, id));
            }
            catch (TaskCanceledException) { if ((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(GlobalStructureInfo)); }
        }

        public async Task Request_SendChatMessage(Eleon.MessageData message)
        {
            try
            {
                await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<GlobalStructureInfo>(CmdId.Event_ChatMessage + 100, message));
            }
            catch (TaskCanceledException) { }
        }

    }
}
