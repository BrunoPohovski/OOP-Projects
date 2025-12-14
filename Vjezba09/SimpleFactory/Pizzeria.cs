using System;

namespace SimpleFactory;

public class Pizzeria
{
    public static void Prepare(IPreparable item)
    {
        item.Prepare();
    }
    
    public static void Cook(ICookable item)
    {
        item.Cook();
    }
    public static void Serve(Pizza item)
    {
        Console.WriteLine($"Serving hot {item.Name} pizza!");
    }
}