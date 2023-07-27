using BILLING.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace BILLING.ViewModels;

public class MainViewModel
{
    public Frame ViewFrame { get; set; }
    public Page NextPage { get; set; }
    public User? CurrentUser { get; set; }
    public ICommand? CustomersCommand { get; set; }
    public ICommand? RequestsCommand { get; set; }
    public ICommand? ComplaintsCommand { get; set; }
    public ICommand? UserProfilCommand { get; set; }
    public MainViewModel(Frame frame, User user)
    {
        ViewFrame = frame;
        CurrentUser = user;
    }
    private bool Check() => true; //s - click olunanda her zaman true versin

    private void NavigateToCustomersPage()
    {

    }
    private void NavigateToRequestsPage()
    {

    }
    private void NavigateToComplaintsPage()
    {

    }
    private void NavigateToUserprofilePage()
    {

    }
}
