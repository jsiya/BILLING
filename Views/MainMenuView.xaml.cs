using BILLING.Models;
using BILLING.ViewModels;
using BILLING.Views.CustomerViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BILLING.Views
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView : Page
    {
        public MainMenuView()
        {
            InitializeComponent();
            //s-sehifenin icindeki frame basqa cur cata bilmedim ona gore burda verdim data contexti
            MainMenuViewModel viewModel = new MainMenuViewModel();
            viewModel.InnerFrame = AllPagesFrame;//s-bunun viewmodelinin icindeki propertiye menimsetdim
            DataContext = viewModel;
        }
    }
}
