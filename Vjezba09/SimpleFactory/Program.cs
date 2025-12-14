using System;

namespace SimpleFactory
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to the Pizzeria ===\n");

            // Create dependencies
            var pizzeria = new Pizzeria();
            var cashier = new Cashier();
            var customer = new Customer("John");

            // Create an order
            var order = new Order();

            // Customer orders pizzas
            Pizza margherita = PizzaFactory.CreateMargherita();
            Pizza pepperoni = PizzaFactory.CreatePepperoni();
            
            order.AddItem(margherita);
            order.AddItem(pepperoni);

            // Display order
            order.PrintOrder();

            // Process each pizza
            foreach (var item in order.Items)
            {
                if (item is Pizza pizza)
                {
                    Console.WriteLine($"\n--- Processing {pizza.Name} ---");
                    Pizzeria.Prepare(pizza); 
                    Pizzeria.Cook(pizza);
                    Pizzeria.Serve(pizza);
                }
            }

            // Payment
            Console.WriteLine();
            cashier.Charge(margherita);
            cashier.Charge(pepperoni);
            cashier.PrintReceipt(margherita);
            cashier.PrintReceipt(pepperoni);

            // Customer enjoys
            foreach (var item in order.Items)
            {
                if (item is Pizza pizza)
                {
                    customer.Enjoy(pizza);
                }
            }

            Console.WriteLine("\n=== Thank you for visiting! ===");
        }
    }
}