using System;

namespace Abstractions
{
    public class Triangle : Figure
    {
        public Triangle(string color, double a, double b, double c) : base(color)
        {
            A = a;
            B = b;
            C = c;
        }

        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }




        public override double Area()
        {
            var s = Perimeter() / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override double Perimeter() => A + B + C;
    }
}