namespace TrelloRepo
{
    // Public so callers can construct users outside the repository assembly.
    public class User
    {
        private const char Delimiter = '#';
        // Simple POCO with auto-properties to keep the model minimal.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Expression-bodied ToString for concise display in console output.
        public override string ToString() => $"{FirstName} {LastName}";
        public string FormatForFileLine() => $"{Id}{Delimiter}{FirstName}{Delimiter}{LastName}";

        public static User ParseFromFileLine(string line)
        {
            var parts = line.Split(Delimiter);
            return new User
            {
                Id = int.Parse(parts[0]), 
                FirstName = parts[1], 
                LastName = parts[2]
            };
        }

        public override bool Equals(object obj)
        {
            // Equality is identity-based; two user instances with the same ID compare equal.
            return obj is User other && Id == other.Id;
        }
        public override int GetHashCode()
            // HashCode mirrors Equals by using only id.
            => Id.GetHashCode();

    }
}
