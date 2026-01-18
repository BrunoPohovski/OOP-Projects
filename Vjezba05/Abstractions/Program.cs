using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Abstractions
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Figure rectangle = new Rectangle("Blue", 1, 2);
            Figure circle = new Circle("Blue", 2.5);

            IList<Figure> figures = new List<Figure>
            {
                rectangle,
                circle,
                new Triangle("Blue", 3, 4, 5)
            };

            foreach (var f in figures)
            {
                Console.WriteLine($"The area of the {f.GetType()} is: {f.Area()}cm");
                Console.WriteLine($"The perimeter of the {f.GetType()} is: {f.Perimeter()}cm");
            }


            
            Print(figures);
            Sort(figures);
        }

        private static void Sort(IList<Figure> figures)
        {
            return;
        }

        private static void Print(IList<Figure> figures)
        {
            return;
        }
    }
}