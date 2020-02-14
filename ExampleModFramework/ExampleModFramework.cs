using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Eleon.Modding;
using EmpyrionNetAPIAccess;
using EmpyrionNetAPIDefinitions;
using EmpyrionNetAPITools;
using NLog;
using NLog.Common;
using NLog.Config;
using NLog.Targets;
using UnityEngine;
using NLogLevel = NLog.LogLevel;

namespace ExampleMod
{
    [Serializable]
    public class GameEventInfo
    {
        public CmdId EventId { get; set; }
        public ushort SequenceNumber { get; set; }
        public DateTime Updated { get; set; }
        public ulong GameTick { get; set; }
    }

    [Serializable]
    public class GameEventPayload : GameEventInfo
    {
        public object Data { get; set; }
    }

    public class NlogMemoryTarget : Target
    {
        public event EventHandler<string> OnLog;

        public NlogMemoryTarget(string name, NLogLevel level) : this(name, level, level) { }
        public NlogMemoryTarget(string name, NLogLevel minLevel, NLogLevel maxLevel)
        {
            // important: we want LogManager.Configuration property assign behaviors \ magic to occur
            //   see: https://stackoverflow.com/a/3603571/1366179
            var config = LogManager.Configuration ?? new XmlLoggingConfiguration(string.Join(@"\\", Path.Combine(EmpyrionConfiguration.ModPath, "ExampleModFramework" ), "NLog.config")); // new LoggingConfiguration(new LogFactory());
            
            // Add Target and Rule to their respective collections
            config.AddTarget(name, this);
            config.LoggingRules.Add(new LoggingRule("*", minLevel, maxLevel, this));

            LogManager.Configuration = config;
        }

        [Obsolete]
        protected override void Write(AsyncLogEventInfo[] logEvents)
        {
            foreach (var logEvent in logEvents)
            {
                Write(logEvent.LogEvent);
            }
        }

        protected override void Write(AsyncLogEventInfo logEvent)
        {
            Write(logEvent.LogEvent);
        }

        protected override void Write(LogEventInfo logEvent)
        {
            OnLog(this, string.Join(" ", $"-{logEvent.Level.Name.ToUpper()}-", logEvent.FormattedMessage));
        }

        // consider overriding WriteAsyncThreadSafe methods as well.
    }

    public class ExampleMod : IMod, ModInterface
    {
        private static Logger _nlog = LogManager.GetCurrentClassLogger();

        private Broker broker = new Broker();

        private IModApi _modApi;
        private NlogMemoryTarget _nlogMemoryTarget;

        private DateTime _lastUpdate;
        //private GameEventInfo _lastGameEventInfo;

        readonly Random rnd = new Random();

        public ExampleMod()
        {
        }

        void IMod.Init(IModApi modAPI)
        {
            _modApi = modAPI;
#if DEBUG
            _nlogMemoryTarget = new NlogMemoryTarget("ExampleMod", NLogLevel.Trace, NLogLevel.Fatal);
#else
            _nlogMemoryTarget = new NlogMemoryTarget("ExampleMod", NLogLevel.Trace, NLogLevel.Fatal);
#endif
            _nlogMemoryTarget.OnLog += _nlogMemoryTarget_OnLog;

            _modApi.Application.OnPlayfieldLoaded += Application_OnPlayfieldLoaded;
        }

        private void _nlogMemoryTarget_OnLog(object sender, string e) => _modApi.Log(e);

        void IMod.Shutdown()
        {
            _nlog.Trace("Shutting Down");
        }

        public void Game_Update()
        {
            _lastUpdate = DateTime.UtcNow;

            //_nlog.Trace($" _modApi?.Application?.GameTicks := { _modApi?.Application?.GameTicks ?? 0 }");
            //_nlog.Trace($" Broker?.api?.Game_GetTickTime() := { broker?.api?.Game_GetTickTime() ?? 0 }");

            if (TryGetBrokerApiGameTicks(out var tick))
                ExampleMod_Update_Received(tick);
        }

        private bool TryGetBrokerApiGameTicks(out ulong tick)
        {
            tick = broker?.api?.Game_GetTickTime() ?? 0;
            return tick > 0;
        }

        private bool TryGetModApiGameTicks(out ulong tick)
        {
            tick = _modApi?.Application?.GameTicks ?? 0;
            return tick > 0;
        }

        public void Initialize(ModGameAPI dediAPI)
        {
            _nlog.Trace("Calling Initialize!");
            broker.api = dediAPI;

            if (dediAPI != null)
                _nlog.Trace("dediAPI (ModGameAPI legacy) exists");

            broker.Event_Playfield_Loaded += Broker_Event_Playfield_Loaded;

            //Broker.Update_Received += ExampleMod_Update_Received;
            //Broker.Event_ChatMessage += ExampleMod_Event_HandleLottoChatMessage;
            //Broker.Event_GameEvent += ExampleMod_Event_GameEvent;
            //Broker.Event_Statistics += PlayerDied_Event_Statistics;

            //ChatCommands.AddRange(new[]
            //{
            //    new ChatCommand(@"/repeat (?<repeat>\S+)", RepeatMessageHandlerAsync),
            //    new ChatCommand(@"!loudly (?<yellthis>.+)", YellThisHandlerAsync),
            //    new ChatCommand(@"/explosion", ExplosionHandlerAsync, "blows it up", PermissionType.Moderator)
            //});

            //async Task RepeatMessageHandlerAsync(ChatInfo data, Dictionary<string, string> args) =>
            //    await broker.Request_InGameMessage_SinglePlayer(new IdMsgPrio
            //    {
            //        id = data?.playerId ?? 0,
            //        msg = string.Format("{0} {0} {0}!", args["repeat"])
            //    });

            //async Task YellThisHandlerAsync(ChatInfo data, Dictionary<string, string> args) =>
            //    await broker.Request_InGameMessage_SinglePlayer(new IdMsgPrio()
            //    {
            //        id = data?.playerId ?? 0,
            //        msg = $"{args["yellthis"]?.ToUpper()}!!!!!"
            //    });

            //async Task ExplosionHandlerAsync(ChatInfo data, Dictionary<string, string> args)
            //{
            //    var playerId = data?.playerId ?? 0;

            //    var result = (await broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, new DialogBoxData
            //    {
            //        Id = playerId,
            //        MsgText = "BOOM!",
            //        PosButtonText = "yes",
            //        NegButtonText = "No"
            //    })).Value == 0 ? "YES" : "NO";
                
            //    await broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, result.ToIdMsgPrio(playerId));
            //}

            //this.ChatCommands.Add(new ChatCommand(@"/help", (data, __) => {
            //  this.Request_Player_Info(data.playerId.ToId(), (info) =>
            //  {
            //    var playerPermissionLevel = (PermissionType)info.permission;
            //    var header = $"Commands available to {info.playerName}; permission level {playerPermissionLevel}\n";

            //    var lines = this.GetChatCommandsForPermissionLevel(playerPermissionLevel)
            //      .Select(x => x.ToString())
            //      .OrderBy(x => x.Length).ToList();

            //    lines.Insert(0, header);


            //    var dialogData = new DialogBoxData()
            //    {
            //      Id = data.playerId,
            //      MsgText = String.Join("\n", lines.ToArray())
            //    };

            //    Request_ShowDialog_SinglePlayer(dialogData);
            //  });
            //}));
        }

        private void Application_OnPlayfieldLoaded(IPlayfield playfield)
        {
            _nlog.Trace($"Application_OnPlayfieldLoaded Raised => PlayfieldLoad := \"{playfield.Name}\"");
            foreach (var p in playfield.Players)
            {
                var player = p.Value;
                var vessel = player.Structure;
                var dockedVessels = vessel?.GetDockedVessels() ?? new List<IStructure>();

                _nlog.Trace("Player {0} is Piloting {1} and has {2} vessels docked", player.Name, vessel?.Entity.Name ?? "Nothing", dockedVessels.Count());
            }
        }

        private void Broker_Event_Playfield_Loaded(PlayfieldLoad obj)
        {
            _nlog.Trace($"Broker_Event_Playfield_Loaded Raised => PlayfieldLoad := \"{obj.playfield}\"");
            

            //broker.api.Game_Request(CmdId.Request_InGameMessage_SinglePlayer, )
        }

        private async void PlayerDied_Event_Statistics(StatisticsParam obj)
        {
            //Log("***************event statistics!!!");
            var container = StatisticsContainer.FromStatisticsParam(obj);

            switch (container)
            {
                case PlayerDiedStatistics deathStats:
                    var msg = new IdMsgPrio
                    {
                        msg = $"Player {deathStats.PlayerId.id} was killed by {deathStats.KillerId.id}"
                    };
                    broker.Log(msg.msg);
                    await broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, msg);
                    break;
                default:
                    break;
            }
        }

        private async void ExampleMod_Event_GameEvent(GameEventData obj)
        {
            //Log("*****************OMG it's a game event!!!");
            _nlog.Trace($@"A game event occured, name:{obj.Name}, type:{obj.Type}, eventType:{obj.EventType}");
            
            await broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, new IdMsgPrio
            {
                msg = $@"A game event occured, name:{obj.Name}, type:{obj.Type}, eventType:{obj.EventType}"
            });
        }

        private void ExampleMod_Event_HandleLottoChatMessage(ChatInfo obj)
        {
            //Log("lotto check");
            _nlog.Trace("lotto check");
            if ((obj?.msg ?? string.Empty) != "lottery") return;

            //this.Request_Player_List(list =>
            //{
            //  var index = rnd.Next() % list.list.Count;
            //  var selectedId = list.list[index];

            //  var msgParam = new IdMsgPrio()
            //  {
            //    id = selectedId,
            //    msg = $"Congratulations!, You Won!"
            //  };

            //  var rewardParam = new ItemExchangeInfo()
            //  {
            //    id = selectedId,
            //    buttonText = "ok",
            //    title = "test",
            //    desc = "testdesc",
            //    items = new ItemStack[] {
            //      new ItemStack()
            //      {
            //        id = 256,
            //        count = 1
            //      }
            //    }
            //  };

            //  this.Request_Player_ItemExchange(rewardParam, result =>
            //  {
            //    log($"itemexchange result count {result.items.Count()}");
            //    if (result.items.Count() == 0) return;
            //    var tyParam = new IdMsgPrio()
            //    {
            //      id = selectedId,
            //      msg = $"Thanks for the gift!"
            //    };
            //    this.Request_InGameMessage_SinglePlayer(tyParam);

            //  }, x => log($"itemexchange error: {x.errorType.ToString()}"));

            //});

        }


        private async void ExampleMod_Update_Received(ulong tick)
        {

            if (tick != 0 && tick % 200 == 0)
            {
                //using (var source = new CancellationTokenSource(3000)) //1 seconds                
                //{
                var startTime = DateTime.UtcNow;
                var msg = $"{startTime.ToString("yyyy-MM-dd hh:mm:ss.fff")} :: game tick is now {tick}, an auspicious number";
                _nlog.Info($"broker.Request_InGameMessage_AllPlayers => msg := {msg}");
                try
                {
                    var r = await broker.Request_InGameMessage_AllPlayers(new IdMsgPrio { msg = msg });
                    //var r = await broker.Request_InGameMessage_AllPlayers(new IdMsgPrio { msg = msg }, source.Token);

                    //var r = await broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, new IdMsgPrio { msg = msg }).ConfigureAwait(false);
                    //var r = await broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, new IdMsgPrio { msg = msg }, source.Token).ConfigureAwait(false);

                    _nlog.Info($" After {DateTime.UtcNow.Subtract(startTime).Milliseconds} ms => Task Completed := {r}");
                }
                catch (Exception ex) when (ex is OperationCanceledException || ex is TaskCanceledException)
                {
                    _nlog.Error($" After {DateTime.UtcNow.Subtract(startTime).Milliseconds} ms :: {ex?.Message ?? "Task was Cancelled"}");
                }
                //}
            }
        }

        public void Game_Start(ModGameAPI dediAPI)
        {
            Initialize(dediAPI);
            _nlog.Trace("Game_Start called!");
        }

        public void Game_Exit()
        {
            _nlog.Trace("Game_Exit called!");
        }

        public void Game_Event(CmdId eventId, ushort seqNr, object data) => Game_Event(new GameEventPayload { EventId = eventId, SequenceNumber = seqNr, Data = data, GameTick = 0, Updated = DateTime.UtcNow });
    
        public void Game_Event(GameEventPayload gameEventInfo)
        {            
            _nlog.Trace($"Game_Event Called! {Environment.NewLine}{ JsonUtility.ToJson(gameEventInfo, true) }");
            if (broker.HandleGameEvent(gameEventInfo.EventId, gameEventInfo.SequenceNumber, gameEventInfo.Data))
                _nlog.Info("broker => Game_Event Handled");
            else
                _nlog.Info("broker => Game_Event Unhandled");
        }
    }
}
