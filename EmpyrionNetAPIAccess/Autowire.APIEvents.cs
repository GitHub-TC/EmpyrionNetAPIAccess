 
using Eleon.Modding;
using System;
using System.Collections.Generic;

//this file was auto-generatedx

namespace EmpyrionNetAPIAccess
{
	public partial class Broker {

    private Dictionary<CmdId, Delegate> eventTable = new Dictionary<CmdId, Delegate>();
    
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<PlayfieldLoad> Event_Playfield_Loaded
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_Loaded))
			  eventTable[CmdId.Event_Playfield_Loaded] = (Action<PlayfieldLoad>)eventTable[CmdId.Event_Playfield_Loaded] + value;
			else
			  eventTable[CmdId.Event_Playfield_Loaded] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_Loaded))
			  eventTable[CmdId.Event_Playfield_Loaded] = (Action<PlayfieldLoad>)eventTable[CmdId.Event_Playfield_Loaded] - value;
			else
			  eventTable[CmdId.Event_Playfield_Loaded] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<PlayfieldLoad> Event_Playfield_Unloaded
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_Unloaded))
			  eventTable[CmdId.Event_Playfield_Unloaded] = (Action<PlayfieldLoad>)eventTable[CmdId.Event_Playfield_Unloaded] + value;
			else
			  eventTable[CmdId.Event_Playfield_Unloaded] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_Unloaded))
			  eventTable[CmdId.Event_Playfield_Unloaded] = (Action<PlayfieldLoad>)eventTable[CmdId.Event_Playfield_Unloaded] - value;
			else
			  eventTable[CmdId.Event_Playfield_Unloaded] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<Id> Event_Player_Connected
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Connected))
			  eventTable[CmdId.Event_Player_Connected] = (Action<Id>)eventTable[CmdId.Event_Player_Connected] + value;
			else
			  eventTable[CmdId.Event_Player_Connected] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Connected))
			  eventTable[CmdId.Event_Player_Connected] = (Action<Id>)eventTable[CmdId.Event_Player_Connected] - value;
			else
			  eventTable[CmdId.Event_Player_Connected] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<Id> Event_Player_Disconnected
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Disconnected))
			  eventTable[CmdId.Event_Player_Disconnected] = (Action<Id>)eventTable[CmdId.Event_Player_Disconnected] + value;
			else
			  eventTable[CmdId.Event_Player_Disconnected] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Disconnected))
			  eventTable[CmdId.Event_Player_Disconnected] = (Action<Id>)eventTable[CmdId.Event_Player_Disconnected] - value;
			else
			  eventTable[CmdId.Event_Player_Disconnected] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<IdPlayfield> Event_Player_ChangedPlayfield
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_ChangedPlayfield))
			  eventTable[CmdId.Event_Player_ChangedPlayfield] = (Action<IdPlayfield>)eventTable[CmdId.Event_Player_ChangedPlayfield] + value;
			else
			  eventTable[CmdId.Event_Player_ChangedPlayfield] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_ChangedPlayfield))
			  eventTable[CmdId.Event_Player_ChangedPlayfield] = (Action<IdPlayfield>)eventTable[CmdId.Event_Player_ChangedPlayfield] - value;
			else
			  eventTable[CmdId.Event_Player_ChangedPlayfield] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<Id> Event_Player_DisconnectedWaiting
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_DisconnectedWaiting))
			  eventTable[CmdId.Event_Player_DisconnectedWaiting] = (Action<Id>)eventTable[CmdId.Event_Player_DisconnectedWaiting] + value;
			else
			  eventTable[CmdId.Event_Player_DisconnectedWaiting] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_DisconnectedWaiting))
			  eventTable[CmdId.Event_Player_DisconnectedWaiting] = (Action<Id>)eventTable[CmdId.Event_Player_DisconnectedWaiting] - value;
			else
			  eventTable[CmdId.Event_Player_DisconnectedWaiting] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<FactionChangeInfo> Event_Faction_Changed
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Faction_Changed))
			  eventTable[CmdId.Event_Faction_Changed] = (Action<FactionChangeInfo>)eventTable[CmdId.Event_Faction_Changed] + value;
			else
			  eventTable[CmdId.Event_Faction_Changed] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Faction_Changed))
			  eventTable[CmdId.Event_Faction_Changed] = (Action<FactionChangeInfo>)eventTable[CmdId.Event_Faction_Changed] - value;
			else
			  eventTable[CmdId.Event_Faction_Changed] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<StatisticsParam> Event_Statistics
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Statistics))
			  eventTable[CmdId.Event_Statistics] = (Action<StatisticsParam>)eventTable[CmdId.Event_Statistics] + value;
			else
			  eventTable[CmdId.Event_Statistics] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Statistics))
			  eventTable[CmdId.Event_Statistics] = (Action<StatisticsParam>)eventTable[CmdId.Event_Statistics] - value;
			else
			  eventTable[CmdId.Event_Statistics] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<ChatInfo> Event_ChatMessage
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_ChatMessage))
			  eventTable[CmdId.Event_ChatMessage] = (Action<ChatInfo>)eventTable[CmdId.Event_ChatMessage] + value;
			else
			  eventTable[CmdId.Event_ChatMessage] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_ChatMessage))
			  eventTable[CmdId.Event_ChatMessage] = (Action<ChatInfo>)eventTable[CmdId.Event_ChatMessage] - value;
			else
			  eventTable[CmdId.Event_ChatMessage] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<TraderNPCItemSoldInfo> Event_TraderNPCItemSold
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_TraderNPCItemSold))
			  eventTable[CmdId.Event_TraderNPCItemSold] = (Action<TraderNPCItemSoldInfo>)eventTable[CmdId.Event_TraderNPCItemSold] + value;
			else
			  eventTable[CmdId.Event_TraderNPCItemSold] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_TraderNPCItemSold))
			  eventTable[CmdId.Event_TraderNPCItemSold] = (Action<TraderNPCItemSoldInfo>)eventTable[CmdId.Event_TraderNPCItemSold] - value;
			else
			  eventTable[CmdId.Event_TraderNPCItemSold] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<ConsoleCommandInfo> Event_ConsoleCommand
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_ConsoleCommand))
			  eventTable[CmdId.Event_ConsoleCommand] = (Action<ConsoleCommandInfo>)eventTable[CmdId.Event_ConsoleCommand] + value;
			else
			  eventTable[CmdId.Event_ConsoleCommand] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_ConsoleCommand))
			  eventTable[CmdId.Event_ConsoleCommand] = (Action<ConsoleCommandInfo>)eventTable[CmdId.Event_ConsoleCommand] - value;
			else
			  eventTable[CmdId.Event_ConsoleCommand] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<PdaStateInfo> Event_PdaStateChange
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_PdaStateChange))
			  eventTable[CmdId.Event_PdaStateChange] = (Action<PdaStateInfo>)eventTable[CmdId.Event_PdaStateChange] + value;
			else
			  eventTable[CmdId.Event_PdaStateChange] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_PdaStateChange))
			  eventTable[CmdId.Event_PdaStateChange] = (Action<PdaStateInfo>)eventTable[CmdId.Event_PdaStateChange] - value;
			else
			  eventTable[CmdId.Event_PdaStateChange] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<GameEventData> Event_GameEvent
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_GameEvent))
			  eventTable[CmdId.Event_GameEvent] = (Action<GameEventData>)eventTable[CmdId.Event_GameEvent] + value;
			else
			  eventTable[CmdId.Event_GameEvent] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_GameEvent))
			  eventTable[CmdId.Event_GameEvent] = (Action<GameEventData>)eventTable[CmdId.Event_GameEvent] - value;
			else
			  eventTable[CmdId.Event_GameEvent] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<AlliancesTable> Event_AlliancesAll
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_AlliancesAll))
			  eventTable[CmdId.Event_AlliancesAll] = (Action<AlliancesTable>)eventTable[CmdId.Event_AlliancesAll] + value;
			else
			  eventTable[CmdId.Event_AlliancesAll] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_AlliancesAll))
			  eventTable[CmdId.Event_AlliancesAll] = (Action<AlliancesTable>)eventTable[CmdId.Event_AlliancesAll] - value;
			else
			  eventTable[CmdId.Event_AlliancesAll] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<AlliancesFaction> Event_AlliancesFaction
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_AlliancesFaction))
			  eventTable[CmdId.Event_AlliancesFaction] = (Action<AlliancesFaction>)eventTable[CmdId.Event_AlliancesFaction] + value;
			else
			  eventTable[CmdId.Event_AlliancesFaction] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_AlliancesFaction))
			  eventTable[CmdId.Event_AlliancesFaction] = (Action<AlliancesFaction>)eventTable[CmdId.Event_AlliancesFaction] - value;
			else
			  eventTable[CmdId.Event_AlliancesFaction] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<IdList> Event_BannedPlayers
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_BannedPlayers))
			  eventTable[CmdId.Event_BannedPlayers] = (Action<IdList>)eventTable[CmdId.Event_BannedPlayers] + value;
			else
			  eventTable[CmdId.Event_BannedPlayers] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_BannedPlayers))
			  eventTable[CmdId.Event_BannedPlayers] = (Action<IdList>)eventTable[CmdId.Event_BannedPlayers] - value;
			else
			  eventTable[CmdId.Event_BannedPlayers] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<DediStats> Event_Dedi_Stats
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Dedi_Stats))
			  eventTable[CmdId.Event_Dedi_Stats] = (Action<DediStats>)eventTable[CmdId.Event_Dedi_Stats] + value;
			else
			  eventTable[CmdId.Event_Dedi_Stats] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Dedi_Stats))
			  eventTable[CmdId.Event_Dedi_Stats] = (Action<DediStats>)eventTable[CmdId.Event_Dedi_Stats] - value;
			else
			  eventTable[CmdId.Event_Dedi_Stats] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<IdPositionRotation> Event_Entity_PosAndRot
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Entity_PosAndRot))
			  eventTable[CmdId.Event_Entity_PosAndRot] = (Action<IdPositionRotation>)eventTable[CmdId.Event_Entity_PosAndRot] + value;
			else
			  eventTable[CmdId.Event_Entity_PosAndRot] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Entity_PosAndRot))
			  eventTable[CmdId.Event_Entity_PosAndRot] = (Action<IdPositionRotation>)eventTable[CmdId.Event_Entity_PosAndRot] - value;
			else
			  eventTable[CmdId.Event_Entity_PosAndRot] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<FactionInfoList> Event_Get_Factions
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Get_Factions))
			  eventTable[CmdId.Event_Get_Factions] = (Action<FactionInfoList>)eventTable[CmdId.Event_Get_Factions] + value;
			else
			  eventTable[CmdId.Event_Get_Factions] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Get_Factions))
			  eventTable[CmdId.Event_Get_Factions] = (Action<FactionInfoList>)eventTable[CmdId.Event_Get_Factions] - value;
			else
			  eventTable[CmdId.Event_Get_Factions] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<GlobalStructureList> Event_GlobalStructure_List
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_GlobalStructure_List))
			  eventTable[CmdId.Event_GlobalStructure_List] = (Action<GlobalStructureList>)eventTable[CmdId.Event_GlobalStructure_List] + value;
			else
			  eventTable[CmdId.Event_GlobalStructure_List] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_GlobalStructure_List))
			  eventTable[CmdId.Event_GlobalStructure_List] = (Action<GlobalStructureList>)eventTable[CmdId.Event_GlobalStructure_List] - value;
			else
			  eventTable[CmdId.Event_GlobalStructure_List] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<Id> Event_NewEntityId
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_NewEntityId))
			  eventTable[CmdId.Event_NewEntityId] = (Action<Id>)eventTable[CmdId.Event_NewEntityId] + value;
			else
			  eventTable[CmdId.Event_NewEntityId] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_NewEntityId))
			  eventTable[CmdId.Event_NewEntityId] = (Action<Id>)eventTable[CmdId.Event_NewEntityId] - value;
			else
			  eventTable[CmdId.Event_NewEntityId] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action Event_Ok
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Ok))
			  eventTable[CmdId.Event_Ok] = (Action)eventTable[CmdId.Event_Ok] + value;
			else
			  eventTable[CmdId.Event_Ok] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Ok))
			  eventTable[CmdId.Event_Ok] = (Action)eventTable[CmdId.Event_Ok] - value;
			else
			  eventTable[CmdId.Event_Ok] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<IdCredits> Event_Player_Credits
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Credits))
			  eventTable[CmdId.Event_Player_Credits] = (Action<IdCredits>)eventTable[CmdId.Event_Player_Credits] + value;
			else
			  eventTable[CmdId.Event_Player_Credits] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Credits))
			  eventTable[CmdId.Event_Player_Credits] = (Action<IdCredits>)eventTable[CmdId.Event_Player_Credits] - value;
			else
			  eventTable[CmdId.Event_Player_Credits] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<Inventory> Event_Player_GetAndRemoveInventory
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_GetAndRemoveInventory))
			  eventTable[CmdId.Event_Player_GetAndRemoveInventory] = (Action<Inventory>)eventTable[CmdId.Event_Player_GetAndRemoveInventory] + value;
			else
			  eventTable[CmdId.Event_Player_GetAndRemoveInventory] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_GetAndRemoveInventory))
			  eventTable[CmdId.Event_Player_GetAndRemoveInventory] = (Action<Inventory>)eventTable[CmdId.Event_Player_GetAndRemoveInventory] - value;
			else
			  eventTable[CmdId.Event_Player_GetAndRemoveInventory] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<PlayerInfo> Event_Player_Info
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Info))
			  eventTable[CmdId.Event_Player_Info] = (Action<PlayerInfo>)eventTable[CmdId.Event_Player_Info] + value;
			else
			  eventTable[CmdId.Event_Player_Info] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Info))
			  eventTable[CmdId.Event_Player_Info] = (Action<PlayerInfo>)eventTable[CmdId.Event_Player_Info] - value;
			else
			  eventTable[CmdId.Event_Player_Info] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<Inventory> Event_Player_Inventory
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Inventory))
			  eventTable[CmdId.Event_Player_Inventory] = (Action<Inventory>)eventTable[CmdId.Event_Player_Inventory] + value;
			else
			  eventTable[CmdId.Event_Player_Inventory] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_Inventory))
			  eventTable[CmdId.Event_Player_Inventory] = (Action<Inventory>)eventTable[CmdId.Event_Player_Inventory] - value;
			else
			  eventTable[CmdId.Event_Player_Inventory] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<ItemExchangeInfo> Event_Player_ItemExchange
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_ItemExchange))
			  eventTable[CmdId.Event_Player_ItemExchange] = (Action<ItemExchangeInfo>)eventTable[CmdId.Event_Player_ItemExchange] + value;
			else
			  eventTable[CmdId.Event_Player_ItemExchange] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_ItemExchange))
			  eventTable[CmdId.Event_Player_ItemExchange] = (Action<ItemExchangeInfo>)eventTable[CmdId.Event_Player_ItemExchange] - value;
			else
			  eventTable[CmdId.Event_Player_ItemExchange] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<IdList> Event_Player_List
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_List))
			  eventTable[CmdId.Event_Player_List] = (Action<IdList>)eventTable[CmdId.Event_Player_List] + value;
			else
			  eventTable[CmdId.Event_Player_List] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Player_List))
			  eventTable[CmdId.Event_Player_List] = (Action<IdList>)eventTable[CmdId.Event_Player_List] - value;
			else
			  eventTable[CmdId.Event_Player_List] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<PlayfieldEntityList> Event_Playfield_Entity_List
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_Entity_List))
			  eventTable[CmdId.Event_Playfield_Entity_List] = (Action<PlayfieldEntityList>)eventTable[CmdId.Event_Playfield_Entity_List] + value;
			else
			  eventTable[CmdId.Event_Playfield_Entity_List] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_Entity_List))
			  eventTable[CmdId.Event_Playfield_Entity_List] = (Action<PlayfieldEntityList>)eventTable[CmdId.Event_Playfield_Entity_List] - value;
			else
			  eventTable[CmdId.Event_Playfield_Entity_List] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<PlayfieldList> Event_Playfield_List
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_List))
			  eventTable[CmdId.Event_Playfield_List] = (Action<PlayfieldList>)eventTable[CmdId.Event_Playfield_List] + value;
			else
			  eventTable[CmdId.Event_Playfield_List] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_List))
			  eventTable[CmdId.Event_Playfield_List] = (Action<PlayfieldList>)eventTable[CmdId.Event_Playfield_List] - value;
			else
			  eventTable[CmdId.Event_Playfield_List] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<PlayfieldStats> Event_Playfield_Stats
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_Stats))
			  eventTable[CmdId.Event_Playfield_Stats] = (Action<PlayfieldStats>)eventTable[CmdId.Event_Playfield_Stats] + value;
			else
			  eventTable[CmdId.Event_Playfield_Stats] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Playfield_Stats))
			  eventTable[CmdId.Event_Playfield_Stats] = (Action<PlayfieldStats>)eventTable[CmdId.Event_Playfield_Stats] - value;
			else
			  eventTable[CmdId.Event_Playfield_Stats] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<IdStructureBlockInfo> Event_Structure_BlockStatistics
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Structure_BlockStatistics))
			  eventTable[CmdId.Event_Structure_BlockStatistics] = (Action<IdStructureBlockInfo>)eventTable[CmdId.Event_Structure_BlockStatistics] + value;
			else
			  eventTable[CmdId.Event_Structure_BlockStatistics] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_Structure_BlockStatistics))
			  eventTable[CmdId.Event_Structure_BlockStatistics] = (Action<IdStructureBlockInfo>)eventTable[CmdId.Event_Structure_BlockStatistics] - value;
			else
			  eventTable[CmdId.Event_Structure_BlockStatistics] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<IdAndIntValue> Event_DialogButtonIndex
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_DialogButtonIndex))
			  eventTable[CmdId.Event_DialogButtonIndex] = (Action<IdAndIntValue>)eventTable[CmdId.Event_DialogButtonIndex] + value;
			else
			  eventTable[CmdId.Event_DialogButtonIndex] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_DialogButtonIndex))
			  eventTable[CmdId.Event_DialogButtonIndex] = (Action<IdAndIntValue>)eventTable[CmdId.Event_DialogButtonIndex] - value;
			else
			  eventTable[CmdId.Event_DialogButtonIndex] = value;
		}
	  }
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event Action<ChatMsgData> Event_ChatMessageEx
    {
      add {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_ChatMessageEx))
			  eventTable[CmdId.Event_ChatMessageEx] = (Action<ChatMsgData>)eventTable[CmdId.Event_ChatMessageEx] + value;
			else
			  eventTable[CmdId.Event_ChatMessageEx] = value;
		}
      }
      remove {
		lock(eventTable){
			if (eventTable.ContainsKey(CmdId.Event_ChatMessageEx))
			  eventTable[CmdId.Event_ChatMessageEx] = (Action<ChatMsgData>)eventTable[CmdId.Event_ChatMessageEx] - value;
			else
			  eventTable[CmdId.Event_ChatMessageEx] = value;
		}
	  }
    }
      
  }

  public abstract partial class EmpyrionModBase {
        
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