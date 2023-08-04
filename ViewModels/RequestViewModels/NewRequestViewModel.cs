using BILLING.Views.RequestViews;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using BILLING.Commands;
using MaterialDesignThemes.Wpf;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Media.Media3D;
using System.Xml.Linq;
using System.Text.Json;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using BILLING.Models;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography;

namespace BILLING.ViewModels.RequestViewModels
{
    internal class NewRequestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void INotify([CallerMemberName] string? a = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(a));
        }





        ///===========================================//
        //===================================================================
        //=======================================================================================
        /*
        private readonly Dictionary<string, Location> cityCoordinates = new Dictionary<string, Location>
            {
                { "Fevzulla Gasimzade", new Location(40.395466, 49.836035) },
                { "Imran Gasimov", new Location(40.393860, 49.838449) },
                { "Vagif Ave", new Location(40.392913, 49.844793) },
                {"Hanifa Alesgerova street", new Location(40.393010, 49.842012)},

                  {"Tabriz kuchesi", new Location(40.391564, 49.856517) },
                  { "Koroglu Rahimov str", new Location (40.400230, 49.858565) },

                 { "Jeyhun Salimov", new Location (40.403608, 49.818327) },
                  {"Seyid Cefer Pisheveri", new Location(40.408910, 49.814868)},

                  { "MirJalal Street", new Location (40.422710, 49.816381) },
                  { "Xurshudbanu Natavan", new Location(40.425451, 49.805301) },

                  { "Jeyhun Hajibeyli", new Location (40.391028, 49.846120) },
                  {"Azadliq Ave", new Location (40.384653, 49.845074) }


            };
        public void Request_ButtonClick(object param)
        {
            Window W2 = new();
            StackPanel S2 = new();
            TextBox T1 = new(); T1.Width = 280; T1.Height = 50; T1.Text = "T1";
            TextBox T2 = new(); T2.Width = 280; T2.Height = 50;
            TextBox T3 = new(); T3.Width = 280; T3.Height = 50;
            TextBox T4 = new(); T4.Width = 280; T4.Height = 50;

            Button btn1 = new(); btn1.FontSize = 20; btn1.Margin = new Thickness(20);
            btn1.Content = "CheckRequest"; btn1.Name = "RequestButon";
            S2.Children.Add(T1); S2.Children.Add(T2); S2.Children.Add(T3); S2.Children.Add(T4);
            S2.Children.Add(btn1);
            W2.Content = S2;
            W2.Show();
        }
        public MyRelayCommand RComand { get; set; }
        private int _busCount = 0;
        public int BusCount
        {
            get => _busCount;
            set
            {
                _busCount = value;
                INotify();
            }
        }
        public NewRequestViewModel(NewRequestView View, Map myMap, ComboBox myCBox, Button myBtn)
        {

            RComand = new MyRelayCommand(Request_ButtonClick);





        }
       

    
        */
    







    ///===========================================//
    //===================================================================
    //=======================================================================================





   
   







    private int _busCount = 0;
    public int BusCount
    {
        get => _busCount;
        set
        {
            _busCount = value;
            INotify();
        }
    }

        //public  void SearchButtonCommand(object? param)
        //{
        //    BusCount = 0;
        //    map.Children.Clear();
        //    string routecode = (SearchFilterBus.SelectedItem as string)!;
        //    if (routecode == "All")
        //    {
        //        foreach (var pushpin in pushpins)
        //        {
        //            Map.Children.Add(pushpin);
        //            BusCount++;
        //        }
        //        return;
        //    }
        //    foreach (var busname in BusNames)
        //    {
        //        if (busname == routecode)
        //            foreach (var pushpin in pushpins)
        //            {
        //                if (pushpin.Content.ToString() == routecode)
        //                {
        //                    Map.Children.Add(pushpin);
        //                    BusCount++;
        //                }
        //            }
        //    }

        //}

        int co = 0;
    public void Request_ButtonClick(object param)
    {
            //if(co != 0)
            //{
            //    if (RequestList[0]?.Name != null)
            //        MessageBox.Show(RequestList[0]?.Name);

            //}
            //co++;


            Window W2 = new();
        StackPanel S2 = new();
        TextBox T1 = new(); T1.Width = 280; T1.Height = 50; //T1.Text = "T1";
        TextBox T2 = new(); T2.Width = 280; T2.Height = 50;
        TextBox T3 = new(); T3.Width = 280; T3.Height = 50;
        TextBox T4 = new(); T4.Width = 280; T4.Height = 50;

            Binding binding = new Binding("Request.Name")
            {
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            BindingOperations.SetBinding(T1, TextBox.TextProperty, binding);


            //T1.SetBinding(TextBox.TextProperty, new Binding("Request.Name"), UpdateSourceTrigger.PropertyChanged);
            T2.SetBinding(TextBox.TextProperty , new Binding("Request.Surname"));
            T3.SetBinding(TextBox.TextProperty, new Binding("Request.Location"));
            T4.SetBinding(TextBox.TextProperty, new Binding("Request.Phone"));
            


            Button btn1 = new(); btn1.FontSize = 20; btn1.Margin = new Thickness(20);  btn1.Command = RC;
        btn1.Content = "CheckRequest"; btn1.Name = "RequestButon";
        S2.Children.Add(T1); S2.Children.Add(T2); S2.Children.Add(T3); S2.Children.Add(T4);
        S2.Children.Add(btn1);
        W2.Content = S2;
        W2.Show();
            
    }

        public void Check_Request(object param)
        {
            MessageBox.Show(Request?.Name);
            //RequestList.Add(Request);
            // Request = null;
          
        }

        public void Select_Button(object param)
        {
            foreach (var p in Pushpins)
            {
                //var loc = B1?.Content.ToString() switch
                //{
                //"Fevzulla Gasimzade" => new Location(40.395466, 49.836035),
                //"Imran Gasimov Street" => new Location(40.393860, 49.838449),
                //"Vagif Ave" => new Location(40.392913, 49.844793),
                //"Hanifa Alesgerova Sstreet" => new Location(40.393010, 49.842012),
                //"Tabriz Kuchesi" => new Location(40.391564, 49.856517),
                //"Koroglu Rahimov Str" => new Location(40.400230, 49.858565),
                //"Jeyhun Salimov" => new Location(40.403608, 49.818327),
                //"Seyid Cefer Pisheveri" => new Location(40.408910, 49.814868),
                //"Mir Jalal Street" => new Location(40.422710, 49.816381),
                //"Xurshudbanu Natavan" => new Location(40.425451, 49.805301),
                //"Jeyhun Hajibeyli" => new Location(40.391028, 49.846120),
                //"Azadliq Ave" => new Location(40.384653, 49.845074)

                //};

                if (B1?.Content.ToString() == "Jeyhun Salimov")
                {
                    map.Center = cityCoordinates["Jeyhun Salimov"];
                   
                }
                else if (B1?.Content.ToString() == "MirJalal Street")
                {
                    map.Center = cityCoordinates["MirJalal Street"];
                   
                }
                map.ZoomLevel = 20;
                //map.ZoomLevel = 20;

                //map.Center = loc;


            }
        }

        //Pushpin _p;
        //public Pushpin p
        //{
        //    get => _p;
        //    set { _p = value; INotify();  }
        //}
        private readonly Dictionary<string, Location> cityCoordinates = new Dictionary<string, Location>
    {
        { "Fevzulla Gasimzade", new Location(40.395466, 49.836035) },
        { "Imran Gasimov", new Location(40.393860, 49.838449) },
        { "Vagif Ave", new Location(40.392913, 49.844793) },
        {"Hanifa Alesgerova street", new Location(40.393010, 49.842012)},

          {"Tabriz kuchesi", new Location(40.391564, 49.856517) },
          { "Koroglu Rahimov str", new Location (40.400230, 49.858565) },

         { "Jeyhun Salimov", new Location (40.403608, 49.818327) },
          {"Seyid Cefer Pisheveri", new Location(40.408910, 49.814868)},

          { "MirJalal Street", new Location (40.422710, 49.816381) },
          { "Xurshudbanu Natavan", new Location(40.425451, 49.805301) },

          { "Jeyhun Hajibeyli", new Location (40.391028, 49.846120) },
          {"Azadliq Ave", new Location (40.384653, 49.845074) }


    };




    //public Dictionary<double, double> ActivityScop = new ();
    public ObservableCollection<Pushpin> Pushpins = new();
    ComboBox a = new();
    Map map = new();
    Button B1 = new();
        public List<NewRequest>? RequestList = new();
    public NewRequest Request = new();
        
    public MyRelayCommand RComand { get; set; }
    public MyRelayCommand RC { get; set; }
        public MyRelayCommand SelectCmnd { get; set; }
    public string CP = "bVdaYjGsfP8kn9Kmkalz~cwyKZRxj0016apN4V1M5pQ~Al8eRWIp3eVgWCVNW_A90wGi82NEJ_gSUXpVbRr-mXaAc-Pj1-BebRsyUsdThRNP";
    public NewRequestViewModel(NewRequestView V, Map myMap, ComboBox myCBox, Button myBtn )
    {
        // ComboBoxSelectionChangedCommand = new RelayCommand<object>(OnComboBoxSelectionChanged);

        RComand = new MyRelayCommand(Request_ButtonClick);
        RC = new(Check_Request);
            SelectCmnd = new(Select_Button);
            //using FileStream FS = new("AllRequests.json", FileMode.Open);
            //var Res = JsonSerializer.Deserialize<List<NewRequest>>(FS);



            //var dir = new DirectoryInfo("../../../");

            //var fileName = "AllRequests.json";
            //var filePath = dir.FullName + fileName;

            //var JsonStr = File.ReadAllText(fileName );



            //NewRequest NR   = JsonSerializer.Deserialize<NewRequest>(JsonStr);



            Request.Name = "Maham";
            Request.Surname = "Gazzal";
            //MessageBox.Show(Request.Surname);
        if (V.Content is Grid gr)
        {
            Pushpin Pin = new(); ObservableCollection<Pushpin> Pins = new();

            foreach (var item in gr.Children)
            {

                if (item is Map Mp)
                {
                    map = Mp; Mp = map;
                    Mp.CredentialsProvider = new ApplicationIdCredentialsProvider(CP);
                    Mp.Center = new Location(40.4, 49.5);
                    Mp.ZoomLevel = 10;

                    Style customButtonStyle = new Style(typeof(Button));

                    // Set the Background, Foreground, and FontSize properties using Setters
                    customButtonStyle.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Red));
                    customButtonStyle.Setters.Add(new Setter(Button.ForegroundProperty, Brushes.White));
                    customButtonStyle.Setters.Add(new Setter(Button.FontSizeProperty, 12.0));
                    customButtonStyle.Setters.Add(new Setter(Button.HorizontalAlignmentProperty, HorizontalAlignment.Center));
                    customButtonStyle.Setters.Add(new Setter(Button.VerticalAlignmentProperty, VerticalAlignment.Center));
                    customButtonStyle.Setters.Add(new Setter(Button.BackgroundProperty , Brushes.Blue ));




                        foreach (var loc in cityCoordinates.Values)
                        {

                        Pushpin p = new();
                        p.Location = loc;
                        if (loc == new Location(40.395466, 49.836035))
                        {
                                Button bt = new(); bt.Content = "FG";
                                bt.Style = customButtonStyle; p.Content = bt; bt.Command = RComand;
                                p.Name = "FevzullaGasimzade";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Fevzulla Gasimzade";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;

                        }
                        else if (loc == new Location(40.393860, 49.838449))
                        {
                                Button bt = new(); bt.Content = "IG";
                                bt.Style = customButtonStyle; p.Content = bt; bt.Command = RComand;
                                p.Name = "ImranGasimovStreet";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Imran Gasimov street";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;
                        }
                        else if (loc == new Location(40.392913, 49.844793))
                        {
                                //p.Template = "{Binding PushpinTemplate}"
                                Button bt = new(); bt.Content = "VA";
                                bt.Style = customButtonStyle; p.Content = bt; bt.Command = RComand;
                                p.Name = "VagifAve";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Vagif Ave";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;
                        }
                           
                        else if (loc == new Location(40.393010, 49.842012))
                        {
                                Button bt = new(); bt.Content = "HAS";
                                bt.Style = customButtonStyle; p.Content = bt; bt.Command = RComand;
                                p.Name = "HanifaAlesgerovaSstreet";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Hanife Alesgerova Street";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;
                        }
                        else if (loc == new Location(40.391564, 49.856517))
                        {
                                Button bt = new(); bt.Content = "T";
                                bt.Style = customButtonStyle; p.Content = bt; bt.Command = RComand;
                                p.Name = "TabrizKuchesi";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Tabriz kuchesi";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;
                        }
                        else if (loc == new Location(40.400230, 49.858565))
                        {
                                Button bt = new(); bt.Content = "KRS";
                                bt.Style = customButtonStyle; p.Content = bt; bt.Command = RComand;
                                p.Name = "KorogluRahimovStr";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Koroglu Rahimov Street";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;
                        }
                        else if (loc == new Location(40.403608, 49.818327))
                        {
                                Button bt = new(); bt.Content = "JS";
                                bt.Style = customButtonStyle; p.Content = bt; bt.Command = RComand;
                                 p.Name = "JeyhunSalimov";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Jeyhun Salimov";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;
                        }
                        else if (loc == new Location(40.408910, 49.814868))
                        {
                                Button bt = new(); bt.Content = "SCP";
                                bt.Style = customButtonStyle; p.Content = bt; bt.Command = RComand;
                                 p.Name = "SeyidCeferPisheveri";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Seyid Cefer Pisheveri";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;

                        }
                           
                        else if (loc == new Location(40.422710, 49.816381))
                        {
                            Button bt = new(); bt.Content = "MJ";
                            bt.Style = customButtonStyle; p.Content = bt; bt.Command = RComand;
                                p.Name = "MirJalalStreet";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Mirjalal Street";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;
                        }
                        else if (loc == new Location(40.425451, 49.805301))
                        {

                            Button bt = new(); bt.Content = "XN"; bt.Command = RComand;
                            bt.Style = customButtonStyle;
                            p.Content = bt; ; p.Name = "XurshudbanuNatavan";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Xurshudbanu Natavan";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;
                        }
                        else if (loc == new Location(40.391028, 49.846120))
                        {
                            Button bt = new(); bt.Content = "JH"; bt.Command = RComand; bt.Style = customButtonStyle;
                                p.Content = bt;
                                p.Name = "JeyhunHajibeyli";
                            ToolTip TT = new();
                            Label a = new(); a.Content = "Jeyhun Hajibeyli";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;

                        }
                        else if (loc == new Location(40.384653, 49.845074))
                        {
                                Button bt = new(); bt.Content = "A"; bt.Command = RComand; bt.Style = customButtonStyle;
                                p.Content = bt;
                                 p.Name = "AzadliqAve";

                            ToolTip TT = new();
                            Label a = new(); a.Content = "azadliq";
                            TT.Content = a; TT.Background = Brushes.BlueViolet;
                            p.ToolTip = TT;

                        }



                        Pushpins.Add(p);


                    }

                    foreach (var pin in Pushpins)
                    {
                        Mp.Children.Add(pin);
                    }



                    foreach(var element in map.Children )
                    {

                        if(element is StackPanel SP)
                        {
                            //MessageBox.Show("vv");
                            foreach (var child in SP.Children)
                            {
                                if (child is ComboBox CB)
                                {
                                   // MessageBox.Show("tt");
                                    //CB.Name = "ComboBoxForCities";
                                    CB.ItemsSource = cityCoordinates.Keys;
                                    // a = CB;
                                    // CB = a;

                                    //void Search_Location(object param)
                                    //{
                                    //    if (CB.SelectedItem.ToString() == "Jeyhun Salimov")
                                    //    {
                                    //        MessageBox.Show("as");
                                    //    }
                                    //}

                                    // RC = new MyRelayCommand (Search_Location);

                                }
                                    if (child is Button BTN)
                                    {
                                        B1 = BTN;
                                        BTN.Command = SelectCmnd;
                                    }
                                        //if(child is Button buton)
                                        //{
                                        //    //B1 = buton;  buton = B1;
                                        //    //map.Children.Clear();
                                        //    foreach (var loc in cityCoordinates)
                                        //    {
                                        //        if(loc.Key == buton.Content.ToString())
                                        //        {
                                        //           // MessageBox.Show(buton.Content.ToString());
                                        //            Pushpin pushpin = new();
                                        //           // pushpin.Location = new Location(loc.Value);
                                        //        }
                                        //    }
                                        //}
                                    }
                        }
                    }


                }
















            }
        }



    }
    












}
    }






            //======================================================================================
            //===================================================================
///===========================================//



























//ActivityScop.Add(40.395466, 49.836035);   // Fevzulla Gasimzade
//ActivityScop.Add(40.393860, 49.838449);   // Imran Gasimov 


//ActivityScop.Add(40.392913, 49.844793);    // Vagif Ave
//ActivityScop.Add(40.393010, 49.842012);     // Hanifa Alesgerova street


//ActivityScop.Add(40.391564, 49.856517);    // Tabriz kuchesi
//ActivityScop.Add(40.400230, 49.858565);    // Koroglu Rahimov str

//ActivityScop.Add(40.403608, 49.818327);     // Jeyhun Salimov
//ActivityScop.Add(40.408910, 49.814868);     // Seyid Cefer Pisheveri

//ActivityScop.Add(40.422710, 49.816381);  // MirJalal Street
//ActivityScop.Add(40.425451, 49.805301);   // Xurshudbanu Natavan

//ActivityScop.Add(40.391028, 49.846120);  //Jeyhun Hajibeyli
//ActivityScop.Add(40.384653, 49.845074);  //Azadliq Ave



//    List<string> ActivityScopeList = new()
//    {
//      "Fevzulla Gasimzade",
//      "Imran Gasimov ",

//      "Vagif Ave",
//      "Hanifa Alesgerova street",

//      "Tabriz kuchesi",
//      "Koroglu Rahimov str",

//      "Jeyhun Salimov",
//      "Seyid Cefer Pisheveri",

//      "MirJalal Street",
//      "Xurshudbanu Natavan",

//      "Jeyhun Hajibeyli",
//      "Azadliq Ave"
//};
