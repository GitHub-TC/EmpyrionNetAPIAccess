using System.Linq;
using System.Reflection;

namespace EmpyrionNetAPIAccess
{
    public static class ModBaseExtensions
    {
        public static T GetAttribute<T>(this Assembly aAssembly) => aAssembly.GetCustomAttributes(typeof(T), false).OfType<T>().FirstOrDefault();
    }
}
