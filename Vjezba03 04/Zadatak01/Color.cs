namespace Zadatak01
{
    internal class Color
    {
        public Color(byte red, byte green, byte blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        private readonly byte _red;
        private readonly byte _green;
        private readonly byte _blue;

        public override string ToString() => $"Color({_red}, {_green}, {_blue})";
    }
}