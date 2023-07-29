using BILLING.Models;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using BILLING.Views;
using BILLING.Views.CustomerViews;
using BILLING.ViewModels.CustomerViewModels;

namespace BILLING.ViewModels;

public class MainMenuViewModel: INotifyPropertyChanged
{
    public User? CurrentUser { get; set; }
    //s- menudaki radio buttonlar check olduqca  deyismesi ucun
    /*private bool _isCheckedCustomersButton;
    public bool IsCheckedCustomersButton
    {
        get { return _isCheckedCustomersButton; }
        set 
        { 
            _isCheckedCustomersButton = value;
            OnPropertyChanged();
        }
    }


    private bool _isCheckedRequestsButton;
    public bool IsCheckedRequestsButton
    {
        get { return _isCheckedRequestsButton; }
        set 
        { 
            _isCheckedRequestsButton = value;
            OnPropertyChanged();
        }
    }


    private bool _isCheckedComplaintsButton;
    public bool IsCheckedComplaintsButton
    {
        get { return _isCheckedComplaintsButton; }
        set 
        { 
            _isCheckedComplaintsButton = value;
            OnPropertyChanged();
        }
    }


    private bool _isCheckedPersonalInfoButton;
    public bool IsCheckedPersonalInfoButton
    {
        get { return _isCheckedPersonalInfoButton; }
        set 
        { 
            _isCheckedPersonalInfoButton = value;
            OnPropertyChanged();
        }
    }


    private bool _isCheckedLogOutButton;
    public bool IsCheckedLogOutButton
    {
        get { return _isCheckedLogOutButton; }
        set 
        { 
            _isCheckedLogOutButton = value;
            OnPropertyChanged();
        }
    }*/

    public Frame MainFrame { get; set; } //s-hal-hazirda kenarda menu olan page-in yerlesdiyi
                                      //frame bunu getirdimki billing buttonu secende geri qayida bilek ve ya logout ucun contenti deyise bilek
    public Frame InnerFrame { get; set; } //s-bu sag terefdeki framedi bunu bind eliye bilmedim ona gore bir basa viewnun backinden parametr kimi gonderecem
    public ICommand? MainPageCommand { get; set; }
    public ICommand? CustomersPageCommand { get; set; }
    public ICommand? RequestsPageCommand { get; set; }
    public ICommand? ComplaintsPageCommand { get; set; }
    public ICommand? PersonalInfoPageCommand { get; set; }
    public ICommand? LogOutCommand { get; set; }
    public MainMenuViewModel()
    {
        MainPageCommand = new RelayCommand(NavigateToMainPage, true);
        CustomersPageCommand = new RelayCommand(NavigateToCustomersMainMenuPage, true);
        RequestsPageCommand = new RelayCommand(NavigateToRequestsMenuPage, true);
        ComplaintsPageCommand = new RelayCommand(NavigateToAllComplaintsPage, true);
        PersonalInfoPageCommand = new RelayCommand(NavigateToUserPersonalInfoPage, true);
        LogOutCommand = new RelayCommand(NavigateToMainPage, true);
    }



    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private void NavigateToCustomersMainMenuPage()
    {
        InnerFrame.Content = new CustomerMainMenuView();
        InnerFrame.DataContext = new CustomerMainMenuViewModel();
    }

    private void NavigateToRequestsMenuPage()
    {
        //mahammadedir
    }

    private void NavigateToAllComplaintsPage()
    {
        InnerFrame.Content = new AllComplaints();
        InnerFrame.DataContext = new AllComplaintsViewModel();
    }

    private void NavigateToUserPersonalInfoPage()
    {
        InnerFrame.Content = new UserProfileView();
        InnerFrame.DataContext = new UserProfileViewModel();
    }
    private void NavigateToMainPage()
    {
        //Buna bax nese duzgun gorsenmmir
        MainFrame.Content = new LoginView();
        MainFrame.DataContext = new LoginViewModel(MainFrame);
    }
}
