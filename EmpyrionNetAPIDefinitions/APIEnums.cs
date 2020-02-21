using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpyrionNetAPIDefinitions
{
    public enum LogLevel
    {
        Debug,
        Message,
        Error
    }

    /// <summary>
    /// For tracking the entity types in EntitySpawnInfo and GlobalStructureInfo
    /// </summary>
    public enum EntityType : int
    {
        Unknown = 0,
        Player = 1,
        BA = 2,
        CV = 3,
        SV = 4,
        HV = 5,
        AstRes = 6,
        AstVoxel = 7,
        EscapePod = 8,
        Animal = 9,
        Turret = 10,
        Item = 11,
        PlayerDrone = 12,
        Trader = 13,
        UndergroundRes = 14,
        EnemyDrone = 15,
        PlayerBackpack = 16,
        DropContainer = 17,
        ExplosiveDevice = 18,
        PlayerBike = 19,
        PlayerBikeFolded = 20,
        Asteroid = 21,
        Civilian = 22,
        Cyborg = 23,
        TroopTransport = 24
    }

    /// <summary>
    /// For tracking the faction groups in EntitySpawnInfo and GlobalStructureInfo
    /// </summary>
    public enum FactionGroups : byte
    {
        Faction = 0,
        Player = 1,
        Alien = 2,
        Predator = 3,
        Prey = 4,
        Admin = 5
    }

    /// <summary>
    /// Used to track the values associated with cores
    /// </summary>
    public enum CoreType : byte
    {
        No_Core = 0,
        Player_Core = 1,
        Admin_Core = 2,
        Alien_Core = 3,
        Admin_Alien_Core = 4
    }


    /// <summary>
    /// Used to set message priority and alert/sound
    /// </summary>
    public enum MessagePriorityType : byte
    {
        Alarm = 0,
        Message = 1,
        Info = 2
    }


    /// <summary>
    /// Tracks the type values on StatisticsParam 
    /// </summary>
    //public enum StatisticsType
    //{
    //  CoreRemoved,    // int1: structure id, int2: destryoing entity id, int3: (optional) controlling entity id
    //  CoreAdded,      // int1: structure id, int2: destryoing entity id, int3: (optional) controlling entity id
    //  PlayerDied,     // int1: player entity id, int2: death type (Unknown = 0,Projectile = 1,Explosion = 2,Food = 3,Oxygen = 4,Disease = 5,Drowning = 6,Fall = 7,Suicide = 8), int3: (optional) other entity involved, int4: (optional) other entity CV/SV/HV id
    //  StructOnOff,    // int1: structure id, int2: changing entity id, int3: 0 = off, 1 = on
    //  StructDestroyed,// int1: structure id, int2: type (0=wipe, 1=decay)
    //}

    /// <summary>
    /// Tracks the values associated with player permissioning
    /// </summary>
    public enum PermissionType : byte
    {
        Player = 0,
        GameMaster = 3,
        Moderator = 6,
        Admin = 9
    }

    public enum StructureDestroyType : int
    {
        Wipe = 0,
        Decay = 1
    }

    public enum ChatMessageType : byte
    {
        PlayerToFaction = 7,
        PlayerToPlayer = 8,
        PlayerToServer = 9
    }

    public enum DeathType : int
    {
        Unknown = 0,
        Projectile = 1,
        Explosion = 2,
        Food = 3,
        Oxygen = 4,
        Disease = 5,
        Drowning = 6,
        Fall = 7,
        Suicide = 8
    }
}
