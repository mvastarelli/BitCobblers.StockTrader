using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BitCobblers.StockTrader.Services;
using BitCobblers.StockTrader.Views;

namespace BitCobblers.StockTrader
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
    }
}
