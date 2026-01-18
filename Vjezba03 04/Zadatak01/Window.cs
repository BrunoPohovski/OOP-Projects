using System;

namespace Zadatak01
{
    internal class Window
    {
        public Window(string title, string label, Point topLeft, Point bottomRight, Color color, bool isActive)
            : this(title, topLeft, bottomRight, color)
        {
            Label = label;
            IsActive = isActive;
        }
        public Window(string title, Point topLeft, Point bottomRight, Color color) 
            : this(title)
        {
            TopLeft = topLeft ?? new Point(0, 0);
            BottomRight = bottomRight ?? new Point(80, 80);
            Color = color ?? new Color(255, 255, 255); // Default white
        }
        public Window(string title)
        {
            Title = title;
        }

        public Window() : this("New Window")
        {
            TopLeft = new Point(0, 0);
            BottomRight = new Point(80, 80);
            Color = new Color(255, 255, 255);
        }

        public string Title { get; set; }
        public string Label { get; set; }
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Color Color { get; set; }
        public bool IsActive { get; set; }

        public int Width => (int)Math.Abs(BottomRight.X - TopLeft.X);
        public int Height => (int)Math.Abs(BottomRight.Y - TopLeft.Y);
        public int Area => Width * Height;
        public int Perimeter => 2 * (Width + Height);

        public override string ToString()
            => $"Window({Title}, {Label}, {TopLeft}, {BottomRight}, {Color}, {(IsActive ? "active" : "not active")})";
    }
}