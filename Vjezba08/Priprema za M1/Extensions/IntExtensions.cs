namespace Priprema_za_M1.Extensions
{
    public static class IntExtensions
    {
        public static string Format(this int number, string format) => number.ToString(format);
    }
}