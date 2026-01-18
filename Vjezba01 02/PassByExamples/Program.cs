using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByExamples
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int i = 1;
            PassByValue(i);
            Console.WriteLine($"Main {i}");

            int j = 1;
            PassByRef(ref j);
            Console.WriteLine($"Main {j}");

            PassByOut(out int k);
            Console.WriteLine($"Main {k}");

            List<int> l = new List<int>();
            PassByReference(l);
            Console.WriteLine($"Main, Ref: {l.Count}");
        }

        private static void PassByReference(List<int> l)
        {
            l.Add(100);
            Console.WriteLine($"PassByReference, Ref: {l.Count}");
        }

        private static void PassByOut(out int k)
        {
            k = 1;
            k++;
            Console.WriteLine($"PassByOut {k}");
        }

        private static void PassByRef(ref int j)
        {
            j++;
            Console.WriteLine($"PassByReference {j}");
        }

        private static void PassByValue(int i)
        {
            i++;
            Console.WriteLine($"PassByValue {i}");
        }
    }
}
