using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Priprema_za_M1.Models;

namespace Priprema_za_M1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var s1 = new Student("Leonard", "Nadal", Student.StudentType.Regular);
            var s2 = new Student("Michael", "Jackson", Student.StudentType.PartTime);
            var s3 = new Student("Matthew", "McConaughey", Student.StudentType.Regular);
            
            var students = new List<Student>
            {
                s1, s2, s3
            };

            students.ForEach(Console.WriteLine);
            

            Console.WriteLine("Sorted:");
            students.Sort();
            students.ForEach(Console.WriteLine);
            
            Console.WriteLine("Sorted by Last Name:");
            students.Sort((x, y) => string.Compare(x.LastName, y.LastName, StringComparison.Ordinal));
            students.ForEach(Console.WriteLine);
            
            var subject = new Subject(10, "CS101", "Introduction to Programming");
            Console.WriteLine(subject);
            
            var assistant = new Teacher("Mark", "Jacobs", subject);
            var professor = new Teacher("George", "Lucas", subject);

            Console.WriteLine(assistant);
            Console.WriteLine(professor);

            var dean = new Dean("James", "Dean", "Dr.");
            
            
            var people = new List<Person>
            {
                dean, assistant, professor, s1, s2, s3
            };

            Console.WriteLine($"Total number of people is {people.Count}");
            
            var document = new Document("123456789", "Report.pdf");
            
            Console.WriteLine(document);
            
            var signables = new List<ISignable>
            {
                subject, document
            };
            
            signables.ForEach(dean.GiveSign);
            signables.ForEach(Console.WriteLine);
            
            
        }
    }
}

