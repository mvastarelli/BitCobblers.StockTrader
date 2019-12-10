using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitCobblers.StockTrader.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BitCobblers.StockTrader.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTradePage : ContentPage
    {
        public NewTradePage()
        {
            InitializeComponent();
            BindingContext = new NewTradeViewModel();
        }
    }
}