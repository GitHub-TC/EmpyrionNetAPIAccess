using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public class ChatCommandManager
    {
        public ChatCommandSuperPattern superPattern { get; private set; }

        public List<ChatCommand> CommandList
        {
            get { return _CommandList; }
            set { _CommandList = value; superPattern = ChatCommandSuperPattern.PatternFromCommandList(_CommandList); }
        }
        List<ChatCommand> _CommandList;
        /// <summary>
        /// A simple string with chars that all chat commands have to start with wenn the user typed it
        /// </summary>
        public string CommandPrefix { get; set; }

        public ChatCommandMatch MatchCommand(string message)
        {
            if (string.IsNullOrWhiteSpace(message)) return null;

            Match match = null;

            if (!string.IsNullOrEmpty(CommandPrefix))
            {
                if (!CommandPrefix.Contains(message[0])) return null;
                match = this.superPattern?.pattern?.Match(message.Substring(1));
            }
            else match = this.superPattern?.pattern?.Match(message);

            if (match == null || !match.Success) return null;

            ChatCommand resultCommand;
            Dictionary<string, string> paramDict;

            foreach (var item in superPattern.CommandGroupNames)
            {
                var group = match.Groups[item];
                if (!group.Success) continue;
                var command = this.superPattern.patternDict[item];
                resultCommand = command;
                paramDict = new Dictionary<string, string>();
                foreach (var name in resultCommand.paramNames)
                {
                    var groupMatch = match.Groups[name];
                    if (groupMatch != null && groupMatch.Success) paramDict[name] = groupMatch.Value;
                }

                return new ChatCommandMatch(command, paramDict);
            }

            return null;
        }
    }
}
