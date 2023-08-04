using BILLING.Models;
using BILLING.ViewModels.CustomerViewModels;
using BILLING.ViewModels.RequestViewModels;
using BILLING.Views;
using BILLING.Views.RequestViews;
using BILLING.Views.CustomerViews;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;
using System.Windows.Input;

namespace BILLING.ViewModels;

public class MainViewModel
{
    public Frame ViewFrame { get; set; }
    public Page NextPage { get; set; }
    //public Frame FrameOfNextPage { get; set; }
    public User? CurrentUser { get; set; }
    public ICommand? CustomersCommand { get; set; }
    public ICommand? RequestsCommand { get; set; }
    public ICommand? ComplaintsCommand { get; set; }
    public ICommand? UserProfilCommand { get; set; }
    public ICommand? LogOutCommand { get; set; }
    public MainViewModel(Frame frame, User user)
    {
        ViewFrame = frame;
        CurrentUser = user;
        NextPage = new MainMenuView(); //s-bunun data contexti oz backinde verilib icindeki frame gore
        CustomersCommand = new RelayCommand(NavigateToCustomersPage, true);
        RequestsCommand = new RelayCommand(NavigateToRequestsPage, true);
        ComplaintsCommand = new RelayCommand(NavigateToComplaintsPage, true);
        UserProfilCommand = new RelayCommand(NavigateToUserprofilePage, true);
        LogOutCommand = new RelayCommand(NavigateToBack, true);
    }
    //s-commandlari parametr verenden sonra deyis!!!!!
    private void NavigateToCustomersPage()
    {
        ViewFrame.Content = NextPage;
        if(NextPage.DataContext is MainMenuViewModel vf) //s-nextpage-in propertylerine catmaq ucun
        {
            vf.CurrentUser = CurrentUser; 
            vf.MainFrame = ViewFrame; //s- halhazirki framediki geri qayitma ve log out ede bilek
            vf.InnerFrame.Content = new CustomerMainMenuView(); //s-iceride sag terefdeki fram-in contentini secilmis buttona uygun veririk sonrada data context verilir
            //vf.InnerFrame.DataContext = new CustomerMainMenuViewModel();
        }
    }
    private void NavigateToRequestsPage()
    {
        ViewFrame.Content = NextPage;
        if (NextPage.DataContext is MainMenuViewModel vf) //s-nextpage-in propertylerine catmaq ucun
        {
            vf.CurrentUser = CurrentUser;
            vf.MainFrame = ViewFrame;
            vf.InnerFrame.Content = new RequestMainMenuView();
            //vf.InnerFrame.DataContext = new RequestMainMenuViewModel();
        }
    }
    private void NavigateToComplaintsPage()
    {
        ViewFrame.Content = NextPage;
        if (NextPage.DataContext is MainMenuViewModel vf) //s-nextpage-in propertylerine catmaq ucun
        {
            vf.CurrentUser = CurrentUser;
            vf.MainFrame = ViewFrame;
            vf.InnerFrame.Content = new AllComplaints();
            vf.InnerFrame.DataContext = new AllComplaintsViewModel();
        }
    }
    private void NavigateToUserprofilePage()
    {
        ViewFrame.Content = NextPage;
        if (NextPage.DataContext is MainMenuViewModel vf) //s-nextpage-in propertylerine catmaq ucun
        {
            vf.CurrentUser = CurrentUser;
            vf.MainFrame = ViewFrame;
            var vm = new UserProfileViewModel();
            vm.CurrentUser = CurrentUser;
            vf.InnerFrame.Content = vm;
            //vf.InnerFrame.DataContext = new UserProfileViewModel();
        }
    }

    private void NavigateToBack() //s- bu eslinde geri qayitmaqdi ama burda logout ucun isletdim
    {
        ViewFrame.NavigationService.GoBack(); 
    }
}
