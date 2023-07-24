using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BILLING.ViewModels;

public class LoginViewModel : ViewModelBase, INotifyPropertyChanged
{
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
    public RelayCommand? LoginCommand;
    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged!.Invoke(this, new PropertyChangedEventArgs(name));
    }
    public event PropertyChangedEventHandler? PropChanged;

    public LoginViewModel()
    {
        
    }

    private bool CheckUsernameAndPasswordIsNotEmpty(object? parametr)
    {
        if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            return false;
        return true;
    }
}
