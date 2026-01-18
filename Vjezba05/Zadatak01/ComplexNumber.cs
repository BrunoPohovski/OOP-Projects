namespace Zadatak01
{
    internal class ComplexNumber
    {
        public ComplexNumber(int im, int re)
        {
            Im = im;
            Re = re;
        }

        private int Re { get; }
        private int Im { get; }

        public override string ToString() => $"{Re} {(Im >= 0 ? "+" : "")} {Im}i";
        public override bool Equals(object obj)
        {
            if (!(obj is ComplexNumber number)) return false;
            return Re == number.Re && Im == number.Im;
        }

        protected bool Equals(ComplexNumber other)
        {
            return Re == other.Re && Im == other.Im;
        }

        public override int GetHashCode() => Re.GetHashCode() * 31 / Im.GetHashCode();
    }
}