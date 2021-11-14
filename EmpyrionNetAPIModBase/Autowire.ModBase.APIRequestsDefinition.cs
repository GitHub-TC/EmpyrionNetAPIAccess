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
          try{
			return await Broker.Request_Playfield_List(timeoutSeconds);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(PlayfieldList)); }
		}
        	
    	 
		public async Task<PlayfieldStats> Request_Playfield_Stats(PString arg) {
			return await Broker.Request_Playfield_Stats(arg);
		}

		public async Task<PlayfieldStats> Request_Playfield_Stats(Timeouts timeoutSeconds, PString arg) {
          try{
			return await Broker.Request_Playfield_Stats(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(PlayfieldStats)); }
		}
        	
    	 
		public async Task<DediStats> Request_Dedi_Stats() {
			return await Broker.Request_Dedi_Stats();
		}

		public async Task<DediStats> Request_Dedi_Stats(Timeouts timeoutSeconds) {
          try{
			return await Broker.Request_Dedi_Stats(timeoutSeconds);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(DediStats)); }
		}
        	
    	 
		public async Task<GlobalStructureList> Request_GlobalStructure_List() {
			return await Broker.Request_GlobalStructure_List();
		}

		public async Task<GlobalStructureList> Request_GlobalStructure_List(Timeouts timeoutSeconds) {
          try{
			return await Broker.Request_GlobalStructure_List(timeoutSeconds);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(GlobalStructureList)); }
		}
        	
    		
		public async Task Request_GlobalStructure_Update(PString arg) {
          try{
			await Broker.Request_GlobalStructure_Update(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_Structure_Touch(Id arg) {
          try{
			await Broker.Request_Structure_Touch(arg);
          } catch(TaskCanceledException) { }
		}
        	
    	 
		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id arg) {
			return await Broker.Request_Structure_BlockStatistics(arg);
		}

		public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Timeouts timeoutSeconds, Id arg) {
          try{
			return await Broker.Request_Structure_BlockStatistics(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdStructureBlockInfo)); }
		}
        	
    	 
		public async Task<PlayerInfo> Request_Player_Info(Id arg) {
			return await Broker.Request_Player_Info(arg);
		}

		public async Task<PlayerInfo> Request_Player_Info(Timeouts timeoutSeconds, Id arg) {
          try{
			return await Broker.Request_Player_Info(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(PlayerInfo)); }
		}
        	
    	 
		public async Task<IdList> Request_Player_List() {
			return await Broker.Request_Player_List();
		}

		public async Task<IdList> Request_Player_List(Timeouts timeoutSeconds) {
          try{
			return await Broker.Request_Player_List(timeoutSeconds);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdList)); }
		}
        	
    	 
		public async Task<Inventory> Request_Player_GetInventory(Id arg) {
			return await Broker.Request_Player_GetInventory(arg);
		}

		public async Task<Inventory> Request_Player_GetInventory(Timeouts timeoutSeconds, Id arg) {
          try{
			return await Broker.Request_Player_GetInventory(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(Inventory)); }
		}
        	
    	 
		public async Task<Inventory> Request_Player_SetInventory(Inventory arg) {
			return await Broker.Request_Player_SetInventory(arg);
		}

		public async Task<Inventory> Request_Player_SetInventory(Timeouts timeoutSeconds, Inventory arg) {
          try{
			return await Broker.Request_Player_SetInventory(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(Inventory)); }
		}
        	
    		
		public async Task Request_Player_AddItem(IdItemStack arg) {
          try{
			await Broker.Request_Player_AddItem(arg);
          } catch(TaskCanceledException) { }
		}
        	
    	 
		public async Task<IdCredits> Request_Player_Credits(Id arg) {
			return await Broker.Request_Player_Credits(arg);
		}

		public async Task<IdCredits> Request_Player_Credits(Timeouts timeoutSeconds, Id arg) {
          try{
			return await Broker.Request_Player_Credits(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdCredits)); }
		}
        	
    	 
		public async Task<IdCredits> Request_Player_SetCredits(IdCredits arg) {
			return await Broker.Request_Player_SetCredits(arg);
		}

		public async Task<IdCredits> Request_Player_SetCredits(Timeouts timeoutSeconds, IdCredits arg) {
          try{
			return await Broker.Request_Player_SetCredits(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdCredits)); }
		}
        	
    	 
		public async Task<IdCredits> Request_Player_AddCredits(IdCredits arg) {
			return await Broker.Request_Player_AddCredits(arg);
		}

		public async Task<IdCredits> Request_Player_AddCredits(Timeouts timeoutSeconds, IdCredits arg) {
          try{
			return await Broker.Request_Player_AddCredits(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdCredits)); }
		}
        	
    		
		public async Task Request_Blueprint_Finish(Id arg) {
          try{
			await Broker.Request_Blueprint_Finish(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_Blueprint_Resources(BlueprintResources arg) {
          try{
			await Broker.Request_Blueprint_Resources(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg) {
          try{
			await Broker.Request_Player_ChangePlayerfield(arg);
          } catch(TaskCanceledException) { }
		}
        	
    	 
		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo arg) {
			return await Broker.Request_Player_ItemExchange(arg);
		}

		public async Task<ItemExchangeInfo> Request_Player_ItemExchange(Timeouts timeoutSeconds, ItemExchangeInfo arg) {
          try{
			return await Broker.Request_Player_ItemExchange(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(ItemExchangeInfo)); }
		}
        	
    		
		public async Task Request_Player_SetPlayerInfo(PlayerInfoSet arg) {
          try{
			await Broker.Request_Player_SetPlayerInfo(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_Entity_Teleport(IdPositionRotation arg) {
          try{
			await Broker.Request_Entity_Teleport(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg) {
          try{
			await Broker.Request_Entity_ChangePlayfield(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_Entity_Destroy(Id arg) {
          try{
			await Broker.Request_Entity_Destroy(arg);
          } catch(TaskCanceledException) { }
		}
        	
    	 
		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Id arg) {
			return await Broker.Request_Entity_PosAndRot(arg);
		}

		public async Task<IdPositionRotation> Request_Entity_PosAndRot(Timeouts timeoutSeconds, Id arg) {
          try{
			return await Broker.Request_Entity_PosAndRot(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdPositionRotation)); }
		}
        	
    		
		public async Task Request_Entity_Spawn(EntitySpawnInfo arg) {
          try{
			await Broker.Request_Entity_Spawn(arg);
          } catch(TaskCanceledException) { }
		}
        	
    	 
		public async Task<FactionInfoList> Request_Get_Factions(Id arg) {
			return await Broker.Request_Get_Factions(arg);
		}

		public async Task<FactionInfoList> Request_Get_Factions(Timeouts timeoutSeconds, Id arg) {
          try{
			return await Broker.Request_Get_Factions(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(FactionInfoList)); }
		}
        	
    	 
		public async Task<Id> Request_NewEntityId() {
			return await Broker.Request_NewEntityId();
		}

		public async Task<Id> Request_NewEntityId(Timeouts timeoutSeconds) {
          try{
			return await Broker.Request_NewEntityId(timeoutSeconds);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(Id)); }
		}
        	
    	 
		public async Task<AlliancesTable> Request_AlliancesAll() {
			return await Broker.Request_AlliancesAll();
		}

		public async Task<AlliancesTable> Request_AlliancesAll(Timeouts timeoutSeconds) {
          try{
			return await Broker.Request_AlliancesAll(timeoutSeconds);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(AlliancesTable)); }
		}
        	
    	 
		public async Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction arg) {
			return await Broker.Request_AlliancesFaction(arg);
		}

		public async Task<AlliancesFaction> Request_AlliancesFaction(Timeouts timeoutSeconds, AlliancesFaction arg) {
          try{
			return await Broker.Request_AlliancesFaction(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(AlliancesFaction)); }
		}
        	
    		
		public async Task Request_Load_Playfield(PlayfieldLoad arg) {
          try{
			await Broker.Request_Load_Playfield(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_ConsoleCommand(PString arg) {
          try{
			await Broker.Request_ConsoleCommand(arg);
          } catch(TaskCanceledException) { }
		}
        	
    	 
		public async Task<IdList> Request_GetBannedPlayers() {
			return await Broker.Request_GetBannedPlayers();
		}

		public async Task<IdList> Request_GetBannedPlayers(Timeouts timeoutSeconds) {
          try{
			return await Broker.Request_GetBannedPlayers(timeoutSeconds);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdList)); }
		}
        	
    		
		public async Task Request_InGameMessage_SinglePlayer(IdMsgPrio arg) {
          try{
			await Broker.Request_InGameMessage_SinglePlayer(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_InGameMessage_AllPlayers(IdMsgPrio arg) {
          try{
			await Broker.Request_InGameMessage_AllPlayers(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_InGameMessage_Faction(IdMsgPrio arg) {
          try{
			await Broker.Request_InGameMessage_Faction(arg);
          } catch(TaskCanceledException) { }
		}
        	
    	 
		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData arg) {
			return await Broker.Request_ShowDialog_SinglePlayer(arg);
		}

		public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(Timeouts timeoutSeconds, DialogBoxData arg) {
          try{
			return await Broker.Request_ShowDialog_SinglePlayer(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdAndIntValue)); }
		}
        	
    	 
		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Id arg) {
			return await Broker.Request_Player_GetAndRemoveInventory(arg);
		}

		public async Task<Inventory> Request_Player_GetAndRemoveInventory(Timeouts timeoutSeconds, Id arg) {
          try{
			return await Broker.Request_Player_GetAndRemoveInventory(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(Inventory)); }
		}
        	
    	 
		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString arg) {
			return await Broker.Request_Playfield_Entity_List(arg);
		}

		public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(Timeouts timeoutSeconds, PString arg) {
          try{
			return await Broker.Request_Playfield_Entity_List(timeoutSeconds, arg);
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(PlayfieldEntityList)); }
		}
        	
    		
		public async Task Request_Entity_Destroy2(IdPlayfield arg) {
          try{
			await Broker.Request_Entity_Destroy2(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_Entity_Export(EntityExportInfo arg) {
          try{
			await Broker.Request_Entity_Export(arg);
          } catch(TaskCanceledException) { }
		}
        	
    		
		public async Task Request_Entity_SetName(IdPlayfieldName arg) {
          try{
			await Broker.Request_Entity_SetName(arg);
          } catch(TaskCanceledException) { }
		}
        	}
}

