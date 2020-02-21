using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Eleon.Modding;
using EmpyrionNetAPIDefinitions;

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

        public string MsgString(string prefix)
        {
            var CmdString = GetCommandPattern.Match(invocationPattern).Groups["cmd"]?.Value ?? invocationPattern;
            return $"[c][ff00ff]{ prefix }{ CmdString.Replace(@"\\", @"\") }[-][/c]{ paramNames.Aggregate(" ", (S, P) => S + $"<[c][00ff00]{P}[-][/c]> ") }: { description }";
        }
        
        private static Regex GetCommandPattern = new Regex(@"(?<cmd>(\w|\/|\\|\s)+)");

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
            return string.IsNullOrWhiteSpace(description)
                ? PatternToParamString(invocationPattern)
                : string.Format(@"{0} : {1}{2}", 
                    PatternToParamString(invocationPattern), 
                    (minimumPermissionLevel != PermissionType.Player) ? $"({ minimumPermissionLevel.ToString() }) " : string.Empty,
                    description);
        }
    }

}