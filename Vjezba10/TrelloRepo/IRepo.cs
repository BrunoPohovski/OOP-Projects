using System.Collections.Generic;

namespace TrelloRepo
{
    public interface IRepo
    {
        void AddItem(Item item);
        ISet<Item> GetItems();
        ISet<User> GetUsers();
        User GetUser(int id);
    }
}
