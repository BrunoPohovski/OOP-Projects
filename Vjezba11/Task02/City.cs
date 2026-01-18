namespace Task02
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PostOffice { get; set; }

        public override string ToString() => $"{Name}, {PostOffice}";
    }
}