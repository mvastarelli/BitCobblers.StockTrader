﻿using System.Collections.Generic;
using System.ComponentModel;
using BitCobblers.StockTrader.Models;
using Xamarin.Forms;

namespace BitCobblers.StockTrader.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        private MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        private List<HomeMenuItem> menuItems;

        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                //new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },


                new HomeMenuItem { Id = MenuItemType.Home, Title="Home" },
                new HomeMenuItem { Id = MenuItemType.AccountSummary, Title="Account Summary" },
                new HomeMenuItem { Id = MenuItemType.Trade, Title="Trade" },


               // new HomeMenuItem { Id = MenuItemType.About, Title="About" },

                //new HomeMenuItem { Id = MenuItemType.NewTrade, Title="New Trade" },
                new HomeMenuItem { Id = MenuItemType.Deposit, Title="Deposit" },
                new HomeMenuItem { Id = MenuItemType.History, Title="History" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}