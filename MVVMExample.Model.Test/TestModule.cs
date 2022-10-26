using Autofac;
using MVVMExample.Model.Services;
using MVVMExample.Model.Services.Interfaces;

namespace MVVMExample.Model.Test
{
    public class TestModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<FileManipulationService>().As<IFileManipulationService>().SingleInstance();
            builder.RegisterType<FileService>().As<IFileService>().SingleInstance();
        }
    }
}

