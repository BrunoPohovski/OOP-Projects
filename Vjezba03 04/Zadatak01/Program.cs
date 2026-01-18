using System;

namespace Zadatak01
{
    internal static class Program
    {
        private static void Main()
        {
            PointDemo();
            ColorDemo();
            WindowDemo();
        }

        private static void WindowDemo()
        {
            var window = new Window(
                "test", 
                "label",
                new Point(10, 20), 
                new Point(30, 40), 
                new Color(100, 200, 255),
                true);
            Console.WriteLine(window);
            Console.WriteLine(window.Width);
        }

        private static void ColorDemo()
        {
            var color = new Color(100, 200, 255);
            Console.WriteLine(color);
        }

        private static void PointDemo()
        {
            var point = new Point(10, 20);
            Console.WriteLine(point);
        }
    }
}
