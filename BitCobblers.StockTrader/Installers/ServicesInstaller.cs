using BitCobblers.StockTrader.Services;
using BitCobblers.StockTrader.Services.Impl;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace BitCobblers.StockTrader.Installers
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            _ = container.Register(Component.For<INavigationService>().ImplementedBy<NavigationService>());
        }
    }
}