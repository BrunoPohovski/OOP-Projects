using System;

namespace Priprema_za_M1.Models
{
    internal class Student : Person, IComparable<Student>
    {
        public enum StudentType
        {
            PartTime,
            Regular
        }

        private readonly int _id;
        private static int _counter;

        public StudentType Type { get; set; }
        public Student(string firstName, string lastName, StudentType type) : base(firstName, lastName)
        {
            _id = ++_counter;
            Type = type;
        }

        public override string ToString()
        {
            return base.ToString() + $", Id: {_id}, Type: {Type}" ;
        }

        public override bool Equals(object obj) 
            => obj is Student other && _id == other._id;

        public override int GetHashCode() => _id.GetHashCode();
        
        
        public int CompareTo(Student other)
        {
            return _id.CompareTo(other._id);
        }
    }
}