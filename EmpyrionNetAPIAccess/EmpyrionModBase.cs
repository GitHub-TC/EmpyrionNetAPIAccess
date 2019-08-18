using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Eleon.Modding;
using EmpyrionNetAPIDefinitions;

namespace EmpyrionNetAPIAccess
{
    public enum Timeouts
    {
        /// <summary>
        /// No Timeout waiting for an Response
        /// </summary>
        NoResponse  = 0,
        /// <summary>
        /// Timeout after 1s
        /// </summary>
        Wait1s  = 1,
        /// <summary>
        /// Timeout after 10s
        /// </summary>
        Wait10s = 10,
        /// <summary>
        /// Timeout after 20s
        /// </summary>
        Wait20s = 20,
        /// <summary>
        /// Timeout after 20s
        /// </summary>
        Wait30s = 30,
        /// <summary>
        /// Timeout after 1m
        /// </summary>
        Wait1m = 60,
        /// <summary>
        /// Timeout after 10m
        /// </summary>
        Wait10m = 600
    }

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

        public ChatCommandManager ChatCommandManager { get; } = new ChatCommandManager();

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
            try{ Request_InGameMessage_SinglePlayer(message.ToIdMsgPrio(playerId, priority)).Wait(1000); }
            catch{}
        }

        public async Task ShowDialog(int aPlayerId, PlayerInfo aPlayer, string aTitle, string aMessage)
        {
            await Request_ShowDialog_SinglePlayer(Timeouts.NoResponse, new DialogBoxData()
            {
                Id = aPlayerId,
                MsgText = $"{aTitle}: [c][ffffff]{aPlayer.playerName}[-][/c] with permission [c][ffffff]{(PermissionType)aPlayer.permission}[-][/c]\n{aMessage}"
            });
        }

        public async Task<IdAndIntValue> ShowDialog(int aPlayerId, PlayerInfo aPlayer, string aTitle, string aMessage, string PosButtonText, string NegButtonText)
        {
            return await Request_ShowDialog_SinglePlayer(Timeouts.Wait10m, new DialogBoxData()
            {
                Id = aPlayerId,
                MsgText = $"{aTitle}: [c][ffffff]{aPlayer.playerName}[-][/c] with permission [c][ffffff]{(PermissionType)aPlayer.permission}[-][/c]\n" + aMessage,
                PosButtonText = PosButtonText,
                NegButtonText = NegButtonText,
            });
        }

        public async Task DisplayHelp(int playerId, string additionalInfos)
        {
            var player = await Request_Player_Info(playerId.ToId());
            var CurrentAssembly = Assembly.GetAssembly(this.GetType());
            //[c][hexid][-][/c]    [c][019245]test[-][/c].

            await ShowDialog(playerId, player, "Commands",
                "\n" + String.Join("\n", GetChatCommandsForPermissionLevel((PermissionType)player.permission).Select(C => C.MsgString(string.IsNullOrEmpty(ChatCommandManager.CommandPrefix) ? null : ChatCommandManager.CommandPrefix[0].ToString())).ToArray()) +
                (additionalInfos == null ? "" : "\n\n") + additionalInfos +
                $"\n\n[c][c0c0c0]{CurrentAssembly.GetAttribute<AssemblyTitleAttribute>()?.Title} by {CurrentAssembly.GetAttribute<AssemblyCompanyAttribute>()?.Company} Version:{CurrentAssembly.GetAttribute<AssemblyFileVersionAttribute>()?.Version}[-][/c]"
                );
        }

        public void Game_Event(CmdId eventId, ushort seqNr, object data)
        {
            try
            {
                Broker.HandleGameEvent(eventId, seqNr, data);
                if (eventId == CmdId.Event_ChatMessage) ProcessChatCommandsSafeCall((ChatInfo)data).Wait();

                API_Message_Received?.Invoke(eventId, seqNr, data);
            }
            catch (Exception error)
            {
                Log($"Game_Event Exception: {eventId}/{seqNr}/{data?.ToString()} : {error.ToString()}");
            }
        }

        private async Task ProcessChatCommandsSafeCall(ChatInfo data)
        {
            try
            {
                await ProcessChatCommands(data);
            }
            catch (Exception error)
            {
                Log($"ChatCommand Exception: {data.msg}/{data.playerId} : {error}");
            }
        }

        public void Game_Exit()
        {
            API_Exit?.Invoke();
        }

        public void Game_Start(ModGameAPI dediAPI)
        {
            Broker.api = dediAPI;
            this.Initialize(dediAPI);

            this.ChatCommandManager.CommandList = ChatCommands;
        }

        private async Task ProcessChatCommands(ChatInfo obj)
        {
            var match = ChatCommandManager.MatchCommand(obj?.msg);
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

        public void Log(string msg)
        {
            Broker.log(msg);
        }

        public void Log(string msg, LogLevel aLevel)
        {
            Broker.log(msg, aLevel);
        }

        public void Log(Func<string> msg)
        {
            Broker.log(msg);
        }

        public void Log(Func<string> msg, LogLevel aLevel)
        {
            Broker.log(msg, aLevel);
        }
    }
}
