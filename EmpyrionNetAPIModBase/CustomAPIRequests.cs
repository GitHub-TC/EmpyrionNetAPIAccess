using Eleon.Modding;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public abstract partial class EmpyrionModBase
    {
        public async Task<GlobalStructureInfo> Request_GlobalStructure_Info(Id id)
        {
            return await Broker.Request_GlobalStructure_Info(id);
        }

        public async Task<GlobalStructureInfo> Request_GlobalStructure_Info(Timeouts timeoutSeconds, Id id)
        {
            try
            {
                return await Broker.Request_GlobalStructure_Info(timeoutSeconds, id);
            }
            catch (TaskCanceledException) { if ((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(GlobalStructureInfo)); }
        }

    }
}
