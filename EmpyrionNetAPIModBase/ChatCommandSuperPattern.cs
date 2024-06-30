using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmpyrionNetAPIAccess
{
    public class ChatCommandSuperPattern
    {
        public readonly Regex pattern;
        public Dictionary<string, ChatCommand> patternDict;
        public ReadOnlyCollection<string> CommandGroupNames;

        public ChatCommandSuperPattern(Regex pattern, Dictionary<string, ChatCommand> patternDict)
        {
            this.pattern = pattern;
            this.patternDict = patternDict;
            var gn = pattern.GetGroupNames().Where(x => x.StartsWith("cmd")).ToArray();
            CommandGroupNames = new ReadOnlyCollection<string>(gn);
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
            var superPattern = string.Join("|", patternList.ToArray());
            var superRegex = new Regex(superPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            return new ChatCommandSuperPattern(superRegex, patternDict);
        }

        private static string HashCodeToName(int hashCode)
        {
            var transformedNumbers = Math.Abs(hashCode).ToString().ToCharArray()
                .Select(x => ((char)(int.Parse(x.ToString()) + 65)).ToString())
                .ToArray();
            return string.Join(string.Empty, transformedNumbers);
        }
    }
}
