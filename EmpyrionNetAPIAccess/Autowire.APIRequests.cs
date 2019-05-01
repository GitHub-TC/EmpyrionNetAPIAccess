 
using Eleon.Modding;
using System.Threading.Tasks;

//this file was auto-generated

namespace EmpyrionNetAPIAccess
{
  public partial class EmpyrionModBase {
      		
    public async Task<PlayfieldList> Request_Playfield_List(){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<PlayfieldList>(CmdId.Request_Playfield_List,null));
    }

    public async Task<PlayfieldList> Request_Playfield_List(int timeoutSeconds){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<PlayfieldList>(CmdId.Request_Playfield_List,null));
    }
      		
    public async Task<PlayfieldStats> Request_Playfield_Stats(PString arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<PlayfieldStats>(CmdId.Request_Playfield_Stats,arg));
    }

    public async Task<PlayfieldStats> Request_Playfield_Stats(int timeoutSeconds, PString arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<PlayfieldStats>(CmdId.Request_Playfield_Stats,arg));
    }
      		
    public async Task<DediStats> Request_Dedi_Stats(){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<DediStats>(CmdId.Request_Dedi_Stats,null));
    }

    public async Task<DediStats> Request_Dedi_Stats(int timeoutSeconds){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<DediStats>(CmdId.Request_Dedi_Stats,null));
    }
      		
    public async Task<GlobalStructureList> Request_GlobalStructure_List(){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<GlobalStructureList>(CmdId.Request_GlobalStructure_List,null));
    }

    public async Task<GlobalStructureList> Request_GlobalStructure_List(int timeoutSeconds){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<GlobalStructureList>(CmdId.Request_GlobalStructure_List,null));
    }
      		
    public async Task Request_GlobalStructure_Update(PString arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_GlobalStructure_Update,arg));
    }

    public async Task Request_GlobalStructure_Update(int timeoutSeconds, PString arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_GlobalStructure_Update,arg));
    }
      		
    public async Task Request_Structure_Touch(Id arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Structure_Touch,arg));
    }

    public async Task Request_Structure_Touch(int timeoutSeconds, Id arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Structure_Touch,arg));
    }
      		
    public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics,arg));
    }

    public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(int timeoutSeconds, Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics,arg));
    }
      		
    public async Task<PlayerInfo> Request_Player_Info(Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<PlayerInfo>(CmdId.Request_Player_Info,arg));
    }

    public async Task<PlayerInfo> Request_Player_Info(int timeoutSeconds, Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<PlayerInfo>(CmdId.Request_Player_Info,arg));
    }
      		
    public async Task<IdList> Request_Player_List(){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdList>(CmdId.Request_Player_List,null));
    }

    public async Task<IdList> Request_Player_List(int timeoutSeconds){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdList>(CmdId.Request_Player_List,null));
    }
      		
    public async Task<Inventory> Request_Player_GetInventory(Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<Inventory>(CmdId.Request_Player_GetInventory,arg));
    }

    public async Task<Inventory> Request_Player_GetInventory(int timeoutSeconds, Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<Inventory>(CmdId.Request_Player_GetInventory,arg));
    }
      		
    public async Task<Inventory> Request_Player_SetInventory(Inventory arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<Inventory>(CmdId.Request_Player_SetInventory,arg));
    }

    public async Task<Inventory> Request_Player_SetInventory(int timeoutSeconds, Inventory arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<Inventory>(CmdId.Request_Player_SetInventory,arg));
    }
      		
    public async Task Request_Player_AddItem(IdItemStack arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Player_AddItem,arg));
    }

    public async Task Request_Player_AddItem(int timeoutSeconds, IdItemStack arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Player_AddItem,arg));
    }
      		
    public async Task<IdCredits> Request_Player_Credits(Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdCredits>(CmdId.Request_Player_Credits,arg));
    }

    public async Task<IdCredits> Request_Player_Credits(int timeoutSeconds, Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdCredits>(CmdId.Request_Player_Credits,arg));
    }
      		
    public async Task<IdCredits> Request_Player_SetCredits(IdCredits arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdCredits>(CmdId.Request_Player_SetCredits,arg));
    }

    public async Task<IdCredits> Request_Player_SetCredits(int timeoutSeconds, IdCredits arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdCredits>(CmdId.Request_Player_SetCredits,arg));
    }
      		
    public async Task<IdCredits> Request_Player_AddCredits(IdCredits arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdCredits>(CmdId.Request_Player_AddCredits,arg));
    }

    public async Task<IdCredits> Request_Player_AddCredits(int timeoutSeconds, IdCredits arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdCredits>(CmdId.Request_Player_AddCredits,arg));
    }
      		
    public async Task Request_Blueprint_Finish(Id arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Blueprint_Finish,arg));
    }

    public async Task Request_Blueprint_Finish(int timeoutSeconds, Id arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Blueprint_Finish,arg));
    }
      		
    public async Task Request_Blueprint_Resources(BlueprintResources arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Blueprint_Resources,arg));
    }

    public async Task Request_Blueprint_Resources(int timeoutSeconds, BlueprintResources arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Blueprint_Resources,arg));
    }
      		
    public async Task Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Player_ChangePlayerfield,arg));
    }

    public async Task Request_Player_ChangePlayerfield(int timeoutSeconds, IdPlayfieldPositionRotation arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Player_ChangePlayerfield,arg));
    }
      		
    public async Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<ItemExchangeInfo>(CmdId.Request_Player_ItemExchange,arg));
    }

    public async Task<ItemExchangeInfo> Request_Player_ItemExchange(int timeoutSeconds, ItemExchangeInfo arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<ItemExchangeInfo>(CmdId.Request_Player_ItemExchange,arg));
    }
      		
    public async Task Request_Player_SetPlayerInfo(PlayerInfoSet arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Player_SetPlayerInfo,arg));
    }

    public async Task Request_Player_SetPlayerInfo(int timeoutSeconds, PlayerInfoSet arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Player_SetPlayerInfo,arg));
    }
      		
    public async Task Request_Entity_Teleport(IdPositionRotation arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Entity_Teleport,arg));
    }

    public async Task Request_Entity_Teleport(int timeoutSeconds, IdPositionRotation arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Entity_Teleport,arg));
    }
      		
    public async Task Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Entity_ChangePlayfield,arg));
    }

    public async Task Request_Entity_ChangePlayfield(int timeoutSeconds, IdPlayfieldPositionRotation arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Entity_ChangePlayfield,arg));
    }
      		
    public async Task Request_Entity_Destroy(Id arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Entity_Destroy,arg));
    }

    public async Task Request_Entity_Destroy(int timeoutSeconds, Id arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Entity_Destroy,arg));
    }
      		
    public async Task<IdPositionRotation> Request_Entity_PosAndRot(Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdPositionRotation>(CmdId.Request_Entity_PosAndRot,arg));
    }

    public async Task<IdPositionRotation> Request_Entity_PosAndRot(int timeoutSeconds, Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdPositionRotation>(CmdId.Request_Entity_PosAndRot,arg));
    }
      		
    public async Task Request_Entity_Spawn(EntitySpawnInfo arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Entity_Spawn,arg));
    }

    public async Task Request_Entity_Spawn(int timeoutSeconds, EntitySpawnInfo arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Entity_Spawn,arg));
    }
      		
    public async Task<FactionInfoList> Request_Get_Factions(Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<FactionInfoList>(CmdId.Request_Get_Factions,arg));
    }

    public async Task<FactionInfoList> Request_Get_Factions(int timeoutSeconds, Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<FactionInfoList>(CmdId.Request_Get_Factions,arg));
    }
      		
    public async Task<Id> Request_NewEntityId(){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<Id>(CmdId.Request_NewEntityId,null));
    }

    public async Task<Id> Request_NewEntityId(int timeoutSeconds){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<Id>(CmdId.Request_NewEntityId,null));
    }
      		
    public async Task<AlliancesTable> Request_AlliancesAll(){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<AlliancesTable>(CmdId.Request_AlliancesAll,null));
    }

    public async Task<AlliancesTable> Request_AlliancesAll(int timeoutSeconds){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<AlliancesTable>(CmdId.Request_AlliancesAll,null));
    }
      		
    public async Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<AlliancesFaction>(CmdId.Request_AlliancesFaction,arg));
    }

    public async Task<AlliancesFaction> Request_AlliancesFaction(int timeoutSeconds, AlliancesFaction arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<AlliancesFaction>(CmdId.Request_AlliancesFaction,arg));
    }
      		
    public async Task Request_Load_Playfield(PlayfieldLoad arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Load_Playfield,arg));
    }

    public async Task Request_Load_Playfield(int timeoutSeconds, PlayfieldLoad arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Load_Playfield,arg));
    }
      		
    public async Task Request_ConsoleCommand(PString arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_ConsoleCommand,arg));
    }

    public async Task Request_ConsoleCommand(int timeoutSeconds, PString arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_ConsoleCommand,arg));
    }
      		
    public async Task<IdList> Request_GetBannedPlayers(){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdList>(CmdId.Request_GetBannedPlayers,null));
    }

    public async Task<IdList> Request_GetBannedPlayers(int timeoutSeconds){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdList>(CmdId.Request_GetBannedPlayers,null));
    }
      		
    public async Task Request_InGameMessage_SinglePlayer(IdMsgPrio arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_InGameMessage_SinglePlayer,arg));
    }

    public async Task Request_InGameMessage_SinglePlayer(int timeoutSeconds, IdMsgPrio arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_InGameMessage_SinglePlayer,arg));
    }
      		
    public async Task Request_InGameMessage_AllPlayers(IdMsgPrio arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_InGameMessage_AllPlayers,arg));
    }

    public async Task Request_InGameMessage_AllPlayers(int timeoutSeconds, IdMsgPrio arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_InGameMessage_AllPlayers,arg));
    }
      		
    public async Task Request_InGameMessage_Faction(IdMsgPrio arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_InGameMessage_Faction,arg));
    }

    public async Task Request_InGameMessage_Faction(int timeoutSeconds, IdMsgPrio arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_InGameMessage_Faction,arg));
    }
      		
    public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer,arg));
    }

    public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(int timeoutSeconds, DialogBoxData arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer,arg));
    }
      		
    public async Task<Inventory> Request_Player_GetAndRemoveInventory(Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<Inventory>(CmdId.Request_Player_GetAndRemoveInventory,arg));
    }

    public async Task<Inventory> Request_Player_GetAndRemoveInventory(int timeoutSeconds, Id arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<Inventory>(CmdId.Request_Player_GetAndRemoveInventory,arg));
    }
      		
    public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List,arg));
    }

    public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(int timeoutSeconds, PString arg){     
      return await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest<PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List,arg));
    }
      		
    public async Task Request_Entity_Destroy2(IdPlayfield arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Entity_Destroy2,arg));
    }

    public async Task Request_Entity_Destroy2(int timeoutSeconds, IdPlayfield arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Entity_Destroy2,arg));
    }
      		
    public async Task Request_Entity_Export(EntityExportInfo arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Entity_Export,arg));
    }

    public async Task Request_Entity_Export(int timeoutSeconds, EntityExportInfo arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Entity_Export,arg));
    }
      		
    public async Task Request_Entity_SetName(IdPlayfieldName arg){     
      await TaskWait.For(EmpyrionRequestsDefaultTimeout, Broker.SendRequest(CmdId.Request_Entity_SetName,arg));
    }

    public async Task Request_Entity_SetName(int timeoutSeconds, IdPlayfieldName arg){     
      await TaskWait.For(timeoutSeconds, Broker.SendRequest(CmdId.Request_Entity_SetName,arg));
    }
    }
}

