namespace Zadatak02
{
    public class Student
    {
        public Student(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        
        public Student() : this("Pero", "Peric")
        {
        }

        private string Name { get; set; }
        private string LastName { get; set; }
        public int YearOfStudy { get; set; }
        public double Average { get; set; }


        public override string ToString()
        => $"{Name} {LastName} {YearOfStudy} Year {Average} Average";
    }
}