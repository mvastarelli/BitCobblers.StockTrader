using System.Reflection;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Xamarin.Forms;
using System.Linq;
using BitCobblers.StockTrader.Views;

namespace BitCobblers.StockTrader.Installers
{
    public class ViewsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var pageTypes = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(IHaveAViewModel<>))
                            let viewModelInterface = t.GetInterfaces().First(x => x == typeof(IHaveAViewModel<>))
                            let model = viewModelInterface.GetGenericArguments()[0]
                            select new
                            {
                                Page = t,
                                Model = model
                            };

            foreach(var entry in pageTypes)
            {
                _ = container.Register(Component.For<Page>().ImplementedBy(entry.Page).Named(entry.Model.FullName));
            }

            //_ = container.Register(Component.For<MasterDetailPage>().ImplementedBy<MainPage>());
            //_ = container.Register(Component.For<IViewFactory>().LifestyleTransient().AsFactory(new ViewFactoryComponentNameSelector()));
        }
    }

    //public interface IViewFactory
    //{
    //    Page Get<ViewModelBase>();
    //}

    //public class ViewFactoryComponentNameSelector : DefaultTypedFactoryComponentSelector
    //{
    //    protected override string GetComponentName(MethodInfo method, object[] arguments)
    //    {
    //        if (method.Name == "Get" &&
    //            arguments.Length == 0 &&
    //            method.GetGenericArguments().Length == 1)
    //        {
    //            var modelType = method.GetGenericArguments()[0];
    //            return modelType.FullName;
    //        }

    //        return base.GetComponentName(method, arguments);
    //    }
    //}
}