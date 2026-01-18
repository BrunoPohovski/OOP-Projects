namespace Abstractions
{
    internal class Rectangle : Figure
    {
        public Rectangle(string color, double a, double b) : base(color)
        {
            A = a;
            B = b;
        }


        private double A { get; set; }
        private double B { get; set; }

        public override double Area() => A * B;

        public override double Perimeter() =>  2 * (A + B);
    }
}