using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Task01
{
    internal class Program
    {
        private const char Delimiter = ',';
        public static void Main(string[] args)
        {
            ISet<int> setA;
            do
            {
                Console.WriteLine("Insert elements for A: ");
            } while (!TryParse(Console.ReadLine(), out setA));            
            
            ISet<int> setB;
            do
            {
                Console.WriteLine("Insert elements for B: ");
            } while (!TryParse(Console.ReadLine(), out setB));

            IEnumerable<int> union = setA.Union(setB);
            
            Print("A union B = ", union);
            Print("A intersect B = ", setA.Intersect(setB));
            Print("A except B = ", setA.Except(setB));

            Console.WriteLine(setA.IsSubsetOf(setB) ? "A is subset of B" : "A is not subset of B");
            Console.WriteLine(setA.IsSupersetOf(setB) ? "A is superset of B" : "A is not superset of B");
            
        }

        private static void Print(string message, IEnumerable<int> elements)
        {
            Console.WriteLine($"{message}{{{string.Join(Delimiter.ToString(CultureInfo.InvariantCulture), elements)}}}");
            
        }

        private static bool TryParse(string line, out ISet<int> set)
        {
            set = new HashSet<int>();
            
            string[] parts = line.Split(Delimiter);

            
            foreach (string part in parts)
            {
                try
                {
                    if (!set.Add(int.Parse(part)))
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            
            
            return true;
        }
    }
}