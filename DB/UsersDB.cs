using BILLING.Models;
using BILLING.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILLING.DB
{
    public class UsersDB : IRepository<User>
    {
        public ObservableCollection<User>? Users { get; set; }
        public UsersDB()
        {
            string folderPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "SourceDataFiles", "Users.json"); 
            //bu static method json-dan oxudugunu collection kimi qaytarir
            Users = JsonManager<User>.Deserializer(folderPath, Users);
        }

        public User? Get(Func<User, bool> predicate)
        {
            foreach(var user in Users)
            {
                if(predicate(user)) return user;
            }
            return null;
        }

        public IList<User>? GetList(Func<User, bool>? predicate = null)
        {
            if (predicate == null) return Users;
            IList<User>? list = new List<User>();
            foreach(var user in Users)
            {
                if(predicate(user)) list.Add(user);
            }
            return list;
        }

        public void Add(User entity)
        {
            User newUser = entity;
            if (newUser != null) Users.Add(newUser);
            JsonManager<User>.
                Serializer(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName,
                "SourceDataFiles", "Users.json"), Users);
        }

        public void Update(User entity)
        {
            foreach(User user in Users)
            {
                if(user.Id == entity.Id)
                {
                    user.Username = entity.Username;
                    user.Password = entity.Password;
                    user.Name = entity.Name;
                    user.Surname = entity.Surname;
                    break;
                }
            }
            JsonManager<User>.
                Serializer(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName,
                "SourceDataFiles", "Users.json"), Users);
        }

        public void Remove(User entity)
        {
            Users.Remove(entity);
            JsonManager<User>.
                Serializer(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName,
                "SourceDataFiles", "Users.json"), Users);
        }
    }
}
