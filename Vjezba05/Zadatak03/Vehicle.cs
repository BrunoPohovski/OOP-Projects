namespace Zadatak03
{
    public abstract class Vehicle
    {
        protected Vehicle(int number, string type, double acceleration)
        {
            Number = number;
            Type = type;
            Acceleration = acceleration;
        }

        private int Number { get; set; }
        private string Type { get; set; }
        private double Acceleration { get; set; }

        public abstract void Drive();
        public abstract void Stop();
        public override string ToString() 
            => $"Number: {Number} {Type} with {Acceleration} acceleration";
        
    }
}