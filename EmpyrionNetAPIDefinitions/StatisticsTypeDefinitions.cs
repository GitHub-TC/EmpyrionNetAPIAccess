using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eleon.Modding;

namespace EmpyrionNetAPIDefinitions
{


  public class StatisticsContainer
  {
    public StatisticsParam stats;

    public static Dictionary<StatisticsType, Type> StatTypeManifest = new Dictionary<StatisticsType, Type>() {
      { StatisticsType.CoreAdded, typeof(CoreAddedStatistics) },
      { StatisticsType.CoreRemoved, typeof(CoreRemovedStatistics) },
      { StatisticsType.PlayerDied, typeof(PlayerDiedStatistics) },
      { StatisticsType.StructDestroyed, typeof(StructureDestroyedStatistics) },
      { StatisticsType.StructOnOff, typeof(StructurePowerStatistics) },
    };

    public StatisticsContainer(StatisticsParam stats)
    {
      this.stats = stats;
    }

    private static Type[] _tparam = new Type[] { typeof(StatisticsParam) };

    public static StatisticsContainer FromStatisticsParam(StatisticsParam stats)
    {
      var type = StatTypeManifest[stats.type];
      var constructor = type.GetConstructor(_tparam);
      var result = constructor.Invoke(new object[] { stats });
      return (StatisticsContainer)result;
    }

    public static implicit operator StatisticsContainer(StatisticsParam stats)
    {
      return FromStatisticsParam(stats);
    }
  }

  public class CoreRemovedStatistics : StatisticsContainer
  {
    public Id StructureId
    {
      get
      {
        return new Id(this.stats.int1);
      }
    }

    public Id DestroyerId
    {
      get
      {
        return new Id(this.stats.int2);
      }
    }

    public Id OwnerId
    {
      get
      {
        return new Id(this.stats.int3);
      }
    }

    public CoreRemovedStatistics(StatisticsParam stats) : base(stats)
    {
    }
  }

  /// <summary>
  /// TODO: Verify this
  /// </summary>
  public class CoreAddedStatistics : StatisticsContainer
  {
    public Id StructureId
    {
      get
      {
        return new Id(this.stats.int1);
      }
    }

    public Id PlayerId
    {
      get
      {
        return new Id(this.stats.int2);
      }
    }

    public CoreAddedStatistics(StatisticsParam stats) : base(stats)
    {
    }
  }


  public class PlayerDiedStatistics : StatisticsContainer
  {
    public Id PlayerId
    {
      get
      {
        return new Id(this.stats.int1);
      }
    }

    public DeathType CauseOfDeath
    {
      get
      {
        return (DeathType)this.stats.int2;
      }
    }

    public Id KillerId
    {
      get
      {
        return new Id(this.stats.int3);
      }
    }

    public Id KillingVehicleId
    {
      get
      {
        return new Id(this.stats.int4);
      }
    }

    public PlayerDiedStatistics(StatisticsParam stats) : base(stats)
    {
    }
  }

  //  StructOnOff,    // int1: structure id, int2: changing entity id, int3: 0 = off, 1 = on


  public class StructurePowerStatistics : StatisticsContainer
  {
    public Id StructureId
    {
      get
      {
        return new Id(this.stats.int1);
      }
    }

    public Id ChangingEntityId
    {
      get
      {
        return new Id(this.stats.int2);
      }
    }

    /// <summary>
    /// 0 or 1
    /// </summary>
    public int PowerState
    {
      get
      {
        return this.stats.int3;
      }
    }

    public StructurePowerStatistics(StatisticsParam stats) : base(stats)
    {
    }
  }

  //  StructDestroyed,// int1: structure id, int2: type (0=wipe, 1=decay

  public class StructureDestroyedStatistics : StatisticsContainer
  {
    public Id StructureId
    {
      get
      {
        return new Id(this.stats.int1);
      }
    }

    public StructureDestroyType DestroyType
    {
      get
      {
        return (StructureDestroyType)this.stats.int2;
      }
    }

    public StructureDestroyedStatistics(StatisticsParam stats) : base(stats)
    {
    }
  }
}
