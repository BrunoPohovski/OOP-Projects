using System.Linq;

namespace Zadatak01
{
    public static class Extensions
    {
        public static string FormatIn(this int value, string format) => $"{value}{format}";
    }
}