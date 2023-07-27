using BILLING.DB;
using BILLING.Models;
using BILLING.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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

    public LoginViewModel(Frame View)
    {
        ViewFrame = View;
        NextPage = new MainView();//sonraki sehife
        UsersDB = new UsersDB();
        Users = UsersDB.Users;
        LoginCommand = new RelayCommand(LoginToAccount, CheckUsernameAndPasswordIsNotEmpty);
    }

    private bool CheckUsernameAndPasswordIsNotEmpty()
    {//username ve password bos deyilse
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
                CurrentUser = item; //halhazirda daxil olan operator
                NextPage.DataContext = new MainViewModel(ViewFrame, CurrentUser); //s- sonraki sehifenin data contexti

                //ViewFrame.Source = new Uri("C:\\Users\\Siya\\source\\repos\\BILLING\\Views\\MainView.xaml");   //s-bu basqa yol yoxluturdum lazimsizdi

                ViewFrame.Content = NextPage;  //s-frame sonraki view verilir
                break;
            }
        }
    }
}
