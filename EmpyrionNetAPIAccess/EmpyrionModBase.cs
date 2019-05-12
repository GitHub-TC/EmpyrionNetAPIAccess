using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Eleon.Modding;
using EmpyrionNetAPIDefinitions;

namespace EmpyrionNetAPIAccess
{
    public abstract partial class EmpyrionModBase : ModInterface
    {

        public Broker Broker { get; set; } = new Broker();
        protected List<ChatCommand> ChatCommands { get; set; } = new List<ChatCommand>();
        /// <summary>
        /// Default Timeout for Empyrion Requests (10s)
        /// </summary>
        public TimeSpan EmpyrionRequestsDefaultTimeout { get; set; } = new TimeSpan(0, 0, 0, 10);

        protected LogLevel LogLevel
        {
            get { return Broker.LogLevel; }
            set { Broker.LogLevel = value; }
        }

        private ChatCommandManager ChatCommandManager;

        public delegate void APIEventHandler(CmdId eventId, ushort seqNr, object data);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
        public event APIEventHandler API_Message_Received;

        public delegate void ExitEventHandler();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
        public event ExitEventHandler API_Exit;

        public delegate void UpdateHandler(ulong tick);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
        public event UpdateHandler Update_Received;


        protected List<ChatCommand> GetChatCommandsForPermissionLevel(PermissionType permission)
        {
            return this.ChatCommands.Where(x => x.minimumPermissionLevel <= permission).ToList();
        }

        public abstract void Initialize(ModGameAPI dediAPI);

        /// <summary>
        /// Simple way to send an alert to the specified player
        /// </summary>
        /// <param name="playerId">id of player to inform</param>
        /// <param name="message">message</param>
        protected void AlertPlayer(int playerId, string message)
        {
            MessagePlayer(playerId, message, MessagePriorityType.Alarm);
        }

        /// <summary>
        /// Simple way to send info to the specified player
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="message"></param>
        protected void InformPlayer(int playerId, string message)
        {
            MessagePlayer(playerId, message, MessagePriorityType.Info);
        }

        /// <summary>
        /// Simple way to send a message to the specified player
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="message"></param>
        /// <param name="priority"></param>
        protected void MessagePlayer(int playerId, string message, MessagePriorityType priority = MessagePriorityType.Message)
        {
            var msg = message.ToIdMsgPrio(playerId, priority);
            Request_InGameMessage_SinglePlayer(msg).Wait(1000);
        }

        public async System.Threading.Tasks.Task ShowDialog(int aPlayerId, PlayerInfo aPlayer, string aTitle, string aMessage)
        {
            await Request_ShowDialog_SinglePlayer(new DialogBoxData()
            {
                Id = aPlayerId,
                MsgText = $"{aTitle}: [c][ffffff]{aPlayer.playerName}[-][/c] with permission [c][ffffff]{(PermissionType)aPlayer.permission}[-][/c]\n" + aMessage,
            });
        }

        public async System.Threading.Tasks.Task DisplayHelp(int playerId, string additionalInfos)
        {
            var player = await Request_Player_Info(playerId.ToId());
            var CurrentAssembly = Assembly.GetAssembly(this.GetType());
            //[c][hexid][-][/c]    [c][019245]test[-][/c].

            await ShowDialog(playerId, player, "Commands",
                "\n" + String.Join("\n", GetChatCommandsForPermissionLevel((PermissionType)player.permission).Select(C => C.MsgString()).ToArray()) +
                (additionalInfos == null ? "" : "\n\n") + additionalInfos +
                $"\n\n[c][c0c0c0]{CurrentAssembly.GetAttribute<AssemblyTitleAttribute>()?.Title} by {CurrentAssembly.GetAttribute<AssemblyCompanyAttribute>()?.Company} Version:{CurrentAssembly.GetAttribute<AssemblyFileVersionAttribute>()?.Version}[-][/c]"
                );
        }

        public void Game_Event(CmdId eventId, ushort seqNr, object data)
        {
            Broker.HandleGameEvent(eventId, seqNr, data);
            if (eventId == CmdId.Event_ChatMessage)
                try
                {
                    ProcessChatCommands((ChatInfo)data).Wait();
                }
                catch (Exception error)
                {
                    var c = (ChatInfo)data;
                    log($"ChatCommand Exception: {c.msg}/{c.playerId} : {error}");
                }

            API_Message_Received?.Invoke(eventId, seqNr, data);
        }

        public void Game_Exit()
        {
            API_Exit?.Invoke();
        }

        public void Game_Start(ModGameAPI dediAPI)
        {
            Broker.api = dediAPI;
            this.Initialize(dediAPI);

            this.ChatCommandManager = new ChatCommandManager(this.ChatCommands);
        }

        private async Task ProcessChatCommands(ChatInfo obj)
        {
            var match = ChatCommandManager.MatchCommand(obj.msg);
            if (match == null) return;
            if (match.command.minimumPermissionLevel > EmpyrionNetAPIDefinitions.PermissionType.Player)
            {
                var info = await Request_Player_Info(obj.playerId.ToId());

                if (info.permission < (int)match.command.minimumPermissionLevel) return;
                await match.command.handler(obj, match.parameters);

            }
            await match.command.handler(obj, match.parameters);
        }

        public void Game_Update()
        {
            Update_Received?.Invoke(Broker.api.Game_GetTickTime());
        }

        public void log(string msg)
        {
            Broker.log(msg);
        }

        public void log(string msg, LogLevel aLevel)
        {
            Broker.log(msg, aLevel);
        }

        public void log(Func<string> msg)
        {
            Broker.log(msg);
        }

        public void log(Func<string> msg, LogLevel aLevel)
        {
            Broker.log(msg, aLevel);
        }
    }
}
