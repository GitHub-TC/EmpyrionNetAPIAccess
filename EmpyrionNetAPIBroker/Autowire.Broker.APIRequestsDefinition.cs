using System;
using Eleon.Modding;
using System.Threading;
using System.Threading.Tasks;
using EmpyrionNetAPITools.Extensions;

//this file was auto-generated

namespace EmpyrionNetAPIAccess
{
	public partial class Broker
	{
        /// <summary>
        /// Default Timeout for Empyrion Requests (10s)
        /// </summary>
        public static TimeSpan EmpyrionRequestsDefaultTimeout { get; set; } = new TimeSpan(0, 0, 0, 10);
		
          	 
        public async Task<PlayfieldList> Request_Playfield_List(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List,null));
        }

        public async Task<PlayfieldList> Request_Playfield_List(Timeouts timeoutSeconds){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List,null));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(PlayfieldList)); }
        }
                  	 
        public async Task<PlayfieldStats> Request_Playfield_Stats(PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayfieldStats>(CmdId.Request_Playfield_Stats,arg));
        }

        public async Task<PlayfieldStats> Request_Playfield_Stats(Timeouts timeoutSeconds, PString arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<PlayfieldStats>(CmdId.Request_Playfield_Stats,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(PlayfieldStats)); }
        }
                  	 
        public async Task<DediStats> Request_Dedi_Stats(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats,null));
        }

        public async Task<DediStats> Request_Dedi_Stats(Timeouts timeoutSeconds){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats,null));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(DediStats)); }
        }
                  	 
        public async Task<GlobalStructureList> Request_GlobalStructure_List(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List,null));
        }

        public async Task<GlobalStructureList> Request_GlobalStructure_List(Timeouts timeoutSeconds){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List,null));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(GlobalStructureList)); }
        }
                  		
        public async Task Request_GlobalStructure_Update(PString arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_GlobalStructure_Update,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_Structure_Touch(Id arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Structure_Touch,arg));
          } catch(TaskCanceledException) { }
        }
                  	 
        public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics,arg));
        }

        public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Timeouts timeoutSeconds, Id arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdStructureBlockInfo)); }
        }
                  	 
        public async Task<PlayerInfo> Request_Player_Info(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayerInfo>(CmdId.Request_Player_Info,arg));
        }

        public async Task<PlayerInfo> Request_Player_Info(Timeouts timeoutSeconds, Id arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<PlayerInfo>(CmdId.Request_Player_Info,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(PlayerInfo)); }
        }
                  	 
        public async Task<IdList> Request_Player_List(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdList>(CmdId.Request_Player_List,null));
        }

        public async Task<IdList> Request_Player_List(Timeouts timeoutSeconds){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<IdList>(CmdId.Request_Player_List,null));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdList)); }
        }
                  	 
        public async Task<Inventory> Request_Player_GetInventory(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Inventory>(CmdId.Request_Player_GetInventory,arg));
        }

        public async Task<Inventory> Request_Player_GetInventory(Timeouts timeoutSeconds, Id arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<Inventory>(CmdId.Request_Player_GetInventory,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(Inventory)); }
        }
                  	 
        public async Task<Inventory> Request_Player_SetInventory(Inventory arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Inventory>(CmdId.Request_Player_SetInventory,arg));
        }

        public async Task<Inventory> Request_Player_SetInventory(Timeouts timeoutSeconds, Inventory arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<Inventory>(CmdId.Request_Player_SetInventory,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(Inventory)); }
        }
                  		
        public async Task Request_Player_AddItem(IdItemStack arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Player_AddItem,arg));
          } catch(TaskCanceledException) { }
        }
                  	 
        public async Task<IdCredits> Request_Player_Credits(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdCredits>(CmdId.Request_Player_Credits,arg));
        }

        public async Task<IdCredits> Request_Player_Credits(Timeouts timeoutSeconds, Id arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<IdCredits>(CmdId.Request_Player_Credits,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdCredits)); }
        }
                  	 
        public async Task<IdCredits> Request_Player_SetCredits(IdCredits arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdCredits>(CmdId.Request_Player_SetCredits,arg));
        }

        public async Task<IdCredits> Request_Player_SetCredits(Timeouts timeoutSeconds, IdCredits arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<IdCredits>(CmdId.Request_Player_SetCredits,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdCredits)); }
        }
                  	 
        public async Task<IdCredits> Request_Player_AddCredits(IdCredits arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdCredits>(CmdId.Request_Player_AddCredits,arg));
        }

        public async Task<IdCredits> Request_Player_AddCredits(Timeouts timeoutSeconds, IdCredits arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<IdCredits>(CmdId.Request_Player_AddCredits,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdCredits)); }
        }
                  		
        public async Task Request_Blueprint_Finish(Id arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Blueprint_Finish,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_Blueprint_Resources(BlueprintResources arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Blueprint_Resources,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Player_ChangePlayerfield,arg));
          } catch(TaskCanceledException) { }
        }
                  	 
        public async Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<ItemExchangeInfo>(CmdId.Request_Player_ItemExchange,arg));
        }

        public async Task<ItemExchangeInfo> Request_Player_ItemExchange(Timeouts timeoutSeconds, ItemExchangeInfo arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<ItemExchangeInfo>(CmdId.Request_Player_ItemExchange,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(ItemExchangeInfo)); }
        }
                  		
        public async Task Request_Player_SetPlayerInfo(PlayerInfoSet arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Player_SetPlayerInfo,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_Entity_Teleport(IdPositionRotation arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Entity_Teleport,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Entity_ChangePlayfield,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_Entity_Destroy(Id arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Entity_Destroy,arg));
          } catch(TaskCanceledException) { }
        }
                  	 
        public async Task<IdPositionRotation> Request_Entity_PosAndRot(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdPositionRotation>(CmdId.Request_Entity_PosAndRot,arg));
        }

        public async Task<IdPositionRotation> Request_Entity_PosAndRot(Timeouts timeoutSeconds, Id arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<IdPositionRotation>(CmdId.Request_Entity_PosAndRot,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdPositionRotation)); }
        }
                  		
        public async Task Request_Entity_Spawn(EntitySpawnInfo arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Entity_Spawn,arg));
          } catch(TaskCanceledException) { }
        }
                  	 
        public async Task<FactionInfoList> Request_Get_Factions(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<FactionInfoList>(CmdId.Request_Get_Factions,arg));
        }

        public async Task<FactionInfoList> Request_Get_Factions(Timeouts timeoutSeconds, Id arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<FactionInfoList>(CmdId.Request_Get_Factions,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(FactionInfoList)); }
        }
                  	 
        public async Task<Id> Request_NewEntityId(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Id>(CmdId.Request_NewEntityId,null));
        }

        public async Task<Id> Request_NewEntityId(Timeouts timeoutSeconds){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<Id>(CmdId.Request_NewEntityId,null));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(Id)); }
        }
                  	 
        public async Task<AlliancesTable> Request_AlliancesAll(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll,null));
        }

        public async Task<AlliancesTable> Request_AlliancesAll(Timeouts timeoutSeconds){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll,null));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(AlliancesTable)); }
        }
                  	 
        public async Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<AlliancesFaction>(CmdId.Request_AlliancesFaction,arg));
        }

        public async Task<AlliancesFaction> Request_AlliancesFaction(Timeouts timeoutSeconds, AlliancesFaction arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<AlliancesFaction>(CmdId.Request_AlliancesFaction,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(AlliancesFaction)); }
        }
                  		
        public async Task Request_Load_Playfield(PlayfieldLoad arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Load_Playfield,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_ConsoleCommand(PString arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_ConsoleCommand,arg));
          } catch(TaskCanceledException) { }
        }
                  	 
        public async Task<IdList> Request_GetBannedPlayers(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers,null));
        }

        public async Task<IdList> Request_GetBannedPlayers(Timeouts timeoutSeconds){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers,null));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdList)); }
        }
                  		
        public async Task Request_InGameMessage_SinglePlayer(IdMsgPrio arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_InGameMessage_SinglePlayer,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_InGameMessage_AllPlayers(IdMsgPrio arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_InGameMessage_AllPlayers,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_InGameMessage_Faction(IdMsgPrio arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_InGameMessage_Faction,arg));
          } catch(TaskCanceledException) { }
        }
                  	 
        public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer,arg));
        }

        public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(Timeouts timeoutSeconds, DialogBoxData arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(IdAndIntValue)); }
        }
                  	 
        public async Task<Inventory> Request_Player_GetAndRemoveInventory(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Inventory>(CmdId.Request_Player_GetAndRemoveInventory,arg));
        }

        public async Task<Inventory> Request_Player_GetAndRemoveInventory(Timeouts timeoutSeconds, Id arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<Inventory>(CmdId.Request_Player_GetAndRemoveInventory,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(Inventory)); }
        }
                  	 
        public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List,arg));
        }

        public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(Timeouts timeoutSeconds, PString arg){     
          try{
          return await TaskTools.For(new TimeSpan(0,0,(int)timeoutSeconds), SendRequestAsync<PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List,arg));
          } catch(TaskCanceledException) { if((int)timeoutSeconds > 0) throw; else return await Task.FromResult(default(PlayfieldEntityList)); }
        }
                  		
        public async Task Request_Entity_Destroy2(IdPlayfield arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Entity_Destroy2,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_Entity_Export(EntityExportInfo arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Entity_Export,arg));
          } catch(TaskCanceledException) { }
        }
                  		
        public async Task Request_Entity_SetName(IdPlayfieldName arg){     
          try{
           await TaskTools.For(TimeSpan.Zero, SendRequestAsync<bool>(CmdId.Request_Entity_SetName,arg));
          } catch(TaskCanceledException) { }
        }
                  }
}

