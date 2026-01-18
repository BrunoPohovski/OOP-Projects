using System;
using System.Collections.Generic;

namespace Zadatak01
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var cn1 = new ComplexNumber(1, 2);
            var cn2 = new ComplexNumber(3, 4);
            Console.WriteLine(cn1);
            
            var set = new HashSet<ComplexNumber>
            {
                cn1,
                cn2
            };

            Console.WriteLine(set.Count);
        }
    }
}