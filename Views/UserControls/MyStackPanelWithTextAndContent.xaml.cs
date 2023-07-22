using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace BILLING.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MyStackPanelWithTextAndContent.xaml
    /// </summary>
    public partial class MyStackPanelWithTextAndContent : UserControl, INotifyPropertyChanged 
    {
        public MyStackPanelWithTextAndContent()
        {
            InitializeComponent();
            //Txt = "MACCC";
        }

        public void INotify([CallerMemberName ] string? name = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler? PropertyChanged;


        private string _text;
        public string Txt
        {
            get => _text;
            set { _text = value;   INotify(); }
        }

        private string _content;
        public string Contnt
        {
            get => _content;
            set { _content = value; INotify(); }
        }


        private double  _fontsize;
        public double  FontSize
        {
            get => _fontsize;
            set { _fontsize = value; INotify(); }
        }
        private string _foreground;
        public string Foreground
        {
            get => _foreground;
            set { _foreground = value; INotify(); }
        }


    }
}
