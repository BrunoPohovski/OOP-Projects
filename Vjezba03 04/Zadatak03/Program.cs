using System;

namespace Zadatak03
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var f1 = ReadFraction("Insert first fraction: ");
            var f2 = ReadFraction("Insert second fraction: ");

            Console.WriteLine($"{f1} + {f2} = {f1.Add(f2)}");
            Console.WriteLine($"{f1} - {f2} = {f1.Subtract(f2)}");
            Console.WriteLine($"{f1} * {f2} = {f1.Multiply(f2)}");
            Console.WriteLine($"{f1} / {f2} = {f1.Divide(f2)}");
        }

        private static Fraction ReadFraction(string message)
        {
            Fraction fraction;
            do
            {
                Console.WriteLine(message);
            } while (!Fraction.TryParse(Console.ReadLine(), out fraction));

            return fraction;
        }
    }
}