using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TrelloRepo
{
    internal class FileRepo : IRepo
    {

        private const string UsersPath = @"C:\Users\leona\Desktop\OOP Vjezbe\Vjezba10\data\users.txt";
        private const string ItemsPath = @"C:\Users\leona\Desktop\OOP Vjezbe\Vjezba10\data\items.txt";

        public FileRepo()
        {
            CreateFilesIfNonExistent();
        }

        private void CreateFilesIfNonExistent()
        {
            if (!File.Exists(UsersPath))
            {
                File.Create(UsersPath).Close();
            }

            if (!File.Exists(ItemsPath))
            {
                File.Create(ItemsPath).Close();
            }
            
        }


        public void AddItem(Item item)
        {
            AddUser(item.User);
            ISet<Item> items = GetItems();
            items.Add(item);
            
            File.WriteAllLines(ItemsPath, items.Select(u => u.FormatForFileLine()));
        }

        private void AddUser(User itemUser)
        {
            ISet<User> users = GetUsers();
            users.Add(itemUser);
            
            File.WriteAllLines(UsersPath, users.Select(u => u.FormatForFileLine()));
        }

        public ISet<Item> GetItems()
        {
            ISet<Item> items = new HashSet<Item>();
            File.ReadAllLines(ItemsPath).
                ToList().
                ForEach(line => items.Add(Item.ParseFromFileLine(line)));

            return items;
        }

        public ISet<User> GetUsers()
        {
            ISet<User> users = new HashSet<User>();
            File.ReadAllLines(UsersPath)
                .ToList()
                .ForEach(line => users.Add(User.ParseFromFileLine(line)));

            return users;
        }

        public User GetUser(int id)
        {
            return GetUsers().FirstOrDefault(x => x.Id == id);
        }
    }
}