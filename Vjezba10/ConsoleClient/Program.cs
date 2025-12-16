using System;
using System.Linq;
using TrelloRepo;

namespace ConsoleClient
{
    // Internal keeps the demo console entry point scoped to this assembly; no need
    // for external visibility because only the executable hosts Main.
    internal class Program
    {
        // Static so a single repository instance is shared across all helpers in
        // this class; readonly because we don't want the reference swapped after
        // the initial factory creation.
        private static readonly IRepo Repo = RepoFactory.GetRepo();
        static void Main(string[] args)
        {
            // Each step showcases a different repository call so you can see the
            // effects of the in-memory storage.
            FillItems();
            ReadItems();
            Console.WriteLine();
            ReadUsers();
            Console.WriteLine();
            ReadSingleUser();
        }

        // Seeds a couple of items/users to exercise the repository API.
        private static void FillItems()
        {
            Repo.AddItem(
                new Item
                {
                    Date = DateTime.Now.AddDays(-2), // Backdate to show ordering
                    Description = "First",
                    Id = 1,
                    User = new User
                    {
                        Id = 1,
                        FirstName = "Lazo",
                        LastName = "Goluza"
                    }
                }

                );
            Repo.AddItem(
                new Item
                {
                    Date = DateTime.Now.AddDays(-1), // Different date, new user
                    Description = "Second",
                    Id = 2,
                    User = new User
                    {
                        Id = 2,
                        FirstName = "Robert",
                        LastName = "MeDiro"
                    }
                }

                );
            Repo.AddItem(
                new Item
                {
                    Date = DateTime.Now, // Today, but the same user as previous
                    Description = "Third",
                    Id = 3,
                    User = new User
                    {
                        Id = 2,
                        FirstName = "Robert",
                        LastName = "MeDiro"
                    }
                }

                );

            Repo.GetUsers().Clear();
            Repo.GetItems().Clear();
        }

        // Expression-bodied helper keeps console output simple and linear.
        private static void ReadItems()
        => Repo.GetItems().ToList().ForEach(Console.WriteLine);

        // Same as above, but for users.
        private static void ReadUsers()
        => Repo.GetUsers().ToList().ForEach(Console.WriteLine);

        // Demonstrates the single-user lookup.
        private static void ReadSingleUser()
        {
            Console.WriteLine(Repo.GetUser(2));
        }
    }
}
