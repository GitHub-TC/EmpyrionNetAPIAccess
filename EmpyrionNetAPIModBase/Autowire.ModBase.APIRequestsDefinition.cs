using System;
using Eleon.Modding;
using System.Threading;
using System.Threading.Tasks;

//this file was auto-generated

namespace EmpyrionNetAPIAccess
{
	public abstract partial class EmpyrionModBase 
	{
        /// <summary>
        /// Default Timeout for Empyrion Requests (10s)
        /// </summary>
        public static TimeSpan EmpyrionRequestsDefaultTimeout { get; set; } = new TimeSpan(0, 0, 0, 10);
		
		
		public async Task<PlayfieldList> Request_Playfield_List() {
			return await Broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List);
		}

		public async Task<PlayfieldList> Request_Playfield_List(CancellationToken ct) {
			return await Broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List, ct);
		}
	
		public async Task<PlayfieldStats> Request_Playfield_Stats(PString arg) {
			return await Broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg);
		}

		public async Task<PlayfieldStats> Request_Playfield_Stats(PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg, ct);
		}
	
		public async Task<DediStats> Request_Dedi_Stats() {
			return await Broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats);
		}

		public async Task<DediStats> Request_Dedi_Stats(CancellationToken ct) {
			return await Broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats, ct);
		}
	
		public async Task<GlobalStructureList> Request_GlobalStructure_List() {
			return await Broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List);
		}

		public async Task<GlobalStructureList> Request_GlobalStructure_List(CancellationToken ct) {
			return await Broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List, ct);
		}
	
		public async Task<bool> Request_GlobalStructure_Update(PString arg) {
			return await Broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg);
		}

		public async Task<bool> Request_GlobalStructure_Update(PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg, ct);
		}
	
		public async Task<bool> Request_Structure_Touch(Id arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg);
		}

		public async Task<bool> Request_Structure_Touch(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg, ct);
		}
	
		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id arg) {
			return await Broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg);
		}

		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg, ct);
		}
	
		public async Task<PlayerInfo> Request_Player_Info(Id arg) {
			return await Broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg);
		}

		public async Task<PlayerInfo> Request_Player_Info(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg, ct);
		}
	
		public async Task<IdList> Request_Player_List() {
			return await Broker.SendRequestAsync<IdList>(CmdId.Request_Player_List);
		}

		public async Task<IdList> Request_Player_List(CancellationToken ct) {
			return await Broker.SendRequestAsync<IdList>(CmdId.Request_Player_List, ct);
		}
	
		public async Task<Inventory> Request_Player_GetInventory(Id arg) {
			return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg);
		}

		public async Task<Inventory> Request_Player_GetInventory(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg, ct);
		}
	
		public async Task<Inventory> Request_Player_SetInventory(Inventory arg) {
			return await Broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg);
		}

		public async Task<Inventory> Request_Player_SetInventory(Inventory arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg, ct);
		}
	
		public async Task<bool> Request_Player_AddItem(IdItemStack arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg);
		}

		public async Task<bool> Request_Player_AddItem(IdItemStack arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg, ct);
		}
	
		public async Task<IdCredits> Request_Player_Credits(Id arg) {
			return await Broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg);
		}

		public async Task<IdCredits> Request_Player_Credits(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg, ct);
		}
	
		public async Task<IdCredits> Request_Player_SetCredits(IdCredits arg) {
			return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg);
		}

		public async Task<IdCredits> Request_Player_SetCredits(IdCredits arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg, ct);
		}
	
		public async Task<IdCredits> Request_Player_AddCredits(IdCredits arg) {
			return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg);
		}

		public async Task<IdCredits> Request_Player_AddCredits(IdCredits arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg, ct);
		}
	
		public async Task<bool> Request_Blueprint_Finish(Id arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg);
		}

		public async Task<bool> Request_Blueprint_Finish(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg, ct);
		}
	
		public async Task<bool> Request_Blueprint_Resources(BlueprintResources arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg);
		}

		public async Task<bool> Request_Blueprint_Resources(BlueprintResources arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg, ct);
		}
	
		public async Task<bool> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg);
		}

		public async Task<bool> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg, ct);
		}
	
		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo arg) {
			return await Broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg);
		}

		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg, ct);
		}
	
		public async Task<bool> Request_Player_SetPlayerInfo(PlayerInfoSet arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg);
		}

		public async Task<bool> Request_Player_SetPlayerInfo(PlayerInfoSet arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Teleport(IdPositionRotation arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg);
		}

		public async Task<bool> Request_Entity_Teleport(IdPositionRotation arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg, ct);
		}
	
		public async Task<bool> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg);
		}

		public async Task<bool> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Destroy(Id arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg);
		}

		public async Task<bool> Request_Entity_Destroy(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg, ct);
		}
	
		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Id arg) {
			return await Broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg);
		}

		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Spawn(EntitySpawnInfo arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg);
		}

		public async Task<bool> Request_Entity_Spawn(EntitySpawnInfo arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg, ct);
		}
	
		public async Task<FactionInfoList> Request_Get_Factions(Id arg) {
			return await Broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg);
		}

		public async Task<FactionInfoList> Request_Get_Factions(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg, ct);
		}
	
		public async Task<Id> Request_NewEntityId() {
			return await Broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId);
		}

		public async Task<Id> Request_NewEntityId(CancellationToken ct) {
			return await Broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId, ct);
		}
	
		public async Task<AlliancesTable> Request_AlliancesAll() {
			return await Broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll);
		}

		public async Task<AlliancesTable> Request_AlliancesAll(CancellationToken ct) {
			return await Broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll, ct);
		}
	
		public async Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction arg) {
			return await Broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg);
		}

		public async Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg, ct);
		}
	
		public async Task<bool> Request_Load_Playfield(PlayfieldLoad arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg);
		}

		public async Task<bool> Request_Load_Playfield(PlayfieldLoad arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg, ct);
		}
	
		public async Task<bool> Request_ConsoleCommand(PString arg) {
			return await Broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg);
		}

		public async Task<bool> Request_ConsoleCommand(PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg, ct);
		}
	
		public async Task<IdList> Request_GetBannedPlayers() {
			return await Broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers);
		}

		public async Task<IdList> Request_GetBannedPlayers(CancellationToken ct) {
			return await Broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers, ct);
		}
	
		public async Task<bool> Request_InGameMessage_SinglePlayer(IdMsgPrio arg) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg);
		}

		public async Task<bool> Request_InGameMessage_SinglePlayer(IdMsgPrio arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg, ct);
		}
	
		public async Task<bool> Request_InGameMessage_AllPlayers(IdMsgPrio arg) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg);
		}

		public async Task<bool> Request_InGameMessage_AllPlayers(IdMsgPrio arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg, ct);
		}
	
		public async Task<bool> Request_InGameMessage_Faction(IdMsgPrio arg) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg);
		}

		public async Task<bool> Request_InGameMessage_Faction(IdMsgPrio arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg, ct);
		}
	
		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData arg) {
			return await Broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg);
		}

		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg, ct);
		}
	
		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Id arg) {
			return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg);
		}

		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg, ct);
		}
	
		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString arg) {
			return await Broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg);
		}

		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Destroy2(IdPlayfield arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg);
		}

		public async Task<bool> Request_Entity_Destroy2(IdPlayfield arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Export(EntityExportInfo arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Export, arg);
		}

		public async Task<bool> Request_Entity_Export(EntityExportInfo arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Export, arg, ct);
		}
	
		public async Task<bool> Request_Entity_SetName(IdPlayfieldName arg) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg);
		}

		public async Task<bool> Request_Entity_SetName(IdPlayfieldName arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg, ct);
		}
	}
}

