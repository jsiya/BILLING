using BILLING.ViewModels.CustomerViewModels;
using BILLING.ViewModels.RequestViewModels;
using System;
using System.Collections.Generic;
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

namespace BILLING.Views.RequestViews
{
    /// <summary>
    /// Interaction logic for RequestMainMenuView.xaml
    /// </summary>
    public partial class RequestMainMenuView : Page
    {
        public RequestMainMenuView()
        {
            InitializeComponent();
            DataContext = this;
            RequestMainMenuViewModel viewModel = new RequestMainMenuViewModel();
            viewModel.InnerFrame2 = CustomerPages;
            viewModel.InnerFrame2.Content = new NewRequestView();
            DataContext = viewModel;
        }
    }
}
