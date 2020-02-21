using System;
using Eleon.Modding;
using System.Threading;
using System.Threading.Tasks;

//this file was auto-generated

namespace EmpyrionNetAPIAccess
{
	public static class ModGameAPIBrokerExtension 
	{
        /// <summary>
        /// Default Timeout for Empyrion Requests (10s)
        /// </summary>
        public static TimeSpan EmpyrionRequestsDefaultTimeout { get; set; } = new TimeSpan(0, 0, 0, 10);
		
		
		public async static Task<PlayfieldList> Request_Playfield_List(this Broker broker) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List, source.Token);
			}
		}

		public async static Task<PlayfieldList> Request_Playfield_List(this Broker broker, CancellationToken ct) {
				return await broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List, ct);
		}
		
		public async static Task<PlayfieldList> Request_Playfield_List(this Broker broker, Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List, source.Token);
			}
		}

		public async static Task<PlayfieldList> Request_Playfield_List(this Broker broker, Timeouts timeoutSeconds, CancellationToken ct) {
				return await broker.SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List, ct);
		}
	
		public async static Task<PlayfieldStats> Request_Playfield_Stats(this Broker broker, PString arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg, source.Token);
			}
		}

		public async static Task<PlayfieldStats> Request_Playfield_Stats(this Broker broker, PString arg, CancellationToken ct) {
				return await broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg, ct);
		}
		
		public async static Task<PlayfieldStats> Request_Playfield_Stats(this Broker broker, Timeouts timeoutSeconds, PString arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg, source.Token);
			}
		}

		public async static Task<PlayfieldStats> Request_Playfield_Stats(this Broker broker, Timeouts timeoutSeconds, PString arg, CancellationToken ct) {
				return await broker.SendRequestAsync<PString, PlayfieldStats>(CmdId.Request_Playfield_Stats, arg, ct);
		}
	
		public async static Task<DediStats> Request_Dedi_Stats(this Broker broker) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats, source.Token);
			}
		}

		public async static Task<DediStats> Request_Dedi_Stats(this Broker broker, CancellationToken ct) {
				return await broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats, ct);
		}
		
		public async static Task<DediStats> Request_Dedi_Stats(this Broker broker, Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats, source.Token);
			}
		}

		public async static Task<DediStats> Request_Dedi_Stats(this Broker broker, Timeouts timeoutSeconds, CancellationToken ct) {
				return await broker.SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats, ct);
		}
	
		public async static Task<GlobalStructureList> Request_GlobalStructure_List(this Broker broker) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List, source.Token);
			}
		}

		public async static Task<GlobalStructureList> Request_GlobalStructure_List(this Broker broker, CancellationToken ct) {
				return await broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List, ct);
		}
		
		public async static Task<GlobalStructureList> Request_GlobalStructure_List(this Broker broker, Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List, source.Token);
			}
		}

		public async static Task<GlobalStructureList> Request_GlobalStructure_List(this Broker broker, Timeouts timeoutSeconds, CancellationToken ct) {
				return await broker.SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List, ct);
		}
	
		public async static Task<bool> Request_GlobalStructure_Update(this Broker broker, PString arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg, source.Token);
			}
		}

		public async static Task<bool> Request_GlobalStructure_Update(this Broker broker, PString arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg, ct);
		}
		
		public async static Task<bool> Request_GlobalStructure_Update(this Broker broker, Timeouts timeoutSeconds, PString arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg, source.Token);
			}
		}

		public async static Task<bool> Request_GlobalStructure_Update(this Broker broker, Timeouts timeoutSeconds, PString arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_GlobalStructure_Update, arg, ct);
		}
	
		public async static Task<bool> Request_Structure_Touch(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Structure_Touch(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg, ct);
		}
		
		public async static Task<bool> Request_Structure_Touch(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Structure_Touch(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Structure_Touch, arg, ct);
		}
	
		public async static Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg, source.Token);
			}
		}

		public async static Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg, ct);
		}
		
		public async static Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg, source.Token);
			}
		}

		public async static Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, arg, ct);
		}
	
		public async static Task<PlayerInfo> Request_Player_Info(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg, source.Token);
			}
		}

		public async static Task<PlayerInfo> Request_Player_Info(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg, ct);
		}
		
		public async static Task<PlayerInfo> Request_Player_Info(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg, source.Token);
			}
		}

		public async static Task<PlayerInfo> Request_Player_Info(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, PlayerInfo>(CmdId.Request_Player_Info, arg, ct);
		}
	
		public async static Task<IdList> Request_Player_List(this Broker broker) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<IdList>(CmdId.Request_Player_List, source.Token);
			}
		}

		public async static Task<IdList> Request_Player_List(this Broker broker, CancellationToken ct) {
				return await broker.SendRequestAsync<IdList>(CmdId.Request_Player_List, ct);
		}
		
		public async static Task<IdList> Request_Player_List(this Broker broker, Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<IdList>(CmdId.Request_Player_List, source.Token);
			}
		}

		public async static Task<IdList> Request_Player_List(this Broker broker, Timeouts timeoutSeconds, CancellationToken ct) {
				return await broker.SendRequestAsync<IdList>(CmdId.Request_Player_List, ct);
		}
	
		public async static Task<Inventory> Request_Player_GetInventory(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg, source.Token);
			}
		}

		public async static Task<Inventory> Request_Player_GetInventory(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg, ct);
		}
		
		public async static Task<Inventory> Request_Player_GetInventory(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg, source.Token);
			}
		}

		public async static Task<Inventory> Request_Player_GetInventory(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetInventory, arg, ct);
		}
	
		public async static Task<Inventory> Request_Player_SetInventory(this Broker broker, Inventory arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg, source.Token);
			}
		}

		public async static Task<Inventory> Request_Player_SetInventory(this Broker broker, Inventory arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg, ct);
		}
		
		public async static Task<Inventory> Request_Player_SetInventory(this Broker broker, Timeouts timeoutSeconds, Inventory arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg, source.Token);
			}
		}

		public async static Task<Inventory> Request_Player_SetInventory(this Broker broker, Timeouts timeoutSeconds, Inventory arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Inventory, Inventory>(CmdId.Request_Player_SetInventory, arg, ct);
		}
	
		public async static Task<bool> Request_Player_AddItem(this Broker broker, IdItemStack arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Player_AddItem(this Broker broker, IdItemStack arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg, ct);
		}
		
		public async static Task<bool> Request_Player_AddItem(this Broker broker, Timeouts timeoutSeconds, IdItemStack arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Player_AddItem(this Broker broker, Timeouts timeoutSeconds, IdItemStack arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Player_AddItem, arg, ct);
		}
	
		public async static Task<IdCredits> Request_Player_Credits(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg, source.Token);
			}
		}

		public async static Task<IdCredits> Request_Player_Credits(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg, ct);
		}
		
		public async static Task<IdCredits> Request_Player_Credits(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg, source.Token);
			}
		}

		public async static Task<IdCredits> Request_Player_Credits(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, IdCredits>(CmdId.Request_Player_Credits, arg, ct);
		}
	
		public async static Task<IdCredits> Request_Player_SetCredits(this Broker broker, IdCredits arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg, source.Token);
			}
		}

		public async static Task<IdCredits> Request_Player_SetCredits(this Broker broker, IdCredits arg, CancellationToken ct) {
				return await broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg, ct);
		}
		
		public async static Task<IdCredits> Request_Player_SetCredits(this Broker broker, Timeouts timeoutSeconds, IdCredits arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg, source.Token);
			}
		}

		public async static Task<IdCredits> Request_Player_SetCredits(this Broker broker, Timeouts timeoutSeconds, IdCredits arg, CancellationToken ct) {
				return await broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_SetCredits, arg, ct);
		}
	
		public async static Task<IdCredits> Request_Player_AddCredits(this Broker broker, IdCredits arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg, source.Token);
			}
		}

		public async static Task<IdCredits> Request_Player_AddCredits(this Broker broker, IdCredits arg, CancellationToken ct) {
				return await broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg, ct);
		}
		
		public async static Task<IdCredits> Request_Player_AddCredits(this Broker broker, Timeouts timeoutSeconds, IdCredits arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg, source.Token);
			}
		}

		public async static Task<IdCredits> Request_Player_AddCredits(this Broker broker, Timeouts timeoutSeconds, IdCredits arg, CancellationToken ct) {
				return await broker.SendRequestAsync<IdCredits, IdCredits>(CmdId.Request_Player_AddCredits, arg, ct);
		}
	
		public async static Task<bool> Request_Blueprint_Finish(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Blueprint_Finish(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg, ct);
		}
		
		public async static Task<bool> Request_Blueprint_Finish(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Blueprint_Finish(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Blueprint_Finish, arg, ct);
		}
	
		public async static Task<bool> Request_Blueprint_Resources(this Broker broker, BlueprintResources arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Blueprint_Resources(this Broker broker, BlueprintResources arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg, ct);
		}
		
		public async static Task<bool> Request_Blueprint_Resources(this Broker broker, Timeouts timeoutSeconds, BlueprintResources arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Blueprint_Resources(this Broker broker, Timeouts timeoutSeconds, BlueprintResources arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Blueprint_Resources, arg, ct);
		}
	
		public async static Task<bool> Request_Player_ChangePlayerfield(this Broker broker, IdPlayfieldPositionRotation arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Player_ChangePlayerfield(this Broker broker, IdPlayfieldPositionRotation arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg, ct);
		}
		
		public async static Task<bool> Request_Player_ChangePlayerfield(this Broker broker, Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Player_ChangePlayerfield(this Broker broker, Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Player_ChangePlayerfield, arg, ct);
		}
	
		public async static Task<ItemExchangeInfo> Request_Player_ItemExchange(this Broker broker, ItemExchangeInfo arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg, source.Token);
			}
		}

		public async static Task<ItemExchangeInfo> Request_Player_ItemExchange(this Broker broker, ItemExchangeInfo arg, CancellationToken ct) {
				return await broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg, ct);
		}
		
		public async static Task<ItemExchangeInfo> Request_Player_ItemExchange(this Broker broker, Timeouts timeoutSeconds, ItemExchangeInfo arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg, source.Token);
			}
		}

		public async static Task<ItemExchangeInfo> Request_Player_ItemExchange(this Broker broker, Timeouts timeoutSeconds, ItemExchangeInfo arg, CancellationToken ct) {
				return await broker.SendRequestAsync<ItemExchangeInfo, ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, arg, ct);
		}
	
		public async static Task<bool> Request_Player_SetPlayerInfo(this Broker broker, PlayerInfoSet arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Player_SetPlayerInfo(this Broker broker, PlayerInfoSet arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg, ct);
		}
		
		public async static Task<bool> Request_Player_SetPlayerInfo(this Broker broker, Timeouts timeoutSeconds, PlayerInfoSet arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Player_SetPlayerInfo(this Broker broker, Timeouts timeoutSeconds, PlayerInfoSet arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Player_SetPlayerInfo, arg, ct);
		}
	
		public async static Task<bool> Request_Entity_Teleport(this Broker broker, IdPositionRotation arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Teleport(this Broker broker, IdPositionRotation arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg, ct);
		}
		
		public async static Task<bool> Request_Entity_Teleport(this Broker broker, Timeouts timeoutSeconds, IdPositionRotation arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Teleport(this Broker broker, Timeouts timeoutSeconds, IdPositionRotation arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Teleport, arg, ct);
		}
	
		public async static Task<bool> Request_Entity_ChangePlayfield(this Broker broker, IdPlayfieldPositionRotation arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_ChangePlayfield(this Broker broker, IdPlayfieldPositionRotation arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg, ct);
		}
		
		public async static Task<bool> Request_Entity_ChangePlayfield(this Broker broker, Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_ChangePlayfield(this Broker broker, Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_ChangePlayfield, arg, ct);
		}
	
		public async static Task<bool> Request_Entity_Destroy(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Destroy(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg, ct);
		}
		
		public async static Task<bool> Request_Entity_Destroy(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Destroy(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Destroy, arg, ct);
		}
	
		public async static Task<IdPositionRotation> Request_Entity_PosAndRot(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg, source.Token);
			}
		}

		public async static Task<IdPositionRotation> Request_Entity_PosAndRot(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg, ct);
		}
		
		public async static Task<IdPositionRotation> Request_Entity_PosAndRot(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg, source.Token);
			}
		}

		public async static Task<IdPositionRotation> Request_Entity_PosAndRot(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, IdPositionRotation>(CmdId.Request_Entity_PosAndRot, arg, ct);
		}
	
		public async static Task<bool> Request_Entity_Spawn(this Broker broker, EntitySpawnInfo arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Spawn(this Broker broker, EntitySpawnInfo arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg, ct);
		}
		
		public async static Task<bool> Request_Entity_Spawn(this Broker broker, Timeouts timeoutSeconds, EntitySpawnInfo arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Spawn(this Broker broker, Timeouts timeoutSeconds, EntitySpawnInfo arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Spawn, arg, ct);
		}
	
		public async static Task<FactionInfoList> Request_Get_Factions(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg, source.Token);
			}
		}

		public async static Task<FactionInfoList> Request_Get_Factions(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg, ct);
		}
		
		public async static Task<FactionInfoList> Request_Get_Factions(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg, source.Token);
			}
		}

		public async static Task<FactionInfoList> Request_Get_Factions(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, FactionInfoList>(CmdId.Request_Get_Factions, arg, ct);
		}
	
		public async static Task<Id> Request_NewEntityId(this Broker broker) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId, source.Token);
			}
		}

		public async static Task<Id> Request_NewEntityId(this Broker broker, CancellationToken ct) {
				return await broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId, ct);
		}
		
		public async static Task<Id> Request_NewEntityId(this Broker broker, Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId, source.Token);
			}
		}

		public async static Task<Id> Request_NewEntityId(this Broker broker, Timeouts timeoutSeconds, CancellationToken ct) {
				return await broker.SendRequestAsync<Id>(CmdId.Request_NewEntityId, ct);
		}
	
		public async static Task<AlliancesTable> Request_AlliancesAll(this Broker broker) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll, source.Token);
			}
		}

		public async static Task<AlliancesTable> Request_AlliancesAll(this Broker broker, CancellationToken ct) {
				return await broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll, ct);
		}
		
		public async static Task<AlliancesTable> Request_AlliancesAll(this Broker broker, Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll, source.Token);
			}
		}

		public async static Task<AlliancesTable> Request_AlliancesAll(this Broker broker, Timeouts timeoutSeconds, CancellationToken ct) {
				return await broker.SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll, ct);
		}
	
		public async static Task<AlliancesFaction> Request_AlliancesFaction(this Broker broker, AlliancesFaction arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg, source.Token);
			}
		}

		public async static Task<AlliancesFaction> Request_AlliancesFaction(this Broker broker, AlliancesFaction arg, CancellationToken ct) {
				return await broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg, ct);
		}
		
		public async static Task<AlliancesFaction> Request_AlliancesFaction(this Broker broker, Timeouts timeoutSeconds, AlliancesFaction arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg, source.Token);
			}
		}

		public async static Task<AlliancesFaction> Request_AlliancesFaction(this Broker broker, Timeouts timeoutSeconds, AlliancesFaction arg, CancellationToken ct) {
				return await broker.SendRequestAsync<AlliancesFaction, AlliancesFaction>(CmdId.Request_AlliancesFaction, arg, ct);
		}
	
		public async static Task<bool> Request_Load_Playfield(this Broker broker, PlayfieldLoad arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Load_Playfield(this Broker broker, PlayfieldLoad arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg, ct);
		}
		
		public async static Task<bool> Request_Load_Playfield(this Broker broker, Timeouts timeoutSeconds, PlayfieldLoad arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Load_Playfield(this Broker broker, Timeouts timeoutSeconds, PlayfieldLoad arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Load_Playfield, arg, ct);
		}
	
		public async static Task<bool> Request_ConsoleCommand(this Broker broker, PString arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg, source.Token);
			}
		}

		public async static Task<bool> Request_ConsoleCommand(this Broker broker, PString arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg, ct);
		}
		
		public async static Task<bool> Request_ConsoleCommand(this Broker broker, Timeouts timeoutSeconds, PString arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg, source.Token);
			}
		}

		public async static Task<bool> Request_ConsoleCommand(this Broker broker, Timeouts timeoutSeconds, PString arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_ConsoleCommand, arg, ct);
		}
	
		public async static Task<IdList> Request_GetBannedPlayers(this Broker broker) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers, source.Token);
			}
		}

		public async static Task<IdList> Request_GetBannedPlayers(this Broker broker, CancellationToken ct) {
				return await broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers, ct);
		}
		
		public async static Task<IdList> Request_GetBannedPlayers(this Broker broker, Timeouts timeoutSeconds) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers, source.Token);
			}
		}

		public async static Task<IdList> Request_GetBannedPlayers(this Broker broker, Timeouts timeoutSeconds, CancellationToken ct) {
				return await broker.SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers, ct);
		}
	
		public async static Task<bool> Request_InGameMessage_SinglePlayer(this Broker broker, IdMsgPrio arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg, source.Token);
			}
		}

		public async static Task<bool> Request_InGameMessage_SinglePlayer(this Broker broker, IdMsgPrio arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg, ct);
		}
		
		public async static Task<bool> Request_InGameMessage_SinglePlayer(this Broker broker, Timeouts timeoutSeconds, IdMsgPrio arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg, source.Token);
			}
		}

		public async static Task<bool> Request_InGameMessage_SinglePlayer(this Broker broker, Timeouts timeoutSeconds, IdMsgPrio arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_SinglePlayer, arg, ct);
		}
	
		public async static Task<bool> Request_InGameMessage_AllPlayers(this Broker broker, IdMsgPrio arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg, source.Token);
			}
		}

		public async static Task<bool> Request_InGameMessage_AllPlayers(this Broker broker, IdMsgPrio arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg, ct);
		}
		
		public async static Task<bool> Request_InGameMessage_AllPlayers(this Broker broker, Timeouts timeoutSeconds, IdMsgPrio arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg, source.Token);
			}
		}

		public async static Task<bool> Request_InGameMessage_AllPlayers(this Broker broker, Timeouts timeoutSeconds, IdMsgPrio arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_AllPlayers, arg, ct);
		}
	
		public async static Task<bool> Request_InGameMessage_Faction(this Broker broker, IdMsgPrio arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg, source.Token);
			}
		}

		public async static Task<bool> Request_InGameMessage_Faction(this Broker broker, IdMsgPrio arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg, ct);
		}
		
		public async static Task<bool> Request_InGameMessage_Faction(this Broker broker, Timeouts timeoutSeconds, IdMsgPrio arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg, source.Token);
			}
		}

		public async static Task<bool> Request_InGameMessage_Faction(this Broker broker, Timeouts timeoutSeconds, IdMsgPrio arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_InGameMessage_Faction, arg, ct);
		}
	
		public async static Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(this Broker broker, DialogBoxData arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg, source.Token);
			}
		}

		public async static Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(this Broker broker, DialogBoxData arg, CancellationToken ct) {
				return await broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg, ct);
		}
		
		public async static Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(this Broker broker, Timeouts timeoutSeconds, DialogBoxData arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg, source.Token);
			}
		}

		public async static Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(this Broker broker, Timeouts timeoutSeconds, DialogBoxData arg, CancellationToken ct) {
				return await broker.SendRequestAsync<DialogBoxData, IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, arg, ct);
		}
	
		public async static Task<Inventory> Request_Player_GetAndRemoveInventory(this Broker broker, Id arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg, source.Token);
			}
		}

		public async static Task<Inventory> Request_Player_GetAndRemoveInventory(this Broker broker, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg, ct);
		}
		
		public async static Task<Inventory> Request_Player_GetAndRemoveInventory(this Broker broker, Timeouts timeoutSeconds, Id arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg, source.Token);
			}
		}

		public async static Task<Inventory> Request_Player_GetAndRemoveInventory(this Broker broker, Timeouts timeoutSeconds, Id arg, CancellationToken ct) {
				return await broker.SendRequestAsync<Id, Inventory>(CmdId.Request_Player_GetAndRemoveInventory, arg, ct);
		}
	
		public async static Task<PlayfieldEntityList> Request_Playfield_Entity_List(this Broker broker, PString arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg, source.Token);
			}
		}

		public async static Task<PlayfieldEntityList> Request_Playfield_Entity_List(this Broker broker, PString arg, CancellationToken ct) {
				return await broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg, ct);
		}
		
		public async static Task<PlayfieldEntityList> Request_Playfield_Entity_List(this Broker broker, Timeouts timeoutSeconds, PString arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg, source.Token);
			}
		}

		public async static Task<PlayfieldEntityList> Request_Playfield_Entity_List(this Broker broker, Timeouts timeoutSeconds, PString arg, CancellationToken ct) {
				return await broker.SendRequestAsync<PString, PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, arg, ct);
		}
	
		public async static Task<bool> Request_Entity_Destroy2(this Broker broker, IdPlayfield arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Destroy2(this Broker broker, IdPlayfield arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg, ct);
		}
		
		public async static Task<bool> Request_Entity_Destroy2(this Broker broker, Timeouts timeoutSeconds, IdPlayfield arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Destroy2(this Broker broker, Timeouts timeoutSeconds, IdPlayfield arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Destroy2, arg, ct);
		}
	
		public async static Task<bool> Request_Entity_Export(this Broker broker, EntityExportInfo arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Export, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Export(this Broker broker, EntityExportInfo arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Export, arg, ct);
		}
		
		public async static Task<bool> Request_Entity_Export(this Broker broker, Timeouts timeoutSeconds, EntityExportInfo arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_Export, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_Export(this Broker broker, Timeouts timeoutSeconds, EntityExportInfo arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_Export, arg, ct);
		}
	
		public async static Task<bool> Request_Entity_SetName(this Broker broker, IdPlayfieldName arg) {
			using (var source = new CancellationTokenSource(EmpyrionRequestsDefaultTimeout.Milliseconds))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_SetName(this Broker broker, IdPlayfieldName arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg, ct);
		}
		
		public async static Task<bool> Request_Entity_SetName(this Broker broker, Timeouts timeoutSeconds, IdPlayfieldName arg) {
			using (var source = new CancellationTokenSource((int)timeoutSeconds * 1000))
			{
				return await broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg, source.Token);
			}
		}

		public async static Task<bool> Request_Entity_SetName(this Broker broker, Timeouts timeoutSeconds, IdPlayfieldName arg, CancellationToken ct) {
				return await broker.SendRequestAsync(CmdId.Request_Entity_SetName, arg, ct);
		}
	}
}

