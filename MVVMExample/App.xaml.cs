using Autofac;
using System.Windows;

namespace MVVMExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IContainer? Container { get; private set; }
        protected override void OnExit(ExitEventArgs e)
        {
            Container?.Dispose();

            base.OnExit(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<ViewModule>();
            Container = builder.Build();

            base.OnStartup(e);
        }
    }
}
