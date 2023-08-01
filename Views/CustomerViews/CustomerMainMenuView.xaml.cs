using BILLING.ViewModels.CustomerViewModels;
using System.Windows.Controls;

namespace BILLING.Views.CustomerViews
{
    /// <summary>
    /// Interaction logic for CustomerMainMenuView.xaml
    /// </summary>
    public partial class CustomerMainMenuView : Page
    {
        public CustomerMainMenuView()
        {
            InitializeComponent();
            DataContext = this;
            CustomerMainMenuViewModel viewModel = new CustomerMainMenuViewModel();
            viewModel.InnerFrame2 = CustomerPages;
            DataContext = viewModel;
        }
    }
}
