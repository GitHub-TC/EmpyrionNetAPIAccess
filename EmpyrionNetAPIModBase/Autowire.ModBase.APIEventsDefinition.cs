 
using Eleon.Modding;
using System;
using System.Collections.Generic;

//this file was auto-generatedx

namespace EmpyrionNetAPIAccess
{
	public abstract partial class EmpyrionModBase 
	{
		
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldLoad> Event_Playfield_Loaded
		{
			add {
				Broker.Event_Playfield_Loaded += value;
			}
			remove {
				Broker.Event_Playfield_Loaded -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldLoad> Event_Playfield_Unloaded
		{
			add {
				Broker.Event_Playfield_Unloaded += value;
			}
			remove {
				Broker.Event_Playfield_Unloaded -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Id> Event_Player_Connected
		{
			add {
				Broker.Event_Player_Connected += value;
			}
			remove {
				Broker.Event_Player_Connected -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Id> Event_Player_Disconnected
		{
			add {
				Broker.Event_Player_Disconnected += value;
			}
			remove {
				Broker.Event_Player_Disconnected -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdPlayfield> Event_Player_ChangedPlayfield
		{
			add {
				Broker.Event_Player_ChangedPlayfield += value;
			}
			remove {
				Broker.Event_Player_ChangedPlayfield -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Id> Event_Player_DisconnectedWaiting
		{
			add {
				Broker.Event_Player_DisconnectedWaiting += value;
			}
			remove {
				Broker.Event_Player_DisconnectedWaiting -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<FactionChangeInfo> Event_Faction_Changed
		{
			add {
				Broker.Event_Faction_Changed += value;
			}
			remove {
				Broker.Event_Faction_Changed -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<StatisticsParam> Event_Statistics
		{
			add {
				Broker.Event_Statistics += value;
			}
			remove {
				Broker.Event_Statistics -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<ChatInfo> Event_ChatMessage
		{
			add {
				Broker.Event_ChatMessage += value;
			}
			remove {
				Broker.Event_ChatMessage -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<TraderNPCItemSoldInfo> Event_TraderNPCItemSold
		{
			add {
				Broker.Event_TraderNPCItemSold += value;
			}
			remove {
				Broker.Event_TraderNPCItemSold -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<ConsoleCommandInfo> Event_ConsoleCommand
		{
			add {
				Broker.Event_ConsoleCommand += value;
			}
			remove {
				Broker.Event_ConsoleCommand -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PdaStateInfo> Event_PdaStateChange
		{
			add {
				Broker.Event_PdaStateChange += value;
			}
			remove {
				Broker.Event_PdaStateChange -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<GameEventData> Event_GameEvent
		{
			add {
				Broker.Event_GameEvent += value;
			}
			remove {
				Broker.Event_GameEvent -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<AlliancesTable> Event_AlliancesAll
		{
			add {
				Broker.Event_AlliancesAll += value;
			}
			remove {
				Broker.Event_AlliancesAll -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<AlliancesFaction> Event_AlliancesFaction
		{
			add {
				Broker.Event_AlliancesFaction += value;
			}
			remove {
				Broker.Event_AlliancesFaction -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdList> Event_BannedPlayers
		{
			add {
				Broker.Event_BannedPlayers += value;
			}
			remove {
				Broker.Event_BannedPlayers -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<DediStats> Event_Dedi_Stats
		{
			add {
				Broker.Event_Dedi_Stats += value;
			}
			remove {
				Broker.Event_Dedi_Stats -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdPositionRotation> Event_Entity_PosAndRot
		{
			add {
				Broker.Event_Entity_PosAndRot += value;
			}
			remove {
				Broker.Event_Entity_PosAndRot -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<FactionInfoList> Event_Get_Factions
		{
			add {
				Broker.Event_Get_Factions += value;
			}
			remove {
				Broker.Event_Get_Factions -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<GlobalStructureList> Event_GlobalStructure_List
		{
			add {
				Broker.Event_GlobalStructure_List += value;
			}
			remove {
				Broker.Event_GlobalStructure_List -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Id> Event_NewEntityId
		{
			add {
				Broker.Event_NewEntityId += value;
			}
			remove {
				Broker.Event_NewEntityId -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action Event_Ok
		{
			add {
				Broker.Event_Ok += value;
			}
			remove {
				Broker.Event_Ok -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdCredits> Event_Player_Credits
		{
			add {
				Broker.Event_Player_Credits += value;
			}
			remove {
				Broker.Event_Player_Credits -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Inventory> Event_Player_GetAndRemoveInventory
		{
			add {
				Broker.Event_Player_GetAndRemoveInventory += value;
			}
			remove {
				Broker.Event_Player_GetAndRemoveInventory -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayerInfo> Event_Player_Info
		{
			add {
				Broker.Event_Player_Info += value;
			}
			remove {
				Broker.Event_Player_Info -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<Inventory> Event_Player_Inventory
		{
			add {
				Broker.Event_Player_Inventory += value;
			}
			remove {
				Broker.Event_Player_Inventory -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<ItemExchangeInfo> Event_Player_ItemExchange
		{
			add {
				Broker.Event_Player_ItemExchange += value;
			}
			remove {
				Broker.Event_Player_ItemExchange -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdList> Event_Player_List
		{
			add {
				Broker.Event_Player_List += value;
			}
			remove {
				Broker.Event_Player_List -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldEntityList> Event_Playfield_Entity_List
		{
			add {
				Broker.Event_Playfield_Entity_List += value;
			}
			remove {
				Broker.Event_Playfield_Entity_List -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldList> Event_Playfield_List
		{
			add {
				Broker.Event_Playfield_List += value;
			}
			remove {
				Broker.Event_Playfield_List -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<PlayfieldStats> Event_Playfield_Stats
		{
			add {
				Broker.Event_Playfield_Stats += value;
			}
			remove {
				Broker.Event_Playfield_Stats -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdStructureBlockInfo> Event_Structure_BlockStatistics
		{
			add {
				Broker.Event_Structure_BlockStatistics += value;
			}
			remove {
				Broker.Event_Structure_BlockStatistics -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<IdAndIntValue> Event_DialogButtonIndex
		{
			add {
				Broker.Event_DialogButtonIndex += value;
			}
			remove {
				Broker.Event_DialogButtonIndex -= value;
			}
		}
    
    
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event Action<ChatMsgData> Event_ChatMessageEx
		{
			add {
				Broker.Event_ChatMessageEx += value;
			}
			remove {
				Broker.Event_ChatMessageEx -= value;
			}
		}
    }
}