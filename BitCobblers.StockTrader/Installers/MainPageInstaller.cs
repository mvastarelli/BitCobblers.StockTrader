using BitCobblers.StockTrader.Views;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Xamarin.Forms;

namespace BitCobblers.StockTrader.Installers
{
    public class MainPageInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            _ = container.Register(Component.For<MasterDetailPage>().ImplementedBy<MainPage>());
        }
    }
}