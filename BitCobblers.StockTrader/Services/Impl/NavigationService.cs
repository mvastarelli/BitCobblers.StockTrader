using System.Threading.Tasks;
using BitCobblers.StockTrader.ViewModels;
using Castle.MicroKernel;
using Xamarin.Forms;

namespace BitCobblers.StockTrader.Services.Impl
{
    public class NavigationService : INavigationService
    {
        private readonly IKernel kernel;
        private readonly MasterDetailPage master;

        public NavigationService(IKernel kernel)
        {
            this.kernel = kernel;
            this.master = kernel.Resolve<MasterDetailPage>();
        }

        public async Task GoBack()
        {
            _ = await this.master.Detail.Navigation.PopModalAsync();
        }

        public async Task GoToAsync<TViewModel>() where TViewModel : BaseViewModel
        {
            var name = typeof(TViewModel).FullName;
            var page = this.kernel.Resolve<Page>(name);

            if (page == this.master.Detail)
            {
                return;
            }

            this.master.Detail = page;

            if (Device.RuntimePlatform == Device.Android)
            {
                await Task.Delay(100);
            }

            this.master.IsPresented = false;
        }
    }
}