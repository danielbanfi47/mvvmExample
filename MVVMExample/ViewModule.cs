using Autofac;
using MVVMExample.MessageBox;
using MVVMExample.VM;
using MVVMExample.VM.Interface;

namespace MVVMExample
{
    public class ViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterModule<ViewModelModule>();
            builder.RegisterType<MessageBoxWindow>().As<IMessageBoxWindow>().SingleInstance();
            //builder.RegisterType<AboutWindowService>().As<IAboutWindowService>().SingleInstance();
            //builder.RegisterType<CurrentApplicationService>().As<ICurrentApplicationService>().SingleInstance();
            //builder.RegisterType<NewConfigAvailableWindowService>().As<INewConfigAvailableWindowService>().SingleInstance();
        }
    }
}
