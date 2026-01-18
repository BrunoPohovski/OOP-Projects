using System;
using System.Globalization;

namespace Zadatak01
{
    internal class LightBulb : ISwitchable
    {
        
        public int FilamentLength { get; set; }
        public int Power { get; set; }
        public void SwitchOn() => Console.WriteLine("Light bulb is on");
        public void SwitchOff() => Console.WriteLine("Light bulb is off");

        public override string ToString() => $"Light bulb with {FilamentLength.FormatIn("mm")} of filament and {Power.FormatIn("W")} power";
    }
}