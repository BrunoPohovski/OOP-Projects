using System;
using System.Collections.Generic;

namespace Zadatak02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var b1 = new Book("Ponedjeljak", "Daniel Bele", "5234567890123");
            var b2 = new Book("Praznina", "Daniel Bele", "2234567890123");
            var b3 = new Book("Void", "Imre Kertez", "2234567890123");

            var bookList = new List<Book>
            {
                b3, b1, b2
            };
            
            bookList.ForEach(Console.WriteLine);

            
            Console.WriteLine("Sorted by ISBN:");
            bookList.Sort();
            bookList.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Sorted by Title:");
            bookList.Sort(new BookTitleAscComparer());
            bookList.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Sorted by Author:");
            bookList.Sort((x, y) => string.Compare(x.Author, y.Author, StringComparison.Ordinal));
            bookList.ForEach(Console.WriteLine);
        }


    }
    
}