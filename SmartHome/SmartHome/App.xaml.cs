using Autofac;
using SmartHome.Services;
using SmartHome.ViewModels;
using SmartHome.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SmartHome
{
    public partial class App : Application
    {
        public IContainer Container { get; }
        public string AuthToken { get; set; }

        public App(Module _module)
        {
            InitializeComponent();
            Container = BuildContainer(_module);
            MainPage = new NavigationPage(new ConnectionPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        IContainer BuildContainer(Module _module)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ConnectionViewModel>().AsSelf();
            builder.RegisterType<HomeViewModel>().AsSelf();
            builder.RegisterType<NavigationService>().AsSelf().SingleInstance();
            builder.RegisterModule(_module);
            return builder.Build();
        }
    }
}
