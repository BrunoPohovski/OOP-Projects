using System;

namespace Zadatak01
{
    internal class Point
    {
        private const double MinValue = 0;
        private const double MaxValue = 100;
        
        private double _x;
        private double _y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X
        {
            get => _x;
            set
            {
                ValidateCoordinate(value, nameof(X));
                _x = value;
            }
        }

        public double Y
        {
            get => _y;
            set
            {
                ValidateCoordinate(value, nameof(Y));
                _y = value;
            }
        }

        private static void ValidateCoordinate(double value, string coordinateName)
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentOutOfRangeException(coordinateName, 
                    $"{coordinateName} must be between {MinValue} and {MaxValue}.");
            }
        }

        public override string ToString() => $"Point({X}, {Y})";
    }
}
