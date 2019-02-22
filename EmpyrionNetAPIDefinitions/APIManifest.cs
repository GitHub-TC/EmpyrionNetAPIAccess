using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eleon.Modding;

namespace EmpyrionNetAPIDefinitions
{
  public class APIEvent
  {
    public CmdId CmdId;
    public Type ParamType;

    public APIEvent(CmdId cmdId, Type paramType)
    {
      this.CmdId = cmdId;
      this.ParamType = paramType;
    }
  }

  public class APIRequest
  {
    public CmdId CmdId;
    public Type ParamType;
    public CmdId ResponseCmdId;

    public APIRequest(CmdId cmdId, Type paramType, CmdId responseCmdId)
    {
      CmdId = cmdId;
      ParamType = paramType;
      ResponseCmdId = responseCmdId;
      
    }
  }

  public static class APIManifest
  {
    public static List<APIRequest> RequestManifest = new List<APIRequest>()
    {
      new APIRequest(CmdId.Request_Playfield_List, null, CmdId.Event_Playfield_List),
      new APIRequest(CmdId.Request_Playfield_Stats, typeof(PString), CmdId.Event_Playfield_Stats),
      new APIRequest(CmdId.Request_Dedi_Stats, null, CmdId.Event_Dedi_Stats),
      new APIRequest(CmdId.Request_GlobalStructure_List, null, CmdId.Event_GlobalStructure_List),
      new APIRequest(CmdId.Request_GlobalStructure_Update, typeof(PString), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Structure_Touch, typeof(Id), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Structure_BlockStatistics, typeof(Id), CmdId.Event_Structure_BlockStatistics),
      new APIRequest(CmdId.Request_Player_Info, typeof(Id), CmdId.Event_Player_Info),
      new APIRequest(CmdId.Request_Player_List, null, CmdId.Event_Player_List),
      new APIRequest(CmdId.Request_Player_GetInventory, typeof(Id), CmdId.Event_Player_Inventory),
      new APIRequest(CmdId.Request_Player_SetInventory, typeof(Inventory), CmdId.Event_Player_Inventory),
      new APIRequest(CmdId.Request_Player_AddItem, typeof(IdItemStack), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Player_Credits, typeof(Id), CmdId.Event_Player_Credits),
      new APIRequest(CmdId.Request_Player_SetCredits, typeof(IdCredits), CmdId.Event_Player_Credits),
      new APIRequest(CmdId.Request_Player_AddCredits, typeof(IdCredits), CmdId.Event_Player_Credits),
      new APIRequest(CmdId.Request_Blueprint_Finish, typeof(Id), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Blueprint_Resources, typeof(BlueprintResources), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Player_ChangePlayerfield, typeof(IdPlayfieldPositionRotation), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Player_ItemExchange, typeof(ItemExchangeInfo), CmdId.Event_Player_ItemExchange),
      new APIRequest(CmdId.Request_Player_SetPlayerInfo, typeof(PlayerInfoSet), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_Teleport, typeof(IdPositionRotation), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_ChangePlayfield, typeof(IdPlayfieldPositionRotation), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_Destroy, typeof(Id), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_PosAndRot, typeof(Id), CmdId.Event_Entity_PosAndRot),
      new APIRequest(CmdId.Request_Entity_Spawn, typeof(EntitySpawnInfo), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Get_Factions, typeof(Id), CmdId.Event_Get_Factions),
      new APIRequest(CmdId.Request_NewEntityId, null, CmdId.Event_NewEntityId),
      new APIRequest(CmdId.Request_AlliancesAll, null, CmdId.Event_AlliancesAll),
      new APIRequest(CmdId.Request_AlliancesFaction, typeof(AlliancesFaction), CmdId.Event_AlliancesFaction),
      new APIRequest(CmdId.Request_Load_Playfield, typeof(PlayfieldLoad), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_ConsoleCommand, typeof(PString), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_GetBannedPlayers, null, CmdId.Event_BannedPlayers),
      new APIRequest(CmdId.Request_InGameMessage_SinglePlayer, typeof(IdMsgPrio), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_InGameMessage_AllPlayers, typeof(IdMsgPrio), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_InGameMessage_Faction, typeof(IdMsgPrio), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_ShowDialog_SinglePlayer, typeof(DialogBoxData), CmdId.Event_DialogButtonIndex),
      new APIRequest(CmdId.Request_Player_GetAndRemoveInventory, typeof(Id), CmdId.Event_Player_GetAndRemoveInventory),
      new APIRequest(CmdId.Request_Playfield_Entity_List, typeof(PString), CmdId.Event_Playfield_Entity_List),
      new APIRequest(CmdId.Request_Entity_Destroy2, typeof(IdPlayfield), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_Export, typeof(EntityExportInfo), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_SetName, typeof(IdPlayfieldName), CmdId.Event_Ok),
    };

    public static List<APIEvent> EventManifest = new List<APIEvent>()
    {
      new APIEvent(CmdId.Event_Playfield_Loaded, typeof(PlayfieldLoad)),
      new APIEvent(CmdId.Event_Playfield_Unloaded, typeof(PlayfieldLoad)),
      new APIEvent(CmdId.Event_Player_Connected, typeof(Id)),
      new APIEvent(CmdId.Event_Player_Disconnected, typeof(Id)),
      new APIEvent(CmdId.Event_Player_ChangedPlayfield, typeof(IdPlayfield)),
      new APIEvent(CmdId.Event_Player_DisconnectedWaiting, typeof(Id)),
      new APIEvent(CmdId.Event_Faction_Changed, typeof(FactionChangeInfo)),
      new APIEvent(CmdId.Event_Statistics, typeof(StatisticsParam)),
      new APIEvent(CmdId.Event_ChatMessage, typeof(ChatInfo)),
      new APIEvent(CmdId.Event_TraderNPCItemSold, typeof(TraderNPCItemSoldInfo)),
      new APIEvent(CmdId.Event_ConsoleCommand, typeof(ConsoleCommandInfo)),
      new APIEvent(CmdId.Event_PdaStateChange, typeof(PdaStateInfo)),
      new APIEvent(CmdId.Event_GameEvent, typeof(GameEventData)),
      new APIEvent(CmdId.Event_AlliancesAll, typeof(AlliancesTable)),
      new APIEvent(CmdId.Event_AlliancesFaction, typeof(AlliancesFaction)),
      new APIEvent(CmdId.Event_BannedPlayers, typeof(IdList)),
      new APIEvent(CmdId.Event_Dedi_Stats, typeof(DediStats)),
      new APIEvent(CmdId.Event_Entity_PosAndRot, typeof(IdPositionRotation)),
      new APIEvent(CmdId.Event_Get_Factions, typeof(FactionInfoList)),
      new APIEvent(CmdId.Event_GlobalStructure_List, typeof(GlobalStructureList)),
      new APIEvent(CmdId.Event_NewEntityId, typeof(Id)),
      new APIEvent(CmdId.Event_Ok, null),
      new APIEvent(CmdId.Event_Player_Credits, typeof(IdCredits)),
      new APIEvent(CmdId.Event_Player_GetAndRemoveInventory, typeof(Inventory)),
      new APIEvent(CmdId.Event_Player_Info, typeof(PlayerInfo)),
      new APIEvent(CmdId.Event_Player_Inventory, typeof(Inventory)),
      new APIEvent(CmdId.Event_Player_ItemExchange, typeof(ItemExchangeInfo)),
      new APIEvent(CmdId.Event_Player_List, typeof(IdList)),
      new APIEvent(CmdId.Event_Playfield_Entity_List, typeof(PlayfieldEntityList)),
      new APIEvent(CmdId.Event_Playfield_List, typeof(PlayfieldList)),
      new APIEvent(CmdId.Event_Playfield_Stats, typeof(PlayfieldStats)),
      new APIEvent(CmdId.Event_Structure_BlockStatistics, typeof(IdStructureBlockInfo)),
      new APIEvent(CmdId.Event_DialogButtonIndex, typeof(IdAndIntValue))
    };

    public static Dictionary<CmdId, APIEvent> APIEventTable = EventManifest.ToDictionary(x => x.CmdId);
    public static Dictionary<CmdId, APIRequest> APIRequestTable = RequestManifest.ToDictionary(x => x.CmdId);
    public static Dictionary<CmdId, APIEvent> APIRequestResponseTable = RequestManifest
      .Select(x => new KeyValuePair<CmdId, APIEvent>(x.CmdId, APIEventTable[x.ResponseCmdId]))
      .ToDictionary(x=>x.Key, x=>x.Value);
  }
}
