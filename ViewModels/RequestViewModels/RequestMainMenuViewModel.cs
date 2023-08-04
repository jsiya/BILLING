using BILLING.ViewModels.CustomerViewModels;
using BILLING.Views.CustomerViews;
using BILLING.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using BILLING.Views.RequestViews;
using GalaSoft.MvvmLight.Command;

namespace BILLING.ViewModels.RequestViewModels;

public class RequestMainMenuViewModel
{
    public Frame InnerFrame2 { get; set; } //s-search ve new hissesindeki frame
    public Frame InnerFrame1 { get; set; } //s-mainmenudaki sag teref
    public Frame MainFrame { get; set; }
    public ICommand? AddCommand { get; set; }
    public ICommand? AllCommand { get; set; }
    public RequestMainMenuViewModel()
    {
        AllCommand = new RelayCommand(NavigateToAllRequestsPage, true);
        AddCommand = new RelayCommand(NavigateToNewRequestPage, true);
    }
    private void NavigateToNewRequestPage()
    {
        InnerFrame2.Content = new NewRequestView();
    }
    private void NavigateToAllRequestsPage()
    {
        InnerFrame2.Content = new SearchCustomerView();
    }
}
