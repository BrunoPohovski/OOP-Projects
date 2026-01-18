using System;

namespace Zadatak02
{
    public class Frog : IEquatable<Frog>
    {
        public string Color { get; }
        public int Legs { get; }

        public Frog(string color, int legs)
        {
            Color = color ?? throw new ArgumentNullException(nameof(color));
            if (legs <= 0)
                throw new ArgumentOutOfRangeException(nameof(legs), "Legs must be positive");
            Legs = legs;
        }

        public override string ToString()
        => $"{Color} frog with {Legs} legs";

        public bool Equals(Frog other)
        {
            if (other == null) return false;
            return Color == other.Color && Legs == other.Legs;
        }

        public override bool Equals(object obj)
            => obj is Frog frog && Equals(frog);

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Color?.GetHashCode() ?? 0) * 397) ^ Legs.GetHashCode();
            }
        }
        
        public static bool operator ==(Frog left, Frog right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        public static bool operator !=(Frog left, Frog right)
        {
            return !(left == right);
        }
    }
}