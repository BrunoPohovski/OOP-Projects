using System;
using System.Globalization;

namespace Zadatak03
{
    internal class SportsCar : Car
    {
        public SportsCar(int number, string type, double acceleration, bool roofWindow) : base(number, type, acceleration)
        {
            RoofWindow = roofWindow;
        }

        private bool RoofWindow { get; set; }
        
        public void Drift() => Console.WriteLine("Sports Car Drift...");

        public override void Drive() => Console.WriteLine("Sports Car Driving...");
        public override void Stop() => Console.WriteLine("Sports Car Stopping...");

        public override string ToString() => $"{base.ToString()} Roof Window: {(RoofWindow ? "Yes" : "No")}";
    }
}