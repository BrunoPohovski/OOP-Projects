using System;
using System.Linq;
using TrelloRepo;

namespace ConsoleClient
{
    internal class Program
    {
        private static readonly IRepo repo = RepoFactory.GetRepo();
        static void Main(string[] args)
        {
            FillItems();
            ReadItems();
            Console.WriteLine();
            ReadUsers();
            Console.WriteLine();
            ReadSingleUser();
        }

        private static void FillItems()
        {
            repo.AddItem(
                new Item
                {
                    Date = DateTime.Now.AddDays(-2),
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
            repo.AddItem(
                new Item
                {
                    Date = DateTime.Now.AddDays(-1),
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
            repo.AddItem(
                new Item
                {
                    Date = DateTime.Now,
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

            repo.GetUsers().Clear();
            repo.GetItems().Clear();
        }

        private static void ReadItems()
        => repo.GetItems().ToList().ForEach(Console.WriteLine);

        private static void ReadUsers()
        => repo.GetUsers().ToList().ForEach(Console.WriteLine);

        private static void ReadSingleUser()
        {
            Console.WriteLine(repo.GetUser(2));
        }
    }
}
