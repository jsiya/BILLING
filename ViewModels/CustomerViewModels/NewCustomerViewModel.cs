using BILLING.DB;
using BILLING.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BILLING.ViewModels.CustomerViewModels;

public class NewCustomerViewModel: INotifyPropertyChanged
{
    public Frame InnerFrame2 { get; set; } //s-search ve new hissesindeki frame
    public Frame InnerFrame1 { get; set; } //s-mainmenudaki sag teref
    public Frame MainFrame { get; set; }
    public ObservableCollection<Customer>? Customers { get; set; }


    private Customer _newCustomer;
    public Customer NewCustomer
    {
        get { return _newCustomer; }
        set 
        { 
            _newCustomer = value;
            OnPropertyChanged();
        }
    }


    public NewCustomerViewModel()
    {
        NewCustomer = new();
        CustomersDB db=new CustomersDB();
        Customers = db?.Customers;
    }  
    
    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
