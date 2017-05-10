using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine(Utils.Clamp(1, 2, 4).GetType().Name);
            //WriteLine(Utils.Clamp(1.1, 2, 4).GetType().Name);
            //WriteLine(Utils.Clamp(3, 2.1, 4).GetType().Name);
            //WriteLine(Utils.Clamp(7, 2, 4.1).GetType().Name);

            //WriteLine((1.1).ToString());
            //WriteLine((1.2).ToString(CultureInfo.InvariantCulture));

            var isoPair = new Pair<bool>(true, false);
            var first = isoPair.First;
            var second = isoPair.Second;
            WriteLine($"pair: [{first}, {second}]");

            var pair = new Pair<int, string>(5, "hej");
            WriteLine($"pair: [{pair.First}, {pair.Second}]");

        }
    } 
}
