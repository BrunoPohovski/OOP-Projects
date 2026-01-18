using System;

namespace Zadatak03
{
    internal class Car : Vehicle
    {
        public Car(int number, string type, double acceleration) : base(number, type, acceleration)
        {
        }

        public override void Drive () => Console.WriteLine("Car Driving...");
        
        public override void Stop () => Console.WriteLine("Car Stopping...");
    }
}