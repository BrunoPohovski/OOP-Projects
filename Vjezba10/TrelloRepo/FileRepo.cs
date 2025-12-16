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
            
            /*
            string[] lines = new string[users.Count];
            if (lines == null) throw new ArgumentNullException(nameof(lines));
            int position = 0;

            foreach (var user in users)
            {
                lines[position++] = user.FormatForFileLine();
            }
            */
            
            File.WriteAllLines(UsersPath, users.Select(u => u.FormatForFileLine()));
        }

        public ISet<Item> GetItems()
        {
            ISet<Item> items = new HashSet<Item>();
            var lines = File.ReadAllLines(ItemsPath);
            
            lines.ToList().ForEach(line => items.Add(Item.ParseFromFileLine(line)));

            return items;
        }

        public ISet<User> GetUsers()
        {
            ISet<User> users = new HashSet<User>();
            var lines = File.ReadAllLines(UsersPath);
            
            lines.ToList().ForEach(line => users.Add(User.ParseFromFileLine(line)));

            return users;
        }

        public User GetUser(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}