using System.Collections.Generic;
using System.Linq;


namespace TrelloRepo
{
    // Internal keeps this demo-only repository hidden from outside assemblies; the
    // factory exposes it via the IRepo abstraction instead.
    internal class MemoryRepo : IRepo
    {
        // HashSet enforces uniqueness by Id (per Equals/GetHashCode overrides).
        // readonly so the collection references cannot be replaced after creation.
        private readonly ISet<Item> items = new HashSet<Item>();
        private readonly ISet<User> users = new HashSet<User>();
        public void AddItem(Item item)
        {
            // Add user first so lookups succeed even if multiple items share the user.
            users.Add(item.User);
            items.Add(item);
        }

        // Returns a copy to avoid leaking the internal set reference (callers
        // can't mutate our internal storage).
        public ISet<Item> GetItems() => new HashSet<Item>(items);// !!!!!!

        public User GetUser(int id)
        => users.FirstOrDefault(x => x.Id == id);

        // Same defensive copy pattern for users.
        public ISet<User> GetUsers() => new HashSet<User>(users);
    }
}
