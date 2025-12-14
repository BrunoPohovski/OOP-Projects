using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleFactory
{
    public class Pizza : IMenuItem, ICookable, IPreparable
    {
        public Pizza(string name, double price, List<Ingredient> ingredients)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            
            if (price <= 0) throw new ArgumentException("Price must be greater than zero!", nameof(price));
            if (ingredients == null || !ingredients.Any()) 
                throw new ArgumentException("Ingredients list must not be empty!", nameof(ingredients));
            
            Price = price;
            Ingredients = new List<Ingredient>(ingredients);
        }

        public enum Ingredient
        {
            Cheese,
            Pepperoni,
            Veggies,
            Tomato,
            Salami
        }
        
        public string Name { get;} 
        public double Price { get;}
        public IReadOnlyList<Ingredient> Ingredients { get; }
        
        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name} pizza with ingredients: {string.Join(", ", Ingredients)}");
        }
        
        public void Cook()
        {
            Console.WriteLine($"Cooking {Name} pizza in the oven...");
        }

        public override string ToString()
            => $"{Name} Pizza ($ {Price:F2})";
    }
}