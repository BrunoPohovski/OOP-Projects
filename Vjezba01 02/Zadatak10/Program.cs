using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers?");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            FillNumbers(numbers);
            PrintMaxSumDigits(numbers);
        }

        private static void PrintMaxSumDigits(int[] numbers)
        {
            int index = 0;
            int max = SumDigits(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (SumDigits(numbers[i]) > SumDigits(max))
                {
                    max = numbers[i];
                    index = i;
                }
            }

            Console.WriteLine($"Number with the largest sum of digits is {numbers[index]} at index {index} with a sum of {SumDigits(numbers[index])}");
        }

        private static int SumDigits(int v)
        {
            int sum = 0;
            while (v > 0)
            {
                sum += v % 10;
                v /= 10;
            }
            return sum;
        }

        private static void FillNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Insert {i + 1}. number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
