using System;

namespace SimpleFactory;

public class Cashier
{
    public void Charge(Pizza pizza)
    {
        Console.WriteLine($"Charging {pizza.Price:F2} for {pizza.Name} pizza! {pizza.Ingredients.Count}");
    }
    
    public void PrintReceipt(Pizza pizza)
    {
        Console.WriteLine($"Receipt: {pizza.Name} - ${pizza.Price:F2}");
    }
}