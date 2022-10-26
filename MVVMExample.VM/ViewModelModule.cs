using Autofac;
using MVVMExample.Model;
using MVVMExample.VM.ViewModels;

namespace MVVMExample.VM
{
    public class ViewModelModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterModule<ModelModule>();

            builder.RegisterType<MainWindowViewModel>().AsSelf().SingleInstance();
        }
    }
}
