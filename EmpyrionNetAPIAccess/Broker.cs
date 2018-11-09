using Eleon.Modding;
using System.Collections.Generic;
using System.Linq;
using System;
using EmpyrionNetAPIDefinitions;

namespace EmpyrionNetAPIAccess
{

  public partial class Broker
  {
        public ModGameAPI api { get; set; }
    public bool verbose { get; set; }
    public LogLevel LogLevel { get; set; }

    private Dictionary<ushort, List<GenericAPICommand>> commandTracker = new Dictionary<ushort, List<GenericAPICommand>>();

    public GenericAPICommand Execute(GenericAPICommand command)
    {
      List<GenericAPICommand> tmp;
      var commandList = commandTracker.TryGetValue(command.SequenceNumber, out tmp) ? tmp : new List<GenericAPICommand>();
      log(() => $"adding: {command.responseHandler}");
      commandList.Add(command);
      commandTracker[command.SequenceNumber] = commandList;
      api.Game_Request(command.call.CmdId, command.SequenceNumber, command.argument);
      return command;
    }


    public void HandleGameEvent(CmdId eventId, ushort seqNr, object data)
    {            
      var apiEvent = new apiEvent(eventId, seqNr, data);
      log(() => $"receiving event {eventId.ToString()}:{seqNr}");

      Delegate handler;
      
      if (eventTable.TryGetValue(eventId, out handler))
        handler.DynamicInvoke(new object[] { data });

      
      if (!commandTracker.ContainsKey(seqNr)) return;
      
      var outstandingRequestList = commandTracker[seqNr];
      
      var firstApplicableRequest = outstandingRequestList.FirstOrDefault(x => x.call.ResponseCmdId == eventId || eventId == CmdId.Event_Error);
      
      if (firstApplicableRequest == null) return;
      
      outstandingRequestList.Remove(firstApplicableRequest);
      
      if (outstandingRequestList.Count > 0) commandTracker[seqNr] = outstandingRequestList;
      else commandTracker.Remove(seqNr);
      
      if (eventId == CmdId.Event_Error && firstApplicableRequest.errorHandler != null)
      {
          firstApplicableRequest.errorHandler((ErrorInfo)data);
          return;
      }
      
      firstApplicableRequest.responseHandler(eventId, data);
    }

    public void log(string message)
    {
        log(message, LogLevel.Debug);
    }

    public void log(string message, LogLevel aLevel)
    {
      if(verbose && LogLevel <= aLevel)
          api.Console_Write(message);
    }

    public void log(System.Func<string> message)
    {
        log(message, LogLevel.Debug);
    }

    public void log(System.Func<string> message, LogLevel aLevel)
    {
      if(verbose && LogLevel <= aLevel)
          api.Console_Write(message());
    }
    public void noOpErrorHandler(ErrorInfo info) { }
  }      
}
