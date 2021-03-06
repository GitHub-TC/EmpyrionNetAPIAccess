﻿using System;
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
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayfieldList>(CmdId.Request_Playfield_List,null));
        }
          		
        public async Task<PlayfieldStats> Request_Playfield_Stats(PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayfieldStats>(CmdId.Request_Playfield_Stats,arg));
        }

        public async Task<PlayfieldStats> Request_Playfield_Stats(Timeouts timeoutSeconds, PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayfieldStats>(CmdId.Request_Playfield_Stats,arg));
        }
          		
        public async Task<DediStats> Request_Dedi_Stats(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats,null));
        }

        public async Task<DediStats> Request_Dedi_Stats(Timeouts timeoutSeconds){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<DediStats>(CmdId.Request_Dedi_Stats,null));
        }
          		
        public async Task<GlobalStructureList> Request_GlobalStructure_List(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List,null));
        }

        public async Task<GlobalStructureList> Request_GlobalStructure_List(Timeouts timeoutSeconds){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<GlobalStructureList>(CmdId.Request_GlobalStructure_List,null));
        }
          		
        public async Task<bool> Request_GlobalStructure_Update(PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_GlobalStructure_Update,arg));
        }

        public async Task<bool> Request_GlobalStructure_Update(Timeouts timeoutSeconds, PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_GlobalStructure_Update,arg));
        }
          		
        public async Task<bool> Request_Structure_Touch(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Structure_Touch,arg));
        }

        public async Task<bool> Request_Structure_Touch(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Structure_Touch,arg));
        }
          		
        public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics,arg));
        }

        public async Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics,arg));
        }
          		
        public async Task<PlayerInfo> Request_Player_Info(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayerInfo>(CmdId.Request_Player_Info,arg));
        }

        public async Task<PlayerInfo> Request_Player_Info(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayerInfo>(CmdId.Request_Player_Info,arg));
        }
          		
        public async Task<IdList> Request_Player_List(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdList>(CmdId.Request_Player_List,null));
        }

        public async Task<IdList> Request_Player_List(Timeouts timeoutSeconds){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdList>(CmdId.Request_Player_List,null));
        }
          		
        public async Task<Inventory> Request_Player_GetInventory(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Inventory>(CmdId.Request_Player_GetInventory,arg));
        }

        public async Task<Inventory> Request_Player_GetInventory(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Inventory>(CmdId.Request_Player_GetInventory,arg));
        }
          		
        public async Task<Inventory> Request_Player_SetInventory(Inventory arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Inventory>(CmdId.Request_Player_SetInventory,arg));
        }

        public async Task<Inventory> Request_Player_SetInventory(Timeouts timeoutSeconds, Inventory arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Inventory>(CmdId.Request_Player_SetInventory,arg));
        }
          		
        public async Task<bool> Request_Player_AddItem(IdItemStack arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Player_AddItem,arg));
        }

        public async Task<bool> Request_Player_AddItem(Timeouts timeoutSeconds, IdItemStack arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Player_AddItem,arg));
        }
          		
        public async Task<IdCredits> Request_Player_Credits(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdCredits>(CmdId.Request_Player_Credits,arg));
        }

        public async Task<IdCredits> Request_Player_Credits(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdCredits>(CmdId.Request_Player_Credits,arg));
        }
          		
        public async Task<IdCredits> Request_Player_SetCredits(IdCredits arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdCredits>(CmdId.Request_Player_SetCredits,arg));
        }

        public async Task<IdCredits> Request_Player_SetCredits(Timeouts timeoutSeconds, IdCredits arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdCredits>(CmdId.Request_Player_SetCredits,arg));
        }
          		
        public async Task<IdCredits> Request_Player_AddCredits(IdCredits arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdCredits>(CmdId.Request_Player_AddCredits,arg));
        }

        public async Task<IdCredits> Request_Player_AddCredits(Timeouts timeoutSeconds, IdCredits arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdCredits>(CmdId.Request_Player_AddCredits,arg));
        }
          		
        public async Task<bool> Request_Blueprint_Finish(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Blueprint_Finish,arg));
        }

        public async Task<bool> Request_Blueprint_Finish(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Blueprint_Finish,arg));
        }
          		
        public async Task<bool> Request_Blueprint_Resources(BlueprintResources arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Blueprint_Resources,arg));
        }

        public async Task<bool> Request_Blueprint_Resources(Timeouts timeoutSeconds, BlueprintResources arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Blueprint_Resources,arg));
        }
          		
        public async Task<bool> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Player_ChangePlayerfield,arg));
        }

        public async Task<bool> Request_Player_ChangePlayerfield(Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Player_ChangePlayerfield,arg));
        }
          		
        public async Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<ItemExchangeInfo>(CmdId.Request_Player_ItemExchange,arg));
        }

        public async Task<ItemExchangeInfo> Request_Player_ItemExchange(Timeouts timeoutSeconds, ItemExchangeInfo arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<ItemExchangeInfo>(CmdId.Request_Player_ItemExchange,arg));
        }
          		
        public async Task<bool> Request_Player_SetPlayerInfo(PlayerInfoSet arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Player_SetPlayerInfo,arg));
        }

        public async Task<bool> Request_Player_SetPlayerInfo(Timeouts timeoutSeconds, PlayerInfoSet arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Player_SetPlayerInfo,arg));
        }
          		
        public async Task<bool> Request_Entity_Teleport(IdPositionRotation arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Teleport,arg));
        }

        public async Task<bool> Request_Entity_Teleport(Timeouts timeoutSeconds, IdPositionRotation arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Teleport,arg));
        }
          		
        public async Task<bool> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_ChangePlayfield,arg));
        }

        public async Task<bool> Request_Entity_ChangePlayfield(Timeouts timeoutSeconds, IdPlayfieldPositionRotation arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_ChangePlayfield,arg));
        }
          		
        public async Task<bool> Request_Entity_Destroy(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Destroy,arg));
        }

        public async Task<bool> Request_Entity_Destroy(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Destroy,arg));
        }
          		
        public async Task<IdPositionRotation> Request_Entity_PosAndRot(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdPositionRotation>(CmdId.Request_Entity_PosAndRot,arg));
        }

        public async Task<IdPositionRotation> Request_Entity_PosAndRot(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdPositionRotation>(CmdId.Request_Entity_PosAndRot,arg));
        }
          		
        public async Task<bool> Request_Entity_Spawn(EntitySpawnInfo arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Spawn,arg));
        }

        public async Task<bool> Request_Entity_Spawn(Timeouts timeoutSeconds, EntitySpawnInfo arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Spawn,arg));
        }
          		
        public async Task<FactionInfoList> Request_Get_Factions(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<FactionInfoList>(CmdId.Request_Get_Factions,arg));
        }

        public async Task<FactionInfoList> Request_Get_Factions(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<FactionInfoList>(CmdId.Request_Get_Factions,arg));
        }
          		
        public async Task<Id> Request_NewEntityId(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Id>(CmdId.Request_NewEntityId,null));
        }

        public async Task<Id> Request_NewEntityId(Timeouts timeoutSeconds){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Id>(CmdId.Request_NewEntityId,null));
        }
          		
        public async Task<AlliancesTable> Request_AlliancesAll(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll,null));
        }

        public async Task<AlliancesTable> Request_AlliancesAll(Timeouts timeoutSeconds){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<AlliancesTable>(CmdId.Request_AlliancesAll,null));
        }
          		
        public async Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<AlliancesFaction>(CmdId.Request_AlliancesFaction,arg));
        }

        public async Task<AlliancesFaction> Request_AlliancesFaction(Timeouts timeoutSeconds, AlliancesFaction arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<AlliancesFaction>(CmdId.Request_AlliancesFaction,arg));
        }
          		
        public async Task<bool> Request_Load_Playfield(PlayfieldLoad arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Load_Playfield,arg));
        }

        public async Task<bool> Request_Load_Playfield(Timeouts timeoutSeconds, PlayfieldLoad arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Load_Playfield,arg));
        }
          		
        public async Task<bool> Request_ConsoleCommand(PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_ConsoleCommand,arg));
        }

        public async Task<bool> Request_ConsoleCommand(Timeouts timeoutSeconds, PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_ConsoleCommand,arg));
        }
          		
        public async Task<IdList> Request_GetBannedPlayers(){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers,null));
        }

        public async Task<IdList> Request_GetBannedPlayers(Timeouts timeoutSeconds){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdList>(CmdId.Request_GetBannedPlayers,null));
        }
          		
        public async Task<bool> Request_InGameMessage_SinglePlayer(IdMsgPrio arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_InGameMessage_SinglePlayer,arg));
        }

        public async Task<bool> Request_InGameMessage_SinglePlayer(Timeouts timeoutSeconds, IdMsgPrio arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_InGameMessage_SinglePlayer,arg));
        }
          		
        public async Task<bool> Request_InGameMessage_AllPlayers(IdMsgPrio arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_InGameMessage_AllPlayers,arg));
        }

        public async Task<bool> Request_InGameMessage_AllPlayers(Timeouts timeoutSeconds, IdMsgPrio arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_InGameMessage_AllPlayers,arg));
        }
          		
        public async Task<bool> Request_InGameMessage_Faction(IdMsgPrio arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_InGameMessage_Faction,arg));
        }

        public async Task<bool> Request_InGameMessage_Faction(Timeouts timeoutSeconds, IdMsgPrio arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_InGameMessage_Faction,arg));
        }
          		
        public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer,arg));
        }

        public async Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(Timeouts timeoutSeconds, DialogBoxData arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer,arg));
        }
          		
        public async Task<Inventory> Request_Player_GetAndRemoveInventory(Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Inventory>(CmdId.Request_Player_GetAndRemoveInventory,arg));
        }

        public async Task<Inventory> Request_Player_GetAndRemoveInventory(Timeouts timeoutSeconds, Id arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<Inventory>(CmdId.Request_Player_GetAndRemoveInventory,arg));
        }
          		
        public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List,arg));
        }

        public async Task<PlayfieldEntityList> Request_Playfield_Entity_List(Timeouts timeoutSeconds, PString arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List,arg));
        }
          		
        public async Task<bool> Request_Entity_Destroy2(IdPlayfield arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Destroy2,arg));
        }

        public async Task<bool> Request_Entity_Destroy2(Timeouts timeoutSeconds, IdPlayfield arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Destroy2,arg));
        }
          		
        public async Task<bool> Request_Entity_Export(EntityExportInfo arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Export,arg));
        }

        public async Task<bool> Request_Entity_Export(Timeouts timeoutSeconds, EntityExportInfo arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_Export,arg));
        }
          		
        public async Task<bool> Request_Entity_SetName(IdPlayfieldName arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_SetName,arg));
        }

        public async Task<bool> Request_Entity_SetName(Timeouts timeoutSeconds, IdPlayfieldName arg){     
          return await TaskTools.For(EmpyrionRequestsDefaultTimeout, SendRequestAsync<bool>(CmdId.Request_Entity_SetName,arg));
        }
          }
}

