using Autofac;
using Autofac.Core;
using BILLING.ViewModels;
using BILLING.ViewModels.CustomerViewModels;
using BILLING.Views.CustomerViews;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BILLING
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ContainerBuilder container { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            container = new ContainerBuilder();
            container.RegisterType<MainWindowViewModel>().As<MainWindowViewModel>();
            container.RegisterType<LoginViewModel>().As<LoginViewModel>();
            container.RegisterType<MainViewModel>().As<MainViewModel>();
            container.RegisterType<MainMenuViewModel>().As<MainMenuViewModel>();
            container.RegisterType<UserProfileViewModel>().As<UserProfileViewModel>();
            container.RegisterType<ComplaintsViewModel>().As<ComplaintsViewModel>();
            container.RegisterType<CustomerMainMenuViewModel>().As<CustomerMainMenuViewModel>();
            container.RegisterType<CustomerWholeInfoView>().As<CustomerWholeInfoView>();
            container.RegisterType<GeneralViewModel>().As<GeneralViewModel>();
            container.RegisterType<NetworkViewModel>().As<NetworkViewModel>();
            container.RegisterType<NewCustomerViewModel>().As<NewCustomerViewModel>();
            container.RegisterType<PaymentsViewModel>().As<PaymentsViewModel>();
            container.RegisterType<SearchCustomerViewModel>().As<SearchCustomerViewModel>();
            container.Build();
            
            base.OnStartup(e);
        }

    }
}
