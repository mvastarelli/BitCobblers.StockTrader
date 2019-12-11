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
    public partial class HomePage : ContentPage, IHaveAViewModel<HomeViewModel>
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }

        public HomeViewModel ViewModel => throw new NotImplementedException();
    }

    public interface IHaveAViewModel<TViewModel> where TViewModel : BaseViewModel
    {
        TViewModel ViewModel { get; }
    }
}