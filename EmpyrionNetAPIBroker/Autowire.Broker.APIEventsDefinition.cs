 
using Eleon.Modding;
using System;
using System.Collections.Generic;

//this file was auto-generatedx

namespace EmpyrionNetAPIAccess
{
	public partial class Broker 
	{
		private Dictionary<CmdId, Delegate> eventTable = new Dictionary<CmdId, Delegate>();
    
		
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldLoad> Event_Playfield_Loaded
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_Loaded] = eventTable.ContainsKey(CmdId.Event_Playfield_Loaded)
						? (Action<PlayfieldLoad>)eventTable[CmdId.Event_Playfield_Loaded] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_Loaded] = eventTable.ContainsKey(CmdId.Event_Playfield_Loaded)
						? (Action<PlayfieldLoad>)eventTable[CmdId.Event_Playfield_Loaded] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldLoad> Event_Playfield_Unloaded
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_Unloaded] = eventTable.ContainsKey(CmdId.Event_Playfield_Unloaded)
						? (Action<PlayfieldLoad>)eventTable[CmdId.Event_Playfield_Unloaded] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_Unloaded] = eventTable.ContainsKey(CmdId.Event_Playfield_Unloaded)
						? (Action<PlayfieldLoad>)eventTable[CmdId.Event_Playfield_Unloaded] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Id> Event_Player_Connected
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Connected] = eventTable.ContainsKey(CmdId.Event_Player_Connected)
						? (Action<Id>)eventTable[CmdId.Event_Player_Connected] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Connected] = eventTable.ContainsKey(CmdId.Event_Player_Connected)
						? (Action<Id>)eventTable[CmdId.Event_Player_Connected] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Id> Event_Player_Disconnected
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Disconnected] = eventTable.ContainsKey(CmdId.Event_Player_Disconnected)
						? (Action<Id>)eventTable[CmdId.Event_Player_Disconnected] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Disconnected] = eventTable.ContainsKey(CmdId.Event_Player_Disconnected)
						? (Action<Id>)eventTable[CmdId.Event_Player_Disconnected] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdPlayfield> Event_Player_ChangedPlayfield
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_ChangedPlayfield] = eventTable.ContainsKey(CmdId.Event_Player_ChangedPlayfield)
						? (Action<IdPlayfield>)eventTable[CmdId.Event_Player_ChangedPlayfield] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_ChangedPlayfield] = eventTable.ContainsKey(CmdId.Event_Player_ChangedPlayfield)
						? (Action<IdPlayfield>)eventTable[CmdId.Event_Player_ChangedPlayfield] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Id> Event_Player_DisconnectedWaiting
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_DisconnectedWaiting] = eventTable.ContainsKey(CmdId.Event_Player_DisconnectedWaiting)
						? (Action<Id>)eventTable[CmdId.Event_Player_DisconnectedWaiting] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_DisconnectedWaiting] = eventTable.ContainsKey(CmdId.Event_Player_DisconnectedWaiting)
						? (Action<Id>)eventTable[CmdId.Event_Player_DisconnectedWaiting] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<FactionChangeInfo> Event_Faction_Changed
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Faction_Changed] = eventTable.ContainsKey(CmdId.Event_Faction_Changed)
						? (Action<FactionChangeInfo>)eventTable[CmdId.Event_Faction_Changed] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Faction_Changed] = eventTable.ContainsKey(CmdId.Event_Faction_Changed)
						? (Action<FactionChangeInfo>)eventTable[CmdId.Event_Faction_Changed] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<StatisticsParam> Event_Statistics
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Statistics] = eventTable.ContainsKey(CmdId.Event_Statistics)
						? (Action<StatisticsParam>)eventTable[CmdId.Event_Statistics] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Statistics] = eventTable.ContainsKey(CmdId.Event_Statistics)
						? (Action<StatisticsParam>)eventTable[CmdId.Event_Statistics] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<ChatInfo> Event_ChatMessage
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_ChatMessage] = eventTable.ContainsKey(CmdId.Event_ChatMessage)
						? (Action<ChatInfo>)eventTable[CmdId.Event_ChatMessage] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_ChatMessage] = eventTable.ContainsKey(CmdId.Event_ChatMessage)
						? (Action<ChatInfo>)eventTable[CmdId.Event_ChatMessage] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<TraderNPCItemSoldInfo> Event_TraderNPCItemSold
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_TraderNPCItemSold] = eventTable.ContainsKey(CmdId.Event_TraderNPCItemSold)
						? (Action<TraderNPCItemSoldInfo>)eventTable[CmdId.Event_TraderNPCItemSold] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_TraderNPCItemSold] = eventTable.ContainsKey(CmdId.Event_TraderNPCItemSold)
						? (Action<TraderNPCItemSoldInfo>)eventTable[CmdId.Event_TraderNPCItemSold] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<ConsoleCommandInfo> Event_ConsoleCommand
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_ConsoleCommand] = eventTable.ContainsKey(CmdId.Event_ConsoleCommand)
						? (Action<ConsoleCommandInfo>)eventTable[CmdId.Event_ConsoleCommand] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_ConsoleCommand] = eventTable.ContainsKey(CmdId.Event_ConsoleCommand)
						? (Action<ConsoleCommandInfo>)eventTable[CmdId.Event_ConsoleCommand] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PdaStateInfo> Event_PdaStateChange
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_PdaStateChange] = eventTable.ContainsKey(CmdId.Event_PdaStateChange)
						? (Action<PdaStateInfo>)eventTable[CmdId.Event_PdaStateChange] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_PdaStateChange] = eventTable.ContainsKey(CmdId.Event_PdaStateChange)
						? (Action<PdaStateInfo>)eventTable[CmdId.Event_PdaStateChange] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<GameEventData> Event_GameEvent
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_GameEvent] = eventTable.ContainsKey(CmdId.Event_GameEvent)
						? (Action<GameEventData>)eventTable[CmdId.Event_GameEvent] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_GameEvent] = eventTable.ContainsKey(CmdId.Event_GameEvent)
						? (Action<GameEventData>)eventTable[CmdId.Event_GameEvent] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<AlliancesTable> Event_AlliancesAll
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_AlliancesAll] = eventTable.ContainsKey(CmdId.Event_AlliancesAll)
						? (Action<AlliancesTable>)eventTable[CmdId.Event_AlliancesAll] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_AlliancesAll] = eventTable.ContainsKey(CmdId.Event_AlliancesAll)
						? (Action<AlliancesTable>)eventTable[CmdId.Event_AlliancesAll] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<AlliancesFaction> Event_AlliancesFaction
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_AlliancesFaction] = eventTable.ContainsKey(CmdId.Event_AlliancesFaction)
						? (Action<AlliancesFaction>)eventTable[CmdId.Event_AlliancesFaction] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_AlliancesFaction] = eventTable.ContainsKey(CmdId.Event_AlliancesFaction)
						? (Action<AlliancesFaction>)eventTable[CmdId.Event_AlliancesFaction] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdList> Event_BannedPlayers
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_BannedPlayers] = eventTable.ContainsKey(CmdId.Event_BannedPlayers)
						? (Action<IdList>)eventTable[CmdId.Event_BannedPlayers] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_BannedPlayers] = eventTable.ContainsKey(CmdId.Event_BannedPlayers)
						? (Action<IdList>)eventTable[CmdId.Event_BannedPlayers] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<DediStats> Event_Dedi_Stats
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Dedi_Stats] = eventTable.ContainsKey(CmdId.Event_Dedi_Stats)
						? (Action<DediStats>)eventTable[CmdId.Event_Dedi_Stats] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Dedi_Stats] = eventTable.ContainsKey(CmdId.Event_Dedi_Stats)
						? (Action<DediStats>)eventTable[CmdId.Event_Dedi_Stats] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdPositionRotation> Event_Entity_PosAndRot
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Entity_PosAndRot] = eventTable.ContainsKey(CmdId.Event_Entity_PosAndRot)
						? (Action<IdPositionRotation>)eventTable[CmdId.Event_Entity_PosAndRot] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Entity_PosAndRot] = eventTable.ContainsKey(CmdId.Event_Entity_PosAndRot)
						? (Action<IdPositionRotation>)eventTable[CmdId.Event_Entity_PosAndRot] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<FactionInfoList> Event_Get_Factions
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Get_Factions] = eventTable.ContainsKey(CmdId.Event_Get_Factions)
						? (Action<FactionInfoList>)eventTable[CmdId.Event_Get_Factions] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Get_Factions] = eventTable.ContainsKey(CmdId.Event_Get_Factions)
						? (Action<FactionInfoList>)eventTable[CmdId.Event_Get_Factions] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<GlobalStructureList> Event_GlobalStructure_List
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_GlobalStructure_List] = eventTable.ContainsKey(CmdId.Event_GlobalStructure_List)
						? (Action<GlobalStructureList>)eventTable[CmdId.Event_GlobalStructure_List] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_GlobalStructure_List] = eventTable.ContainsKey(CmdId.Event_GlobalStructure_List)
						? (Action<GlobalStructureList>)eventTable[CmdId.Event_GlobalStructure_List] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Id> Event_NewEntityId
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_NewEntityId] = eventTable.ContainsKey(CmdId.Event_NewEntityId)
						? (Action<Id>)eventTable[CmdId.Event_NewEntityId] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_NewEntityId] = eventTable.ContainsKey(CmdId.Event_NewEntityId)
						? (Action<Id>)eventTable[CmdId.Event_NewEntityId] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action Event_Ok
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Ok] = eventTable.ContainsKey(CmdId.Event_Ok)
						? (Action)eventTable[CmdId.Event_Ok] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Ok] = eventTable.ContainsKey(CmdId.Event_Ok)
						? (Action)eventTable[CmdId.Event_Ok] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdCredits> Event_Player_Credits
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Credits] = eventTable.ContainsKey(CmdId.Event_Player_Credits)
						? (Action<IdCredits>)eventTable[CmdId.Event_Player_Credits] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Credits] = eventTable.ContainsKey(CmdId.Event_Player_Credits)
						? (Action<IdCredits>)eventTable[CmdId.Event_Player_Credits] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Inventory> Event_Player_GetAndRemoveInventory
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_GetAndRemoveInventory] = eventTable.ContainsKey(CmdId.Event_Player_GetAndRemoveInventory)
						? (Action<Inventory>)eventTable[CmdId.Event_Player_GetAndRemoveInventory] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_GetAndRemoveInventory] = eventTable.ContainsKey(CmdId.Event_Player_GetAndRemoveInventory)
						? (Action<Inventory>)eventTable[CmdId.Event_Player_GetAndRemoveInventory] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayerInfo> Event_Player_Info
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Info] = eventTable.ContainsKey(CmdId.Event_Player_Info)
						? (Action<PlayerInfo>)eventTable[CmdId.Event_Player_Info] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Info] = eventTable.ContainsKey(CmdId.Event_Player_Info)
						? (Action<PlayerInfo>)eventTable[CmdId.Event_Player_Info] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Inventory> Event_Player_Inventory
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Inventory] = eventTable.ContainsKey(CmdId.Event_Player_Inventory)
						? (Action<Inventory>)eventTable[CmdId.Event_Player_Inventory] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_Inventory] = eventTable.ContainsKey(CmdId.Event_Player_Inventory)
						? (Action<Inventory>)eventTable[CmdId.Event_Player_Inventory] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<ItemExchangeInfo> Event_Player_ItemExchange
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_ItemExchange] = eventTable.ContainsKey(CmdId.Event_Player_ItemExchange)
						? (Action<ItemExchangeInfo>)eventTable[CmdId.Event_Player_ItemExchange] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_ItemExchange] = eventTable.ContainsKey(CmdId.Event_Player_ItemExchange)
						? (Action<ItemExchangeInfo>)eventTable[CmdId.Event_Player_ItemExchange] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdList> Event_Player_List
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_List] = eventTable.ContainsKey(CmdId.Event_Player_List)
						? (Action<IdList>)eventTable[CmdId.Event_Player_List] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Player_List] = eventTable.ContainsKey(CmdId.Event_Player_List)
						? (Action<IdList>)eventTable[CmdId.Event_Player_List] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldEntityList> Event_Playfield_Entity_List
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_Entity_List] = eventTable.ContainsKey(CmdId.Event_Playfield_Entity_List)
						? (Action<PlayfieldEntityList>)eventTable[CmdId.Event_Playfield_Entity_List] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_Entity_List] = eventTable.ContainsKey(CmdId.Event_Playfield_Entity_List)
						? (Action<PlayfieldEntityList>)eventTable[CmdId.Event_Playfield_Entity_List] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldList> Event_Playfield_List
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_List] = eventTable.ContainsKey(CmdId.Event_Playfield_List)
						? (Action<PlayfieldList>)eventTable[CmdId.Event_Playfield_List] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_List] = eventTable.ContainsKey(CmdId.Event_Playfield_List)
						? (Action<PlayfieldList>)eventTable[CmdId.Event_Playfield_List] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldStats> Event_Playfield_Stats
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_Stats] = eventTable.ContainsKey(CmdId.Event_Playfield_Stats)
						? (Action<PlayfieldStats>)eventTable[CmdId.Event_Playfield_Stats] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Playfield_Stats] = eventTable.ContainsKey(CmdId.Event_Playfield_Stats)
						? (Action<PlayfieldStats>)eventTable[CmdId.Event_Playfield_Stats] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdStructureBlockInfo> Event_Structure_BlockStatistics
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Structure_BlockStatistics] = eventTable.ContainsKey(CmdId.Event_Structure_BlockStatistics)
						? (Action<IdStructureBlockInfo>)eventTable[CmdId.Event_Structure_BlockStatistics] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_Structure_BlockStatistics] = eventTable.ContainsKey(CmdId.Event_Structure_BlockStatistics)
						? (Action<IdStructureBlockInfo>)eventTable[CmdId.Event_Structure_BlockStatistics] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdAndIntValue> Event_DialogButtonIndex
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_DialogButtonIndex] = eventTable.ContainsKey(CmdId.Event_DialogButtonIndex)
						? (Action<IdAndIntValue>)eventTable[CmdId.Event_DialogButtonIndex] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_DialogButtonIndex] = eventTable.ContainsKey(CmdId.Event_DialogButtonIndex)
						? (Action<IdAndIntValue>)eventTable[CmdId.Event_DialogButtonIndex] - value
						: value;
				}
			}
		}
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<ChatMsgData> Event_ChatMessageEx
		{
			add {
				lock(eventTable)
				{
					eventTable[CmdId.Event_ChatMessageEx] = eventTable.ContainsKey(CmdId.Event_ChatMessageEx)
						? (Action<ChatMsgData>)eventTable[CmdId.Event_ChatMessageEx] + value
						: value;
				}
			}
			remove {
				lock(eventTable)
				{
					eventTable[CmdId.Event_ChatMessageEx] = eventTable.ContainsKey(CmdId.Event_ChatMessageEx)
						? (Action<ChatMsgData>)eventTable[CmdId.Event_ChatMessageEx] - value
						: value;
				}
			}
		}
    }
}