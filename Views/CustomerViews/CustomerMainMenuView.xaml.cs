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
            CustomerPages.Content = new SearchCustomerView();
        }
    }
}
