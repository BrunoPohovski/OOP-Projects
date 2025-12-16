using System.Collections.Generic;

namespace TrelloRepo
{
    // Public contract so consumers can depend on an abstraction and swap
    // implementations (e.g., in-memory vs. database) without changing callers.
    public interface IRepo
    {
        // Accepts fully-built item to keep repository focused on persistence rather
        // than construction concerns.
        void AddItem(Item item);
        // Exposes a set to preserve uniqueness semantics; callers get a copy so
        // implementations stay encapsulated.
        ISet<Item> GetItems();
        ISet<User> GetUsers();
        User GetUser(int id);
    }
}
