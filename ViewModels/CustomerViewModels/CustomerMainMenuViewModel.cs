using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using BILLING.Views.CustomerViews;
using BILLING.ViewModels.CustomerViewModels;
using BILLING.Views;

namespace BILLING.ViewModels.CustomerViewModels;

public class CustomerMainMenuViewModel: ViewModelBase
{
    public Frame InnerFrame2 { get; set; } //s-search ve new hissesindeki frame
    public Frame InnerFrame1 { get; set; } //s-mainmenudaki sag teref
    public Frame MainFrame { get; set; }
    public ICommand? SearchCommand { get; set; }
    public ICommand? NewCommand { get; set; }
    public CustomerMainMenuViewModel()
    {
        SearchCommand = new RelayCommand(NavigateToSearchPage, true);
        NewCommand = new RelayCommand(NavigateToCreateNewCustomerPage, true);
    }

    private void NavigateToCreateNewCustomerPage ()
    {
        InnerFrame2.Content = new NewCustomerView();
        InnerFrame2.DataContext = new NewCustomerViewModel();
    }
    private void NavigateToSearchPage()
    {
        InnerFrame2.Content = new SearchCustomerView();
        InnerFrame2.DataContext = new SearchCustomerViewModel();
    }
}
