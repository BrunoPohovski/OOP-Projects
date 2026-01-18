using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y')
            {
                Console.Clear();
                Console.WriteLine("Insert a: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert b: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Insert operator:");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        if (b != 0)
                        {
                            Console.WriteLine($"{a} / {b} = {a / b}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero!");
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Unknown operator!");
                        break;
                }

                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                again = Console.ReadKey().KeyChar;
            }
        }
    }
}
