using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleon.Modding;
using EmpyrionNetAPIAccess;
using EmpyrionNetAPIDefinitions;

namespace ExampleModCoreApp
{
    public class ExampleModCoreApp : EmpyrionModBase
    {

        readonly Random rnd = new Random();


        public override void Initialize(ModGameAPI dediAPI)
        {

            this.Update_Received += ExampleMod_Update_Received;
            this.Event_ChatMessage += ExampleMod_Event_HandleLottoChatMessage;
            this.Event_GameEvent += ExampleMod_Event_GameEvent;
            this.Event_Statistics += PlayerDied_Event_Statistics;
            this.ChatCommands.Add(new ChatCommand(@"/repeat (?<repeat>\S+)", ChatCommand_TestMessage));
            this.ChatCommands.Add(new ChatCommand(@"!loudly (?<yellthis>.+)", async (data, args) => {
                var msg = new IdMsgPrio()
                {
                    id = data.playerId,
                    msg = $"{args["yellthis"].ToUpper()}!!!!!"
                };
                await Request_InGameMessage_SinglePlayer(msg);
            }));

            this.ChatCommands.Add(new ChatCommand(@"/explosion", async (data, __) => {
                var dialogData = new DialogBoxData()
                {
                    Id = data.playerId,
                    MsgText = "BOOM!",
                    PosButtonText = "yes",
                    NegButtonText = "No"
                };

                var t = Request_ShowDialog_SinglePlayer(dialogData);
                t.Wait();
                var resultInterpreted = t.Result.Value == 0 ? "YES" : "NO";

                await Request_InGameMessage_SinglePlayer(resultInterpreted.ToIdMsgPrio(data.playerId));
            }, "blows it up", PermissionType.Moderator));



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

        private async Task ChatCommand_TestMessage(ChatInfo data, Dictionary<string, string> args)
        {
            var repeating = args["repeat"];
            var msg = new IdMsgPrio()
            {
                id = data.playerId,
                msg = $"{repeating} {repeating} {repeating}!"
            };
            await Request_InGameMessage_SinglePlayer(msg);
        }

        private void PlayerDied_Event_Statistics(StatisticsParam obj)
        {
            Log("***************event statistics!!!");
            var container = StatisticsContainer.FromStatisticsParam(obj);

            switch (container)
            {
                case PlayerDiedStatistics deathStats:
                    var msg = new IdMsgPrio
                    {
                        msg = $"Player {deathStats.PlayerId.id} was killed by {deathStats.KillerId.id}"
                    };
                    Log(msg.msg);
                    this.Request_InGameMessage_AllPlayers(msg).Wait();
                    break;
                default:
                    break;
            }
        }

        private void ExampleMod_Event_GameEvent(GameEventData obj)
        {
            Log("*****************OMG it's a game event!!!");
            var eventMessage = new IdMsgPrio
            {
                msg = $@"A game event occured, name:{obj.Name}, type:{obj.Type}, eventType:{obj.EventType}"
            };

            this.Request_InGameMessage_AllPlayers(eventMessage).Wait();
        }

        private void ExampleMod_Event_HandleLottoChatMessage(ChatInfo obj)
        {
            Log("lotto check");
            if (obj.msg != "lottery") return;

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
            if (tick % 10000 == 0)
            {
                var param = new IdMsgPrio()
                {
                    msg = $"game tick is now {tick}, an auspicious number"
                };

                await this.Request_InGameMessage_AllPlayers(param);
            }
        }
    }
}
