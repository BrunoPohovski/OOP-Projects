using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert n:");
            int n = int.Parse(Console.ReadLine());

            long f = Factorial(n);
            Console.WriteLine($"Factorial of {n} is: {f}");
        }

        private static long Factorial(int n)
        {
            // Recursive factorial function
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
