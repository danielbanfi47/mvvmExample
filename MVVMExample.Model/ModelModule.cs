using Autofac;
using MVVMExample.Model.Services;
using MVVMExample.Model.Services.Interfaces;

namespace MVVMExample.Model
{
     public class ModelModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<FileManipulationService>().As<IFileManipulationService>().SingleInstance();
            builder.RegisterType<FileService>().As<IFileService>().SingleInstance();
            //builder.RegisterType<TCPConnection>().As<ITCPConnection>().SingleInstance();
            //builder.RegisterType<UpdateCeckerService>().As<IUpdateCeckerService>().SingleInstance();
            //builder.RegisterType<PLCControlService>().As<IPLCControlService>().SingleInstance();
        }
    }
}
