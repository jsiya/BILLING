using BILLING.Models;
using BILLING.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BILLING.ViewModels;


public class MainWindowViewModel
{
    //MainWindowun backinde vermisem datacontext kimi - S
    public Frame ViewFrame { get; set; }
    public MainWindowViewModel(Frame View, Page page)
    {
        ViewFrame = View;//bu viewdaki frame deyise bilmek ucun bunu elemiyib ancaq bind eliyende nese error verir - S
        page.DataContext = new LoginViewModel(ViewFrame); // buda frame-e vereciyimiz page ucun datacontext vere bilek deye -S
        ViewFrame.Content = page;
    }
}
