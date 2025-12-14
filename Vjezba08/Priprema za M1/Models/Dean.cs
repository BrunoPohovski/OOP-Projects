namespace Priprema_za_M1.Models
{
    public class Dean : Person
    {
        public string Title { get; set; }
        
        public Dean(string firstName, string lastName, string title) : base(firstName, lastName)
        {
            Title = title;
        }

        public override string ToString()
        => base.ToString() + $", Title: {Title}";
        
        public void GiveSign (ISignable signable) => signable.Sign();
    }
}