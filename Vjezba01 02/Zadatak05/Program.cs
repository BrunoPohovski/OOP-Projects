using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoWhileDemo();
            ForDemo();
        }

        private static void ForDemo()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of the first 100 numbers is: {sum}");
        }

        private static void DoWhileDemo()
        {
            int i = 1, sum = 0;
            do
            {
                sum += i++;
            } while (i <= 100);
            Console.WriteLine($"Sum of the first {--i} numbers is: {sum}");
        }
    }
}
