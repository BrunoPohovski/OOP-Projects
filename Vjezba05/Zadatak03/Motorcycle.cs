using System;

namespace Zadatak03
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(int number, string type, double acceleration) : base(number, type, acceleration)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Motorcycle Drive...");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle stopping...");
        }
    }
}