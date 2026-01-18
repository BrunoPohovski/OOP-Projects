using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} \\ {b} = {a / b}");
        }
    }
}
