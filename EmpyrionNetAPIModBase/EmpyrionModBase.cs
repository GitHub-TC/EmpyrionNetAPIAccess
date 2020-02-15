using Eleon.Modding;
using EmpyrionNetAPIDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public abstract partial class EmpyrionModBase : ModInterface
    {
        public Broker Broker { get; set; } = new Broker();

        protected List<ChatCommand> ChatCommands { get; set; } = new List<ChatCommand>();
        
        protected LogLevel LogLevel {get => Broker.LogLevel; set => Broker.LogLevel = value; }

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


        protected List<ChatCommand> GetChatCommandsForPermissionLevel(PermissionType permission) => ChatCommands.Where(x => x.minimumPermissionLevel <= permission).ToList();

        public abstract void Initialize(ModGameAPI dediAPI);

        /// <summary>
        /// Simple way to send an alert to the specified player
        /// </summary>
        /// <param name="playerId">id of player to inform</param>
        /// <param name="message">message</param>
        protected void AlertPlayer(int playerId, string message) => MessagePlayer(playerId, message, MessagePriorityType.Alarm);

        /// <summary>
        /// Simple way to send info to the specified player
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="message"></param>
        protected void InformPlayer(int playerId, string message) => MessagePlayer(playerId, message, MessagePriorityType.Info);

        /// <summary>
        /// Simple way to send a message to the specified player
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="message"></param>
        /// <param name="priority"></param>
        protected void MessagePlayer(int playerId, string message, MessagePriorityType priority = MessagePriorityType.Message)
        {
            try {
                Broker.Request_InGameMessage_SinglePlayer(message.ToIdMsgPrio(playerId, priority)).Wait(1000);
            }
            catch { }
        }

        public async Task ShowDialog(int aPlayerId, PlayerInfo aPlayer, string aTitle, string aMessage)
        {
            await Broker.Request_ShowDialog_SinglePlayer(Timeouts.NoResponse, new DialogBoxData()
            {
                Id = aPlayerId,
                MsgText = $"{aTitle}: [c][ffffff]{aPlayer.playerName}[-][/c] with permission [c][ffffff]{(PermissionType)aPlayer.permission}[-][/c]\n{aMessage}"
            });
        }

        public async Task<IdAndIntValue> ShowDialog(int aPlayerId, PlayerInfo aPlayer, string aTitle, string aMessage, string PosButtonText, string NegButtonText)
        {
            return await Broker.Request_ShowDialog_SinglePlayer(Timeouts.Wait10m, new DialogBoxData()
            {
                Id = aPlayerId,
                MsgText = $"{aTitle}: [c][ffffff]{aPlayer.playerName}[-][/c] with permission [c][ffffff]{(PermissionType)aPlayer.permission}[-][/c]\n" + aMessage,
                PosButtonText = PosButtonText,
                NegButtonText = NegButtonText,
            });
        }

        public async Task DisplayHelp(int playerId, string additionalInfos)
        {
            var player = await Broker.Request_Player_Info(playerId.ToId());
            var CurrentAssembly = Assembly.GetAssembly(this.GetType());
            //[c][hexid][-][/c]    [c][019245]test[-][/c].

            await ShowDialog(playerId, player, "Commands",
                "\n" + string.Join("\n", GetChatCommandsForPermissionLevel((PermissionType)player.permission).Select(C => C.MsgString(string.IsNullOrEmpty(ChatCommandManager.CommandPrefix) ? null : ChatCommandManager.CommandPrefix[0].ToString())).ToArray()) +
                (additionalInfos == null ? "" : "\n\n") + additionalInfos +
                $"\n\n[c][c0c0c0]{CurrentAssembly.GetAttribute<AssemblyTitleAttribute>()?.Title} by {CurrentAssembly.GetAttribute<AssemblyCompanyAttribute>()?.Company} Version:{CurrentAssembly.GetAttribute<AssemblyFileVersionAttribute>()?.Version}[-][/c]"
                );
        }

        public void Game_Event(CmdId eventId, ushort seqNr, object data)
        {
            try
            {
                Broker.HandleGameEvent(eventId, seqNr, data);

                if (eventId == CmdId.Event_ChatMessage && data is ChatInfo chatInfo)
                    ProcessChatCommandsSafeCall(chatInfo).Wait();

                API_Message_Received?.Invoke(eventId, seqNr, data);
            }
            catch (Exception error)
            {
                Log($"Game_Event Exception: {eventId}/{seqNr}/{data?.ToString()} : {error.ToString()}");
            }
        }

        private async Task ProcessChatCommandsSafeCall(ChatInfo chatInfo) => await ProcessChatCommandsSafeCall(ChatCommandManager, Broker, chatInfo);

        private async Task ProcessChatCommands(ChatInfo chatInfo) => await ProcessChatCommands(ChatCommandManager, Broker, chatInfo);

        internal static async Task ProcessChatCommandsSafeCall(ChatCommandManager chatCmdManager, Broker broker, ChatInfo chatInfo)
        {
            try
            {
                await ProcessChatCommands(chatCmdManager, broker, chatInfo);
            }
            catch (Exception ex)
            {
                broker.Log($"ChatCommand Exception: {chatInfo.msg}/{chatInfo.playerId} : {ex}");
            }
        }

        internal static async Task ProcessChatCommands(ChatCommandManager chatCmdManager, Broker broker, ChatInfo chatInfo)
        {
            if (!(chatCmdManager.MatchCommand(chatInfo?.msg) is ChatCommandMatch match))
                return;

            if (await HasPermissionAsync(match.command.minimumPermissionLevel, async () => await broker.Request_Player_Info(chatInfo.playerId.ToId())))
                await match.command.handler(chatInfo, match.parameters);

            async Task<bool> HasPermissionAsync(PermissionType minimumPermissionLevel, Func<Task<PlayerInfo>> GetPlayerInfoAsync) => minimumPermissionLevel == PermissionType.Player || (await GetPlayerInfoAsync()).permission >= (int)minimumPermissionLevel;
        }

        public void Game_Start(ModGameAPI dediAPI)
        {
            Broker.api = dediAPI;
            Initialize(dediAPI);

            ChatCommandManager.CommandList = ChatCommands;
        }

        public void Game_Exit() => API_Exit?.Invoke();

        public void Game_Update() => Update_Received?.Invoke(Broker.api.Game_GetTickTime());

        public void Log(string msg) => Broker.Log(msg);

        public void Log(string msg, LogLevel aLevel) => Broker.Log(msg, aLevel);

        public void Log(Func<string> msg) => Broker.Log(msg);

        public void Log(Func<string> msg, LogLevel aLevel) => Broker.Log(msg, aLevel);
    }
    
}
