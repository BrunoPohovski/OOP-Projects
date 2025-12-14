using System;

namespace SimpleFactory
{
    public class Customer
    {
        public string Name { get; }

        public Customer(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void Enjoy(Pizza pizza)
        {
            if (pizza == null) throw new ArgumentNullException(nameof(pizza));
            Console.WriteLine($"{Name} is enjoying the delicious {pizza.Name} pizza!");
        }

        public override string ToString()
        {
            return $"Customer: {Name}";
        }
    }
}