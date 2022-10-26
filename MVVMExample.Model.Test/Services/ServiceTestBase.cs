using Autofac;
using MVVMExample.Model.Services.Interfaces;
using Moq;

namespace MVVMExample.Model.Test.Services
{

    [TestFixture]
    public class ServiceTestBase
    {
        protected IContainer Container;
        protected Mock<IFileManipulationService> mocked_FileManipulationService;

        [SetUp]
        public void SetUp_Base()
        {
            mocked_FileManipulationService = new Mock<IFileManipulationService>();

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<TestModule>();
            builder.RegisterInstance(mocked_FileManipulationService.Object).As<IFileManipulationService>().SingleInstance(); ;
            Container = builder.Build();
        }
    }
}
