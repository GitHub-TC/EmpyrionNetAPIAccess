﻿using Eleon.Modding;
using EmpyrionNetAPIDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

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

        public static string String(this PVector3 aVector) => $"{aVector.x:F1},{aVector.y:F1},{aVector.z:F1}";

        public static T GetAttribute<T>(this Assembly aAssembly)
        {
            return aAssembly.GetCustomAttributes(typeof(T), false).OfType<T>().FirstOrDefault();
        }

        static Regex GetCommand = new Regex(@"(?<cmd>(\w|\/|\\|\s)+)");

        public static string MsgString(this ChatCommand aCommand)
        {
            var CmdString = GetCommand.Match(aCommand.invocationPattern).Groups["cmd"]?.Value ?? aCommand.invocationPattern;
            return $"[c][ff00ff]{CmdString.Replace(@"\\", @"\")}[-][/c]{aCommand.paramNames.Aggregate(" ", (S, P) => S + $"<[c][00ff00]{P}[-][/c]> ")}: {aCommand.description}";
        }

    }
}
