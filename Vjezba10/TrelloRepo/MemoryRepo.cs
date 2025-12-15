using System.Collections.Generic;
using System.Linq;


namespace TrelloRepo
{
    internal class MemoryRepo : IRepo
    {
        private readonly ISet<Item> items = new HashSet<Item>();
        private readonly ISet<User> users = new HashSet<User>();
        public void AddItem(Item item)
        {
            users.Add(item.User);
            items.Add(item);
        }

        public ISet<Item> GetItems() => new HashSet<Item>(items);// !!!!!!

        public User GetUser(int id)
        => users.FirstOrDefault(x => x.Id == id);

        public ISet<User> GetUsers() => new HashSet<User>(users);
    }
}
