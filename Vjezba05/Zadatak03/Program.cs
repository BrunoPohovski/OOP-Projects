using System;
using System.Collections.Generic;

namespace Zadatak03
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var car = new Car(1, "BMW", 10);
            car.Drive();
            car.Stop();

            Console.WriteLine(car);

            Console.WriteLine("----------");
            
            var sportsCar = new SportsCar(2, "Mercedes", 15, true);
            
            sportsCar.Drive();
            sportsCar.Stop();
            sportsCar.Drift();
            
            Console.WriteLine(sportsCar);
            Console.WriteLine("-----------");
            
            Car car2 = sportsCar;
            car2.Drive();
            car2.Stop();
            Console.WriteLine(car2);
            Console.WriteLine("-----------");
            
            //((SportsCar) car2).Drift(); // This only works because we cast what was a SportsCar to begin with
            
            
            IList<Vehicle> list = new List<Vehicle>
            {
                car, 
                sportsCar,
                new Motorcycle(122, "Punch", 20)
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
                item.Drive();
            }
            
            // What is the difference between foreach and .ForEach? Answer: foreach is a foreach loop, ForEach is a method
        }
    }
}