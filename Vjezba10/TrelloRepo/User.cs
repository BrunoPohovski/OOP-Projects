namespace TrelloRepo
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";

        public override bool Equals(object obj)
        {
            return obj is User other && Id == other.Id;
        }
        public override int GetHashCode()
            => Id.GetHashCode();

    }
}
