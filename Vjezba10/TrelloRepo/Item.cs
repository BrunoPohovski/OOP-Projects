using System;

namespace TrelloRepo
{
    public class Item
    {
        private const string DateFormat = "dd:MM:yyyy";

        // 12:5:24
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

        public override string ToString()
        {
            return $"{Description} {Date.ToString(DateFormat)} {User}";
        }

        public override bool Equals(object obj)
        {
            return obj is User other && Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}