using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleFactory;

public class Order
{
    private readonly List<IMenuItem> _items = new List<IMenuItem>();
    public IReadOnlyList<IMenuItem> Items => _items.AsReadOnly();

    public void AddItem(IMenuItem item)
    {
        _items.Add(item ?? throw new ArgumentNullException(nameof(item)));
        Console.WriteLine($"Added {item.Name} to order.");
    }

    public double GetTotal()
    {
        return _items.Sum(item => item.Price);
    }

    public void PrintOrder()
    {
        Console.WriteLine("\n======== ORDER SUMMARY ==========");
        foreach (var item in _items)
        {
            Console.WriteLine($"- {item}");
        }

        Console.WriteLine($"Total: {GetTotal():F2}");
        Console.WriteLine("======================\n");
    }
}