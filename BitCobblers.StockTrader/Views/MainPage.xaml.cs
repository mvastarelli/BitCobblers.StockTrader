using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using BitCobblers.StockTrader.Models;
using Xamarin.Forms;

namespace BitCobblers.StockTrader.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        private Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();

        public MainPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    //case (int)MenuItemType.About:
                    //    MenuPages.Add(id, new NavigationPage(new AboutPage()));
                    //    break;



                    case (int)MenuItemType.Home:
                        MenuPages.Add(id, new NavigationPage(new HomePage()));
                        break;
                    case (int)MenuItemType.AccountSummary:
                        MenuPages.Add(id, new NavigationPage(new AccountSummaryPage()));
                        break;
                    case (int)MenuItemType.Trade:
                        MenuPages.Add(id, new NavigationPage(new TradePage()));
                        break;
                    case (int)MenuItemType.History:
                        MenuPages.Add(id, new NavigationPage(new HistoryPage()));
                        break;


                    //case (int)MenuItemType.NewTrade:
                    //    MenuPages.Add(id, new NavigationPage(new NewTradePage()));
                    //    break;
                    case (int)MenuItemType.Deposit:
                        MenuPages.Add(id, new NavigationPage(new DepositPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}