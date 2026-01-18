using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    public class Country : IComparable<Country>
    {
        private readonly IList<City> _cities = new List<City>();
        public int Id { get; set; }
        public string Name { get; set; }


        public int CompareTo(Country other)
        => string.Compare(Name, other.Name, StringComparison.Ordinal);

        public override string ToString() => $"{Id}, {Name}";

        public int CitiesCount() => _cities.Count;

        public City this[int index]
        {
            get => _cities[index];
            set => _cities.Insert(index, value);
        }        
        
        public City this[string cityName]
        {
            get => _cities.FirstOrDefault(c => c.Name == cityName);
        }
    }
}