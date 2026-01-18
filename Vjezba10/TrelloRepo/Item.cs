   using System;

namespace TrelloRepo
{
    // Public so consumers outside the repository assembly (e.g., console app)
    // can construct and read items.
    public class Item
    {
        private const char Delimiter = '|';

        // Constant date format keeps ToString output consistent without re-allocating
        // the format string each time.
        private const string DateFormat = "dd:MM:yyyy";

        // Auto-properties keep the data model lightweight; public so callers can
        // populate items before handing them to the repo.
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

        public override string ToString()
        {
            // String interpolation leverages the shared DateFormat and the user's
            // own ToString for readable console output.
            return $"{Description} {Date.ToString(DateFormat)} {User}";
        }
        
        public string FormatForFileLine() 
            => $"{Id}{Delimiter}{Description}{Delimiter}{Date.ToString(DateFormat)}{Delimiter}{User.FormatForFileLine()}";

        public static Item ParseFromFileLine(string line)
        {
            var parts = line.Split(Delimiter);
            return new Item 
            { 
                Id = int.Parse(parts[0]), 
                Description = parts[1], 
                Date = DateTime.ParseExact(parts[2], DateFormat, null), 
                User = User.ParseFromFileLine(parts[3]) 
            };
        }

        public override bool Equals(object obj)
        {
            // Equality based on ID so two items with the same identity compare
            // equal even if other fields differ. The type check currently targets
            // User, which likely should be Item if item equality is intended.
            return obj is Item other && Id == other.Id;
        }

        public override int GetHashCode()
        {
            // HashCode aligned with Equals: derived from id only.
            return Id.GetHashCode();
        }
    }
}