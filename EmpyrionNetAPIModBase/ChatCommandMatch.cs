using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public class ChatCommandMatch
    {
        public readonly ChatCommand command;
        public readonly Dictionary<string, string> parameters;

        public ChatCommandMatch(ChatCommand command, Dictionary<string, string> parameters)
        {
            this.command = command;
            this.parameters = parameters;
        }
    }
}
