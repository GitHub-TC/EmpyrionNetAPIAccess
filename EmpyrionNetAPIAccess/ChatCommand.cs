using Eleon.Modding;
using EmpyrionNetAPIDefinitions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public class ChatCommand
    {
        public delegate Task ChatCommandHandler(ChatInfo info, Dictionary<string, string> arguments = null);

        public readonly string invocationPattern;
        public ChatCommandHandler handler;
        public readonly string description;
        public readonly PermissionType minimumPermissionLevel;

        public List<string> paramNames
        {
            get;
            private set;
        }

        public ChatCommand(string invocationPattern, ChatCommandHandler handler, string description = "", PermissionType minimumPermissionLevel = PermissionType.Player)
        {
            this.invocationPattern = invocationPattern;
            this.handler = handler;
            this.description = description;
            this.minimumPermissionLevel = minimumPermissionLevel;
            var re = new Regex(invocationPattern);
            paramNames = re.GetGroupNames().Where(x => x != "0").ToList();
        }

        private static Regex extractionPattern = new Regex(@"\(\?<([\w_]+)>[^)]+\)", RegexOptions.Compiled);

        public static string PatternToParamString(string pattern)
        {
            var result = pattern;
            var matches = extractionPattern.Matches(result);

            foreach (Match item in matches)
            {
                result = result.Replace(item.Value, $@"{{{item.Groups[1].Value}}}");
            }
            return result;
        }

        public override string ToString()
        {
            var permissionLevelString = this.minimumPermissionLevel != PermissionType.Player ? $"({this.minimumPermissionLevel.ToString()}) " : "";
            var invocationPatternString = PatternToParamString(this.invocationPattern);
            var hasDescription = this.description != "";
            if (!hasDescription) return invocationPatternString;
            return $@"{invocationPatternString} : {permissionLevelString}{this.description}";
        }
    }

    public class ChatCommandSuperPattern
    {
        public readonly Regex pattern;
        public Dictionary<string, ChatCommand> patternDict;
        public ReadOnlyCollection<string> CommandGroupNames;

        private static String HashCodeToName(int hashCode)
        {
            var numbers = Math.Abs(hashCode).ToString().ToCharArray();
            var transformed = numbers
              .Select(x => (char)(int.Parse(x.ToString()) + 65))
              .Select(x => x.ToString()).ToArray();
            return String.Join("", transformed);

        }

        public ChatCommandSuperPattern(Regex pattern, Dictionary<string, ChatCommand> patternDict)
        {
            this.pattern = pattern;
            this.patternDict = patternDict;
            var gn = pattern.GetGroupNames().Where(x => x.StartsWith("cmd")).ToList();
            this.CommandGroupNames = new ReadOnlyCollection<string>(gn);
        }

        public static ChatCommandSuperPattern PatternFromCommandList(List<ChatCommand> commandList)
        {
            var patternList = new List<string>();

            var patternDict = new Dictionary<string, ChatCommand>();
            foreach (var item in commandList)
            {
                var key = $"cmd_{HashCodeToName(item.GetHashCode())}";
                var pattern = $@"(?<{key}>^{item.invocationPattern}$)";
                patternList.Add(pattern);
                patternDict[key] = item;
            }
            var superPattern = String.Join("|", patternList.ToArray());
            var superRegex = new Regex(superPattern, RegexOptions.Compiled);

            return new ChatCommandSuperPattern(superRegex, patternDict);
        }
    }



    public class ChatCommandMatch
    {
        public readonly ChatCommand command;
        public readonly Dictionary<String, String> parameters;

        public ChatCommandMatch(ChatCommand command, Dictionary<string, string> parameters)
        {
            this.command = command;
            this.parameters = parameters;
        }
    }

    public class ChatCommandManager
    {
        public ChatCommandSuperPattern superPattern { get; private set; }

        public List<ChatCommand> CommandList {
            get { return _CommandList; }
            set { _CommandList = value; superPattern = ChatCommandSuperPattern.PatternFromCommandList(_CommandList); }
        }
        List<ChatCommand> _CommandList;
        /// <summary>
        /// A simple text all chat commands have to start with wenn the user typed it
        /// </summary>
        public string CommandPrefix { get; set; }

        public ChatCommandMatch MatchCommand(string message)
        {
            Match match = null;

            if (!string.IsNullOrEmpty(CommandPrefix))
            {
                if (!message.StartsWith(CommandPrefix)) return null;
                match = this.superPattern.pattern.Match(message.Substring(CommandPrefix.Length));
            }
            else match = this.superPattern.pattern.Match(message);

            if (!match.Success) return null;

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
                    paramDict[name] = match.Groups[name].Value;
                }

                return new ChatCommandMatch(command, paramDict);
            }
            return null;
        }
    }

}
