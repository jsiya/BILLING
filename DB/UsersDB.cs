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
    public class UsersDB
    {
        public ObservableCollection<User>? Users { get; set; }
        public UsersDB()
        {
            string folderPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "SourceDataFiles", "Users.json"); 
            //bu static method json-dan oxudugunu collection kimi qaytarir
            Users = JsonManager<User>.Deserializer(folderPath, Users);
        }
    }
}
