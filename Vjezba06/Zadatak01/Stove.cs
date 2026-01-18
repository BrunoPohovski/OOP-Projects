using System;

namespace Zadatak01
{
    public class Stove : ISwitchable
    {
        public enum StoveType
        {
            Electric, 
            Gas,
            Combined
        }
        public string Producer { get; set; }
        
        public StoveType Type { get; set; }
        
        public void SwitchOn() => Console.WriteLine("Stove is on");

        public void SwitchOff() => Console.WriteLine("Stove is off");

        public override string ToString() => $"Stove of type {Type} produced by {Producer}";
    }
}