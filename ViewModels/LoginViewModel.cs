using BILLING.DB;
using BILLING.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BILLING.ViewModels;

public class LoginViewModel : ViewModelBase, INotifyPropertyChanged
{
    public ICommand? LoginCommand { get; set; }
    public Frame ViewFrame { get; set; }
    public Page NextPage { get; set; }

    public UsersDB? UsersDB { get; set; }
    public ObservableCollection<User>? Users { get; set; }
    public User? CurrentUser { get; set; }

    private string? _username;

    public string Username
    {
        get { return _username; }
        set { 
            _username = value;
            OnPropertyChanged();
            }
    }

    private string? _password;

    public string Password
    {
        get { return _password; }
        set
        {
            _password = value;
            OnPropertyChanged();
        }
    }

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;

    public LoginViewModel(Frame View, Page page)
    {
        ViewFrame = View;
        NextPage = page;
        UsersDB = new UsersDB();
        Users = UsersDB.Users;
        LoginCommand = new RelayCommand(LoginToAccount, CheckUsernameAndPasswordIsNotEmpty);
    }

    private bool CheckUsernameAndPasswordIsNotEmpty()
    {
        if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            return false;
        return true;
    }

    private void LoginToAccount()
    {
        foreach (var item in Users)
        {
            if(Username == item.Username && Password == item.Password)
            {
                CurrentUser = item;
                NextPage.DataContext = new MainViewModel();
                ViewFrame.Content = NextPage;
                break;
            }
        }
    }
}
