using System;

namespace Priprema_za_M1.Models
{
    public class Teacher : Person
    {
        public Subject Subject { get; set; }
        public Teacher(string firstName, string lastName, Subject subject) : base(firstName, lastName)
        {
            Subject = subject;
        }

        public override string ToString()
        => base.ToString() + $", Subject: {Subject}";
    }
}