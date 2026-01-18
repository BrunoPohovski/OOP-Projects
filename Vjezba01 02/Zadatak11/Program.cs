using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = ReadString("First name: ");
            string lastName = ReadString("Last name: ");

            int nr = ReadInt("How many courses: ");

            int[] grades = new int[nr];

            FillGrades(grades);

            PrintGrades(firstName, lastName, grades);
            
        }

        private static void PrintGrades(string firstName, string lastName, int[] grades)
        {
            double sum = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == 1)
                {
                    Console.WriteLine($"{firstName} {lastName} has failed");
                    return;
                }
                sum += grades[i];
            }

            Console.WriteLine($"{firstName} {lastName}, avg: {sum / grades.Length}");
        }

        private static void FillGrades(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = ReadInt($"Insert {i + 1} grade: ", 1, 5);

            }
        }

        private static int ReadInt(string message)
        {
            int n;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out n));
            
            return n;
        }

        private static int ReadInt(string message, int min, int max)
        {
            int n;
            do
            {
                n = ReadInt(message);
            } while (n < min || n > max);
            
            return n;
        }

        private static string ReadString(string message)
        {
            string s;
            do
            {
                Console.Write(message);
                s = Console.ReadLine();
            } while (string.IsNullOrEmpty(s.Trim()));
            return s;
        }
    }
}
