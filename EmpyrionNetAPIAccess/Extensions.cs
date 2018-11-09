using Eleon.Modding;
using EmpyrionNetAPIDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpyrionNetAPIAccess
{
  public static class Extensions
  {

    /// <summary>
    /// Quickly creates an Eleon Id from an Integer
    /// </summary>
    /// <param name="anId"></param>
    /// <returns></returns>
    public static Id ToId(this int anId)
    {
      return new Id(anId);
    }

    /// <summary>
    /// Creates an IdMsgPrio for a string with optional parameters
    /// </summary>
    /// <param name="msg">the message to be sent</param>
    /// <param name="id">the id of the player to send it to</param>
    /// <param name="prio">the urgency of the message</param>
    /// <param name="duration">how long the message should remain visible</param>
    /// <returns>The fully formed IdMsgPrio</returns>
    public static IdMsgPrio ToIdMsgPrio(this string msg, int id, MessagePriorityType prio = MessagePriorityType.Alarm, float duration = 3.0F)
    {
      return new IdMsgPrio()
      {
        id = id,
        msg = msg,
        prio = (byte)prio,
        time = duration
      };
    }

    /// <summary>
    /// Easy way to convert string to pstring
    /// </summary>
    /// <param name="msg">string to convert</param>
    /// <returns>the appropriate pstring</returns>
    public static PString ToPString(this string msg)
    {
      return new PString(msg);
    }
  }
}
