using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BILLING.Models
{
    public class NewRequest : INotifyPropertyChanged 
    {
        public void INotify([CallerMemberName] string? a = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(a));
        }
        private short _id;
        private string? _name;
        private string? _surname;
        private string? _loc;
        private string? _phone;

        public short Id { get => _id;
            set { _id = value;   INotify(); }
        }
        public string? Name 
        {
            get => _name;
            set { _name = value; INotify(); }
        } 
       
        public string? Surname
        {
            get => _surname ;
            set { _surname = value; INotify(); }
        }
        public string? Location
        {
            get => _loc;
            set { _loc = value; INotify(); }
        }
        public string? Phone
        {
            get => _phone;
            set { _phone = value; INotify(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}



/*
  public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
 */