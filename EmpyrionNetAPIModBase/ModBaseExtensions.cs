using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmpyrionNetAPIAccess
{
    public static class ModBaseExtensions
    {
        public static T GetAttribute<T>(this Assembly aAssembly) => aAssembly.GetCustomAttributes(typeof(T), false).OfType<T>().FirstOrDefault();
    }
}
