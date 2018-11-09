using Eleon.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
