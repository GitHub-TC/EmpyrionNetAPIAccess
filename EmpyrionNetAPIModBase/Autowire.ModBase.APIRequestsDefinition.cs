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
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List, source.Token);
			}
		}

		public async Task<PlayfieldList> Request_Playfield_List(CancellationToken ct) {
			return await Broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List, ct);
		}
		
		public async Task<PlayfieldList> Request_Playfield_List(Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List, source.Token);
			}
		}

		public async Task<PlayfieldList> Request_Playfield_List(Timeouts timeoutSeconds, CancellationToken ct) {
			return await Broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List, ct);
		}
	
		public async Task<PlayfieldStats> Request_Playfield_Stats(PString arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg, source.Token);
			}
		}

		public async Task<PlayfieldStats> Request_Playfield_Stats(PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg, ct);
		}
		
		public async Task<PlayfieldStats> Request_Playfield_Stats(Timeouts timeoutSeconds, PString arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg, source.Token);
			}
		}

		public async Task<PlayfieldStats> Request_Playfield_Stats(Timeouts timeoutSeconds, PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg, ct);
		}
	
		public async Task<DediStats> Request_Dedi_Stats() {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats, source.Token);
			}
		}

		public async Task<DediStats> Request_Dedi_Stats(CancellationToken ct) {
			return await Broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats, ct);
		}
		
		public async Task<DediStats> Request_Dedi_Stats(Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats, source.Token);
			}
		}

		public async Task<DediStats> Request_Dedi_Stats(Timeouts timeoutSeconds, CancellationToken ct) {
			return await Broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats, ct);
		}
	
		public async Task<GlobalStructureList> Request_GlobalStructure_List() {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List, source.Token);
			}
		}

		public async Task<GlobalStructureList> Request_GlobalStructure_List(CancellationToken ct) {
			return await Broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List, ct);
		}
		
		public async Task<GlobalStructureList> Request_GlobalStructure_List(Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List, source.Token);
			}
		}

		public async Task<GlobalStructureList> Request_GlobalStructure_List(Timeouts timeoutSeconds, CancellationToken ct) {
			return await Broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List, ct);
		}
	
		public async Task<bool> Request_GlobalStructure_Update(PString arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg, source.Token);
			}
		}

		public async Task<bool> Request_GlobalStructure_Update(PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg, ct);
		}
		
		public async Task<bool> Request_GlobalStructure_Update(Timeouts timeoutSeconds, PString arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg, source.Token);
			}
		}

		public async Task<bool> Request_GlobalStructure_Update(Timeouts timeoutSeconds, PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg, ct);
		}
	
		public async Task<bool> Request_Structure_Touch(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg, source.Token);
			}
		}

		public async Task<bool> Request_Structure_Touch(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg, ct);
		}
		
		public async Task<bool> Request_Structure_Touch(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg, source.Token);
			}
		}

		public async Task<bool> Request_Structure_Touch(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg, ct);
		}
	
		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg, source.Token);
			}
		}

		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg, ct);
		}
		
		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg, source.Token);
			}
		}

		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg, ct);
		}
	
		public async Task<PlayerInfo> Request_Player_Info(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg, source.Token);
			}
		}

		public async Task<PlayerInfo> Request_Player_Info(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg, ct);
		}
		
		public async Task<PlayerInfo> Request_Player_Info(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg, source.Token);
			}
		}

		public async Task<PlayerInfo> Request_Player_Info(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg, ct);
		}
	
		public async Task<IdList> Request_Player_List() {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<IdList>(CmdId.Request_Player_List, source.Token);
			}
		}

		public async Task<IdList> Request_Player_List(CancellationToken ct) {
			return await Broker.SendRequestAsync<IdList>(CmdId.Request_Player_List, ct);
		}
		
		public async Task<IdList> Request_Player_List(Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<IdList>(CmdId.Request_Player_List, source.Token);
			}
		}

		public async Task<IdList> Request_Player_List(Timeouts timeoutSeconds, CancellationToken ct) {
			return await Broker.SendRequestAsync<IdList>(CmdId.Request_Player_List, ct);
		}
	
		public async Task<Inventory> Request_Player_GetInventory(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg, source.Token);
			}
		}

		public async Task<Inventory> Request_Player_GetInventory(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg, ct);
		}
		
		public async Task<Inventory> Request_Player_GetInventory(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg, source.Token);
			}
		}

		public async Task<Inventory> Request_Player_GetInventory(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg, ct);
		}
	
		public async Task<Inventory> Request_Player_SetInventory(Inventory arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg, source.Token);
			}
		}

		public async Task<Inventory> Request_Player_SetInventory(Inventory arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg, ct);
		}
		
		public async Task<Inventory> Request_Player_SetInventory(Timeouts timeoutSeconds, Inventory arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg, source.Token);
			}
		}

		public async Task<Inventory> Request_Player_SetInventory(Timeouts timeoutSeconds, Inventory arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg, ct);
		}
	
		public async Task<bool> Request_Player_AddItem(IdItemStack arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg, source.Token);
			}
		}

		public async Task<bool> Request_Player_AddItem(IdItemStack arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg, ct);
		}
		
		public async Task<bool> Request_Player_AddItem(Timeouts timeoutSeconds, IdItemStack arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg, source.Token);
			}
		}

		public async Task<bool> Request_Player_AddItem(Timeouts timeoutSeconds, IdItemStack arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg, ct);
		}
	
		public async Task<IdCredits> Request_Player_Credits(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg, source.Token);
			}
		}

		public async Task<IdCredits> Request_Player_Credits(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg, ct);
		}
		
		public async Task<IdCredits> Request_Player_Credits(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg, source.Token);
			}
		}

		public async Task<IdCredits> Request_Player_Credits(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg, ct);
		}
	
		public async Task<IdCredits> Request_Player_SetCredits(IdCredits arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg, source.Token);
			}
		}

		public async Task<IdCredits> Request_Player_SetCredits(IdCredits arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg, ct);
		}
		
		public async Task<IdCredits> Request_Player_SetCredits(Timeouts timeoutSeconds, IdCredits arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg, source.Token);
			}
		}

		public async Task<IdCredits> Request_Player_SetCredits(Timeouts timeoutSeconds, IdCredits arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg, ct);
		}
	
		public async Task<IdCredits> Request_Player_AddCredits(IdCredits arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg, source.Token);
			}
		}

		public async Task<IdCredits> Request_Player_AddCredits(IdCredits arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg, ct);
		}
		
		public async Task<IdCredits> Request_Player_AddCredits(Timeouts timeoutSeconds, IdCredits arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg, source.Token);
			}
		}

		public async Task<IdCredits> Request_Player_AddCredits(Timeouts timeoutSeconds, IdCredits arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg, ct);
		}
	
		public async Task<bool> Request_Blueprint_Finish(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg, source.Token);
			}
		}

		public async Task<bool> Request_Blueprint_Finish(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg, ct);
		}
		
		public async Task<bool> Request_Blueprint_Finish(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg, source.Token);
			}
		}

		public async Task<bool> Request_Blueprint_Finish(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg, ct);
		}
	
		public async Task<bool> Request_Blueprint_Resources(BlueprintResources arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg, source.Token);
			}
		}

		public async Task<bool> Request_Blueprint_Resources(BlueprintResources arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg, ct);
		}
		
		public async Task<bool> Request_Blueprint_Resources(Timeouts timeoutSeconds, BlueprintResources arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg, source.Token);
			}
		}

		public async Task<bool> Request_Blueprint_Resources(Timeouts timeoutSeconds, BlueprintResources arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg, ct);
		}
	
		public async Task<bool> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg, source.Token);
			}
		}

		public async Task<bool> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg, ct);
		}
		
		public async Task<bool> Request_Player_ChangePlayerfield(Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg, source.Token);
			}
		}

		public async Task<bool> Request_Player_ChangePlayerfield(Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg, ct);
		}
	
		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg, source.Token);
			}
		}

		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg, ct);
		}
		
		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(Timeouts timeoutSeconds, ItemExchangeInfo arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg, source.Token);
			}
		}

		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(Timeouts timeoutSeconds, ItemExchangeInfo arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg, ct);
		}
	
		public async Task<bool> Request_Player_SetPlayerInfo(PlayerInfoSet arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg, source.Token);
			}
		}

		public async Task<bool> Request_Player_SetPlayerInfo(PlayerInfoSet arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg, ct);
		}
		
		public async Task<bool> Request_Player_SetPlayerInfo(Timeouts timeoutSeconds, PlayerInfoSet arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg, source.Token);
			}
		}

		public async Task<bool> Request_Player_SetPlayerInfo(Timeouts timeoutSeconds, PlayerInfoSet arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Teleport(IdPositionRotation arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Teleport(IdPositionRotation arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg, ct);
		}
		
		public async Task<bool> Request_Entity_Teleport(Timeouts timeoutSeconds, IdPositionRotation arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Teleport(Timeouts timeoutSeconds, IdPositionRotation arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg, ct);
		}
	
		public async Task<bool> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg, ct);
		}
		
		public async Task<bool> Request_Entity_ChangePlayfield(Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_ChangePlayfield(Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Destroy(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Destroy(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg, ct);
		}
		
		public async Task<bool> Request_Entity_Destroy(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Destroy(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg, ct);
		}
	
		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg, source.Token);
			}
		}

		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg, ct);
		}
		
		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg, source.Token);
			}
		}

		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Spawn(EntitySpawnInfo arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Spawn(EntitySpawnInfo arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg, ct);
		}
		
		public async Task<bool> Request_Entity_Spawn(Timeouts timeoutSeconds, EntitySpawnInfo arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Spawn(Timeouts timeoutSeconds, EntitySpawnInfo arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg, ct);
		}
	
		public async Task<FactionInfoList> Request_Get_Factions(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg, source.Token);
			}
		}

		public async Task<FactionInfoList> Request_Get_Factions(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg, ct);
		}
		
		public async Task<FactionInfoList> Request_Get_Factions(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg, source.Token);
			}
		}

		public async Task<FactionInfoList> Request_Get_Factions(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg, ct);
		}
	
		public async Task<Id> Request_NewEntityId() {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId, source.Token);
			}
		}

		public async Task<Id> Request_NewEntityId(CancellationToken ct) {
			return await Broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId, ct);
		}
		
		public async Task<Id> Request_NewEntityId(Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId, source.Token);
			}
		}

		public async Task<Id> Request_NewEntityId(Timeouts timeoutSeconds, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId, ct);
		}
	
		public async Task<AlliancesTable> Request_AlliancesAll() {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll, source.Token);
			}
		}

		public async Task<AlliancesTable> Request_AlliancesAll(CancellationToken ct) {
			return await Broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll, ct);
		}
		
		public async Task<AlliancesTable> Request_AlliancesAll(Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll, source.Token);
			}
		}

		public async Task<AlliancesTable> Request_AlliancesAll(Timeouts timeoutSeconds, CancellationToken ct) {
			return await Broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll, ct);
		}
	
		public async Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg, source.Token);
			}
		}

		public async Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg, ct);
		}
		
		public async Task<AlliancesFaction> Request_AlliancesFaction(Timeouts timeoutSeconds, AlliancesFaction arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg, source.Token);
			}
		}

		public async Task<AlliancesFaction> Request_AlliancesFaction(Timeouts timeoutSeconds, AlliancesFaction arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg, ct);
		}
	
		public async Task<bool> Request_Load_Playfield(PlayfieldLoad arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg, source.Token);
			}
		}

		public async Task<bool> Request_Load_Playfield(PlayfieldLoad arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg, ct);
		}
		
		public async Task<bool> Request_Load_Playfield(Timeouts timeoutSeconds, PlayfieldLoad arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg, source.Token);
			}
		}

		public async Task<bool> Request_Load_Playfield(Timeouts timeoutSeconds, PlayfieldLoad arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg, ct);
		}
	
		public async Task<bool> Request_ConsoleCommand(PString arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg, source.Token);
			}
		}

		public async Task<bool> Request_ConsoleCommand(PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg, ct);
		}
		
		public async Task<bool> Request_ConsoleCommand(Timeouts timeoutSeconds, PString arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg, source.Token);
			}
		}

		public async Task<bool> Request_ConsoleCommand(Timeouts timeoutSeconds, PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg, ct);
		}
	
		public async Task<IdList> Request_GetBannedPlayers() {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers, source.Token);
			}
		}

		public async Task<IdList> Request_GetBannedPlayers(CancellationToken ct) {
			return await Broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers, ct);
		}
		
		public async Task<IdList> Request_GetBannedPlayers(Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers, source.Token);
			}
		}

		public async Task<IdList> Request_GetBannedPlayers(Timeouts timeoutSeconds, CancellationToken ct) {
			return await Broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers, ct);
		}
	
		public async Task<bool> Request_InGameMessage_SinglePlayer(IdMsgPrio arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg, source.Token);
			}
		}

		public async Task<bool> Request_InGameMessage_SinglePlayer(IdMsgPrio arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg, ct);
		}
		
		public async Task<bool> Request_InGameMessage_SinglePlayer(Timeouts timeoutSeconds, IdMsgPrio arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg, source.Token);
			}
		}

		public async Task<bool> Request_InGameMessage_SinglePlayer(Timeouts timeoutSeconds, IdMsgPrio arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg, ct);
		}
	
		public async Task<bool> Request_InGameMessage_AllPlayers(IdMsgPrio arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg, source.Token);
			}
		}

		public async Task<bool> Request_InGameMessage_AllPlayers(IdMsgPrio arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg, ct);
		}
		
		public async Task<bool> Request_InGameMessage_AllPlayers(Timeouts timeoutSeconds, IdMsgPrio arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg, source.Token);
			}
		}

		public async Task<bool> Request_InGameMessage_AllPlayers(Timeouts timeoutSeconds, IdMsgPrio arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg, ct);
		}
	
		public async Task<bool> Request_InGameMessage_Faction(IdMsgPrio arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg, source.Token);
			}
		}

		public async Task<bool> Request_InGameMessage_Faction(IdMsgPrio arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg, ct);
		}
		
		public async Task<bool> Request_InGameMessage_Faction(Timeouts timeoutSeconds, IdMsgPrio arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg, source.Token);
			}
		}

		public async Task<bool> Request_InGameMessage_Faction(Timeouts timeoutSeconds, IdMsgPrio arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg, ct);
		}
	
		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg, source.Token);
			}
		}

		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg, ct);
		}
		
		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(Timeouts timeoutSeconds, DialogBoxData arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg, source.Token);
			}
		}

		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(Timeouts timeoutSeconds, DialogBoxData arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg, ct);
		}
	
		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg, source.Token);
			}
		}

		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg, ct);
		}
		
		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg, source.Token);
			}
		}

		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg, ct);
		}
	
		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg, source.Token);
			}
		}

		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg, ct);
		}
		
		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(Timeouts timeoutSeconds, PString arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg, source.Token);
			}
		}

		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(Timeouts timeoutSeconds, PString arg, CancellationToken ct) {
			return await Broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Destroy2(IdPlayfield arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Destroy2(IdPlayfield arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg, ct);
		}
		
		public async Task<bool> Request_Entity_Destroy2(Timeouts timeoutSeconds, IdPlayfield arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Destroy2(Timeouts timeoutSeconds, IdPlayfield arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg, ct);
		}
	
		public async Task<bool> Request_Entity_Export(EntityExportInfo arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Export, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Export(EntityExportInfo arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Export, arg, ct);
		}
		
		public async Task<bool> Request_Entity_Export(Timeouts timeoutSeconds, EntityExportInfo arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_Export, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_Export(Timeouts timeoutSeconds, EntityExportInfo arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_Export, arg, ct);
		}
	
		public async Task<bool> Request_Entity_SetName(IdPlayfieldName arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_SetName(IdPlayfieldName arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg, ct);
		}
		
		public async Task<bool> Request_Entity_SetName(Timeouts timeoutSeconds, IdPlayfieldName arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await Broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg, source.Token);
			}
		}

		public async Task<bool> Request_Entity_SetName(Timeouts timeoutSeconds, IdPlayfieldName arg, CancellationToken ct) {
			return await Broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg, ct);
		}
	}
}

