using System.Reflection;
using BitCobblers.StockTrader.Views;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System.Linq;
using Xamarin.Forms;
using System;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel;

namespace BitCobblers.StockTrader
{
    public partial class App : Application
    {
        private readonly IWindsorContainer container;

        public App()
        {
            InitializeComponent();

            var installers = from t in Assembly.GetExecutingAssembly().GetTypes()
                             where t.Namespace == "BitCobblers.StockTrader.Installers"
                             where t.GetInterfaces().Contains(typeof(IWindsorInstaller))
                             select (IWindsorInstaller)Activator.CreateInstance(t);

            this.container = new WindsorContainer();
            this.container.Kernel.Resolver.AddSubResolver(new ArrayResolver(this.container.Kernel, allowEmptyArray: true));

            _ = this.container
                .AddFacility<TypedFactoryFacility>()
                .Register(Component.For<IKernel>().Instance(this.container.Kernel))
                .Install(installers.ToArray());

            //this.MainPage = this.container.Resolve<MainPage>(); // new MainPage();
            this.MainPage = new MainPage();
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