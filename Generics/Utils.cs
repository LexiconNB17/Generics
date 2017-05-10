using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    static class Utils
    {
        public static T Clamp<T>(T value, T min, T max) 
            where T : IComparable
        {
            var lower = Max(value, min);
            var result = Min(lower, max);
            return result;
        }

        private static T Max<T>(T v1, T v2) 
            where T : IComparable
        {
            if (v1.CompareTo(v2) < 0) return v2; 
            return v1;
        }
        private static T Min<T>(T v1, T v2) 
            where T : IComparable
        {
            if (v1.CompareTo(v2) > 0) return v2;
            return v1;
        }
    }
}
