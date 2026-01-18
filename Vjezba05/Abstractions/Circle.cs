using System;

namespace Abstractions
{
    public class Circle : Figure
    {
        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double Area() =>  Radius * Radius * Math.PI;

        public override double Perimeter() =>   2 * Radius * Math.PI;
    }
}