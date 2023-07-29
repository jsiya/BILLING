using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace BILLING.ViewModels.CustomerViewModels;

public class CustomerMainMenuViewModel: ViewModelBase
{
    public Frame InnerFrame2 { get; set; } //s-search ve new hissesindeki frame
    public Frame InnerFrame1 { get; set; } //s-mainmenudaki sag teref
    public Frame MainFrame { get; set; }
    public ICommand? SearchCommand { get; set; }
    public ICommand? NewCommand { get; set; }
}
