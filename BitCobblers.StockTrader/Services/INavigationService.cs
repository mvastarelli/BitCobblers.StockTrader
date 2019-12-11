using System.Threading.Tasks;
using BitCobblers.StockTrader.ViewModels;

namespace BitCobblers.StockTrader.Services
{
    public interface INavigationService
    {
        Task GoBack();
        Task GoToAsync<TViewModel>() where TViewModel : BaseViewModel;
    }
}