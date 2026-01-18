using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IDictionary<int, string> dictionary = new Dictionary<int, string>();
            AddNumbers(dictionary);
            Print(dictionary);
            
            dictionary.Keys.ToList().ForEach(Console.WriteLine);
            dictionary.Values.ToList().ForEach(Console.WriteLine);

            Console.WriteLine(dictionary.Values.Contains("Five"));
            
        }

        private static void Print(IDictionary<int, string> dictionary)
        {
            for (int i = 0; i < dictionary.Count; i++)
            {
                if (dictionary.TryGetValue(i, out var value))
                {
                    Console.WriteLine(value);
                }
            }
        }

        private static void AddNumbers(IDictionary<int, string> dictionary)
        {
            try
            {
                dictionary.Add(1, "One");
                dictionary.Add(4, "Four");
                dictionary.Add(5, "Five");
                dictionary.Add(0, "One");
                dictionary[3] = "Three";
                dictionary[5] = "Five";
                if (!dictionary.ContainsKey(1))
                {
                    dictionary.Add(1, "One");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}