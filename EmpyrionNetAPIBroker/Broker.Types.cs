using Eleon.Modding;

namespace EmpyrionNetAPIAccess
{
    public partial class Broker
    {

        private class apiEvent
        {
            public CmdId eventId;
            public ushort seqNr;
            public object data;

            public apiEvent(CmdId eventId, ushort seqNr, object data)
            {
                this.eventId = eventId;
                this.seqNr = seqNr;
                this.data = data;
            }
        }

    }
}
