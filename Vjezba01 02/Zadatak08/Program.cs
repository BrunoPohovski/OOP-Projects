using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPrimesInRange(1, 100);

        }

        private static void PrintPrimesInRange(int fromInclusive, int toInclusive)
        {
            for (int i = fromInclusive; i <= toInclusive; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPrime(int i)
        {
            if (i < 2) return false;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
