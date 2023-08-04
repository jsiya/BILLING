using BILLING.DB;
using BILLING.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILLING.ViewModels.CustomerViewModels;

public class SearchCustomerViewModel
{
    public ObservableCollection<Customer>? AllCustomers { get; set; }
    public SearchCustomerViewModel()
    {
        CustomersDB db = new CustomersDB();
        AllCustomers = db?.Customers;
    }
}
