namespace Abstractions
{
    public abstract class Figure
    {
        protected Figure(string color)
        {
            Color = color;
        }

        public string Color { get; set; }

        public abstract double Area();
        public abstract double Perimeter();
    }
}