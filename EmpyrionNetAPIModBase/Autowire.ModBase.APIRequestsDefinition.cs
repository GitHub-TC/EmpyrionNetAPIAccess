using System;
using Eleon.Modding;
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
			return await Broker.Request_Playfield_List();
		}

		public async Task<PlayfieldList> Request_Playfield_List(Timeouts timeoutSeconds) {
			return await Broker.Request_Playfield_List(timeoutSeconds);
		}

	
		public async Task<PlayfieldStats> Request_Playfield_Stats(PString arg) {
			return await Broker.Request_Playfield_Stats(arg);
		}

		public async Task<PlayfieldStats> Request_Playfield_Stats(Timeouts timeoutSeconds, PString arg) {
			return await Broker.Request_Playfield_Stats(timeoutSeconds, arg);
		}

	
		public async Task<DediStats> Request_Dedi_Stats() {
			return await Broker.Request_Dedi_Stats();
		}

		public async Task<DediStats> Request_Dedi_Stats(Timeouts timeoutSeconds) {
			return await Broker.Request_Dedi_Stats(timeoutSeconds);
		}

	
		public async Task<GlobalStructureList> Request_GlobalStructure_List() {
			return await Broker.Request_GlobalStructure_List();
		}

		public async Task<GlobalStructureList> Request_GlobalStructure_List(Timeouts timeoutSeconds) {
			return await Broker.Request_GlobalStructure_List(timeoutSeconds);
		}

	
		public async Task<bool> Request_GlobalStructure_Update(PString arg) {
			return await Broker.Request_GlobalStructure_Update(arg);
		}

		public async Task<bool> Request_GlobalStructure_Update(Timeouts timeoutSeconds, PString arg) {
			return await Broker.Request_GlobalStructure_Update(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Structure_Touch(Id arg) {
			return await Broker.Request_Structure_Touch(arg);
		}

		public async Task<bool> Request_Structure_Touch(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Structure_Touch(timeoutSeconds, arg);
		}

	
		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id arg) {
			return await Broker.Request_Structure_BlockStatistics(arg);
		}

		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Structure_BlockStatistics(timeoutSeconds, arg);
		}

	
		public async Task<PlayerInfo> Request_Player_Info(Id arg) {
			return await Broker.Request_Player_Info(arg);
		}

		public async Task<PlayerInfo> Request_Player_Info(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Player_Info(timeoutSeconds, arg);
		}

	
		public async Task<IdList> Request_Player_List() {
			return await Broker.Request_Player_List();
		}

		public async Task<IdList> Request_Player_List(Timeouts timeoutSeconds) {
			return await Broker.Request_Player_List(timeoutSeconds);
		}

	
		public async Task<Inventory> Request_Player_GetInventory(Id arg) {
			return await Broker.Request_Player_GetInventory(arg);
		}

		public async Task<Inventory> Request_Player_GetInventory(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Player_GetInventory(timeoutSeconds, arg);
		}

	
		public async Task<Inventory> Request_Player_SetInventory(Inventory arg) {
			return await Broker.Request_Player_SetInventory(arg);
		}

		public async Task<Inventory> Request_Player_SetInventory(Timeouts timeoutSeconds, Inventory arg) {
			return await Broker.Request_Player_SetInventory(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Player_AddItem(IdItemStack arg) {
			return await Broker.Request_Player_AddItem(arg);
		}

		public async Task<bool> Request_Player_AddItem(Timeouts timeoutSeconds, IdItemStack arg) {
			return await Broker.Request_Player_AddItem(timeoutSeconds, arg);
		}

	
		public async Task<IdCredits> Request_Player_Credits(Id arg) {
			return await Broker.Request_Player_Credits(arg);
		}

		public async Task<IdCredits> Request_Player_Credits(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Player_Credits(timeoutSeconds, arg);
		}

	
		public async Task<IdCredits> Request_Player_SetCredits(IdCredits arg) {
			return await Broker.Request_Player_SetCredits(arg);
		}

		public async Task<IdCredits> Request_Player_SetCredits(Timeouts timeoutSeconds, IdCredits arg) {
			return await Broker.Request_Player_SetCredits(timeoutSeconds, arg);
		}

	
		public async Task<IdCredits> Request_Player_AddCredits(IdCredits arg) {
			return await Broker.Request_Player_AddCredits(arg);
		}

		public async Task<IdCredits> Request_Player_AddCredits(Timeouts timeoutSeconds, IdCredits arg) {
			return await Broker.Request_Player_AddCredits(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Blueprint_Finish(Id arg) {
			return await Broker.Request_Blueprint_Finish(arg);
		}

		public async Task<bool> Request_Blueprint_Finish(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Blueprint_Finish(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Blueprint_Resources(BlueprintResources arg) {
			return await Broker.Request_Blueprint_Resources(arg);
		}

		public async Task<bool> Request_Blueprint_Resources(Timeouts timeoutSeconds, BlueprintResources arg) {
			return await Broker.Request_Blueprint_Resources(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg) {
			return await Broker.Request_Player_ChangePlayerfield(arg);
		}

		public async Task<bool> Request_Player_ChangePlayerfield(Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg) {
			return await Broker.Request_Player_ChangePlayerfield(timeoutSeconds, arg);
		}

	
		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo arg) {
			return await Broker.Request_Player_ItemExchange(arg);
		}

		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(Timeouts timeoutSeconds, ItemExchangeInfo arg) {
			return await Broker.Request_Player_ItemExchange(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Player_SetPlayerInfo(PlayerInfoSet arg) {
			return await Broker.Request_Player_SetPlayerInfo(arg);
		}

		public async Task<bool> Request_Player_SetPlayerInfo(Timeouts timeoutSeconds, PlayerInfoSet arg) {
			return await Broker.Request_Player_SetPlayerInfo(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Entity_Teleport(IdPositionRotation arg) {
			return await Broker.Request_Entity_Teleport(arg);
		}

		public async Task<bool> Request_Entity_Teleport(Timeouts timeoutSeconds, IdPositionRotation arg) {
			return await Broker.Request_Entity_Teleport(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg) {
			return await Broker.Request_Entity_ChangePlayfield(arg);
		}

		public async Task<bool> Request_Entity_ChangePlayfield(Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg) {
			return await Broker.Request_Entity_ChangePlayfield(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Entity_Destroy(Id arg) {
			return await Broker.Request_Entity_Destroy(arg);
		}

		public async Task<bool> Request_Entity_Destroy(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Entity_Destroy(timeoutSeconds, arg);
		}

	
		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Id arg) {
			return await Broker.Request_Entity_PosAndRot(arg);
		}

		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Entity_PosAndRot(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Entity_Spawn(EntitySpawnInfo arg) {
			return await Broker.Request_Entity_Spawn(arg);
		}

		public async Task<bool> Request_Entity_Spawn(Timeouts timeoutSeconds, EntitySpawnInfo arg) {
			return await Broker.Request_Entity_Spawn(timeoutSeconds, arg);
		}

	
		public async Task<FactionInfoList> Request_Get_Factions(Id arg) {
			return await Broker.Request_Get_Factions(arg);
		}

		public async Task<FactionInfoList> Request_Get_Factions(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Get_Factions(timeoutSeconds, arg);
		}

	
		public async Task<Id> Request_NewEntityId() {
			return await Broker.Request_NewEntityId();
		}

		public async Task<Id> Request_NewEntityId(Timeouts timeoutSeconds) {
			return await Broker.Request_NewEntityId(timeoutSeconds);
		}

	
		public async Task<AlliancesTable> Request_AlliancesAll() {
			return await Broker.Request_AlliancesAll();
		}

		public async Task<AlliancesTable> Request_AlliancesAll(Timeouts timeoutSeconds) {
			return await Broker.Request_AlliancesAll(timeoutSeconds);
		}

	
		public async Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction arg) {
			return await Broker.Request_AlliancesFaction(arg);
		}

		public async Task<AlliancesFaction> Request_AlliancesFaction(Timeouts timeoutSeconds, AlliancesFaction arg) {
			return await Broker.Request_AlliancesFaction(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Load_Playfield(PlayfieldLoad arg) {
			return await Broker.Request_Load_Playfield(arg);
		}

		public async Task<bool> Request_Load_Playfield(Timeouts timeoutSeconds, PlayfieldLoad arg) {
			return await Broker.Request_Load_Playfield(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_ConsoleCommand(PString arg) {
			return await Broker.Request_ConsoleCommand(arg);
		}

		public async Task<bool> Request_ConsoleCommand(Timeouts timeoutSeconds, PString arg) {
			return await Broker.Request_ConsoleCommand(timeoutSeconds, arg);
		}

	
		public async Task<IdList> Request_GetBannedPlayers() {
			return await Broker.Request_GetBannedPlayers();
		}

		public async Task<IdList> Request_GetBannedPlayers(Timeouts timeoutSeconds) {
			return await Broker.Request_GetBannedPlayers(timeoutSeconds);
		}

	
		public async Task<bool> Request_InGameMessage_SinglePlayer(IdMsgPrio arg) {
			return await Broker.Request_InGameMessage_SinglePlayer(arg);
		}

		public async Task<bool> Request_InGameMessage_SinglePlayer(Timeouts timeoutSeconds, IdMsgPrio arg) {
			return await Broker.Request_InGameMessage_SinglePlayer(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_InGameMessage_AllPlayers(IdMsgPrio arg) {
			return await Broker.Request_InGameMessage_AllPlayers(arg);
		}

		public async Task<bool> Request_InGameMessage_AllPlayers(Timeouts timeoutSeconds, IdMsgPrio arg) {
			return await Broker.Request_InGameMessage_AllPlayers(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_InGameMessage_Faction(IdMsgPrio arg) {
			return await Broker.Request_InGameMessage_Faction(arg);
		}

		public async Task<bool> Request_InGameMessage_Faction(Timeouts timeoutSeconds, IdMsgPrio arg) {
			return await Broker.Request_InGameMessage_Faction(timeoutSeconds, arg);
		}

	
		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData arg) {
			return await Broker.Request_ShowDialog_SinglePlayer(arg);
		}

		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(Timeouts timeoutSeconds, DialogBoxData arg) {
			return await Broker.Request_ShowDialog_SinglePlayer(timeoutSeconds, arg);
		}

	
		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Id arg) {
			return await Broker.Request_Player_GetAndRemoveInventory(arg);
		}

		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Timeouts timeoutSeconds, Id arg) {
			return await Broker.Request_Player_GetAndRemoveInventory(timeoutSeconds, arg);
		}

	
		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString arg) {
			return await Broker.Request_Playfield_Entity_List(arg);
		}

		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(Timeouts timeoutSeconds, PString arg) {
			return await Broker.Request_Playfield_Entity_List(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Entity_Destroy2(IdPlayfield arg) {
			return await Broker.Request_Entity_Destroy2(arg);
		}

		public async Task<bool> Request_Entity_Destroy2(Timeouts timeoutSeconds, IdPlayfield arg) {
			return await Broker.Request_Entity_Destroy2(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Entity_Export(EntityExportInfo arg) {
			return await Broker.Request_Entity_Export(arg);
		}

		public async Task<bool> Request_Entity_Export(Timeouts timeoutSeconds, EntityExportInfo arg) {
			return await Broker.Request_Entity_Export(timeoutSeconds, arg);
		}

	
		public async Task<bool> Request_Entity_SetName(IdPlayfieldName arg) {
			return await Broker.Request_Entity_SetName(arg);
		}

		public async Task<bool> Request_Entity_SetName(Timeouts timeoutSeconds, IdPlayfieldName arg) {
			return await Broker.Request_Entity_SetName(timeoutSeconds, arg);
		}

	}
}

