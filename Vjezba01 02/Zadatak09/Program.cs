using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintArmstrongInRange(1, 100000);
        }

        private static void PrintArmstrongInRange(int fromInclusive, int toInclusive)
        {
            for (int i = fromInclusive; i <= toInclusive; i++)
            {
                if (IsArmstrong(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsArmstrong(int i)
        {
            int originalNumber = i;
            int sum = 0;
            int numDigits = i.ToString().Length;
            while (i > 0)
            {
                int digit = i % 10;
                sum += (int)Math.Pow(digit, numDigits);
                i /= 10;
            }
            return sum == originalNumber;
        }
    }
}
