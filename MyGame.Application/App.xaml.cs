using MyGame.Data;
using MyGame.ViewModels;
using MyGame.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyGame
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application, IScreen
    {
        public App()
        {

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Router =new RoutingState();
            var dependencyResolver = (ModernDependencyResolver) RxApp.MutableResolver;

            RegisterParts(dependencyResolver);

            LogHost.Default.Level = LogLevel.Debug;

            var service = RxApp.DependencyResolver.GetService<IService>();
            if (!service.IsActive)
            {
                service.Start();
            }
        }

        private void RegisterParts(IMutableDependencyResolver resolver)
        {
            resolver.RegisterConstant(this, typeof(IScreen));
            resolver.RegisterConstant(this.Router, typeof(IRoutingState));

            resolver.Register(() => new Service(), typeof(IService));
        }

        public IRoutingState Router { get; private set; }
    }
}
