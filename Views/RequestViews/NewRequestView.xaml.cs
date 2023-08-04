using System;
using System.Collections.Generic;
using System.IO;
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
using BILLING.ViewModels.RequestViewModels;
using BILLING.Views.RequestViews;
using Microsoft.Maps.MapControl.WPF;

namespace BILLING.Views.RequestViews
{
    /// <summary>
    /// Interaction logic for NewRequestView.xaml
    /// </summary>
    public partial class NewRequestView : Page
    {
       
        
        public NewRequestView()
        {
            InitializeComponent();
            DataContext = new NewRequestViewModel(this, MapName , OutlinedComboBox, btnforsearch);
            //MapName.CredentialsProvider = new ApplicationIdCredentialsProvider(CP);

            //using FileStream FS = new("AllRequests.json", FileMode.Open);
            //var Res = JsonSerializer.Deserialize<List<NewRequest>>(FS);

            //var dir = new DirectoryInfo("../../../");

            //var fileName = "AllRequests.json";
            //var filePath = dir.FullName + fileName;

            //var JsonStr = File.ReadAllText(fileName);

            //NewRequest NR = JsonSerializer.Deserialize<NewRequest>(JsonStr);
        }


    }
}
