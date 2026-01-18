using System;

namespace Zadatak03
{
    /// <summary>
    /// Represents a mathematical fraction with a numerator and a denominator.
    /// </summary>
    internal class Fraction
    {
        private const char Delimeter = '/';

        public Fraction(int numerator, int denominator)
        {
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            int greatestCommonDivisor = GreatestCommonDivisor(numerator, denominator);
            Numerator = numerator / greatestCommonDivisor;
            Denominator = denominator / greatestCommonDivisor;
        }

        private int GreatestCommonDivisor(int numerator, int denominator)
        {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
                while (denominator != 0)
                {
                    int temp = denominator;
                    denominator = numerator % denominator;
                    numerator = temp;
                }
                return numerator;
        }


        public int Numerator { get; }
        private int denominator;

        public int Denominator
        {
            get => denominator;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0.");
                }
                denominator = value;
            }
        }

        public override string ToString()
        => Denominator == 1 || Numerator == 0 
                ? $"{Numerator}" 
                : $"{Numerator}{Delimeter}{Denominator}";
        
        
        public Fraction Multiply(Fraction other)
            => new Fraction(Numerator * other.Numerator, Denominator * other.Denominator);
        
        public static Fraction operator *(Fraction left, Fraction right)
            => left.Multiply(right);
        
        
        public Fraction Divide(Fraction other)
            => new Fraction(Numerator * other.Denominator, Denominator * other.Numerator);
        
        
        public static Fraction operator /(Fraction left, Fraction right)
            => left.Divide(right);
        
        public Fraction Add(Fraction other)
        => new Fraction(Numerator * other.Denominator + Denominator * other.Numerator, Denominator * other.Denominator);
        
        public static Fraction operator +(Fraction left, Fraction right)
            => left.Add(right);
        
        public Fraction Subtract(Fraction other)
        => new Fraction(Numerator * other.Denominator - Denominator * other.Numerator, Denominator * other.Denominator);
        
        public static Fraction operator -(Fraction left, Fraction right)
            => left.Subtract(right);
        

        public static bool TryParse(string readLine, out Fraction f)
        {
            f = null;
            var split = readLine.Split(Delimeter);
            
            if (split.Length == 0)
                return false;
            
            if (split.Length > 2)
                return false;
            
            if (!int.TryParse(split[0], out int numerator))
                return false;
            int denominator = 1;
            if (split.Length == 2 && !int.TryParse(split[1], out denominator))
                return false;

            if (denominator == 0)
                return false;
            
            f = new Fraction(numerator, denominator);
            
            return true;
        }
    }
}