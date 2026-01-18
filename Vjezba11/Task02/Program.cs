using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    internal class Program
    {
        private static readonly ISet<Country> countries = new SortedSet<Country>();
        public static void Main(string[] args)
        {
            AddCountry(1, "Hrvatska");
            AddCountry(2, "Italija");
            AddCountry(3, "Engleska");
            AddCountry(5, "Hrvatska");

            ListCountries(countries);
            
            Country cro = new Country { Id = 11, Name = "Hrvatska" };
            
            cro[cro.CitiesCount()] = new City {Id = 12, Name = "Zagreb", PostOffice = 10000};
            cro[cro.CitiesCount()] = new City {Id = 1, Name = "Split", PostOffice = 21000};

            Console.WriteLine(cro["Zagreb"]);
            Console.WriteLine(cro["Split"]);
        }

        private static void ListCountries(ISet<Country> set)
        {
            countries.ToList().ForEach(Console.WriteLine);
        }

        private static void AddCountry(int id, string name)
        {
            countries.Add(new Country { Id = id, Name = name });

        }
    }
}