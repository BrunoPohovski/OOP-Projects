using System;
using System.Collections.Generic;

namespace Zadatak02
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var frog1 = new Frog ("red", 3);
            var frog2 = new Frog ("blue", 4);

            Console.WriteLine(frog1);
            Console.WriteLine(frog2);
            
            var frogs = new HashSet<Frog>{frog1, frog2};
            Console.WriteLine(frogs.Count);
        }
    }
}