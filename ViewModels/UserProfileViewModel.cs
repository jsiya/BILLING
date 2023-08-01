using BILLING.Models;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BILLING.ViewModels;

public class UserProfileViewModel : INotifyPropertyChanged
{
    private User _currentUser;

    public User CurrentUser
    {
        get { return _currentUser; }
        set { 
                _currentUser = value;
                OnPropertyChanged();
            
            }
    }

    //public User? CurrentUser { get; set; }
    public string? NewPassword { get; set; }
    public ICommand? EditCommand { get; set; }

    public UserProfileViewModel()
    {
        NewPassword = CurrentUser?.Password;
        EditCommand = new RelayCommand(EditUserInfo, CheckIfUserInfoChanged);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private bool CheckIfUserInfoChanged() //s- Eger password deyisilibse edit buttonu enable olsun
    {
        if (CurrentUser?.Password != NewPassword) return true;
        return false;
    }
    private void EditUserInfo()//s- Passwordu deyisende db -ye yazmagi unutma sonra!!!!
    {
        CurrentUser.Password = NewPassword;
    }

}
