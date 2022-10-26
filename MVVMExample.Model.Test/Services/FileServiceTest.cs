using Autofac;
using MVVMExample.Model.Models;
using MVVMExample.Model.Services.Interfaces;
using Moq;

namespace MVVMExample.Model.Test.Services
{
    [TestFixture]
    public class FileServiceTest : ServiceTestBase
    {
        private IFileService _fileService;
        private bool _mocked_FileManipulationServiceWriteFileFromStringResult;
        private ConfigModel _mocked_FileManipulationServiceReadJsonFromFileResult;

        [SetUp]
        public void SetUp_FileServiceTest()
        {
            _fileService = Container.Resolve<IFileService>();
            mocked_FileManipulationService.Setup(fms => fms.WriteFile(It.IsAny<string>(), It.IsAny<string>())).Returns(() => _mocked_FileManipulationServiceWriteFileFromStringResult);
            mocked_FileManipulationService.Setup(fms => fms.ReadJsonFromFile<ConfigModel>(It.IsAny<string>())).Returns(() => _mocked_FileManipulationServiceReadJsonFromFileResult);
        }

        [Test]
        public void ReadConfig_WhenCalledWithValidParameters_ReturnTrue()
        {
            _mocked_FileManipulationServiceReadJsonFromFileResult = new ConfigModel();
            var readConfigResult = _fileService.ReadConfig();

            Assert.That(readConfigResult, Is.TypeOf<ConfigModel>());
        }

        [Test]
        public void ReadConfig_JsonParsingError_ReturnNull()
        {
            _mocked_FileManipulationServiceReadJsonFromFileResult = null;
            var readConfigResult = _fileService.ReadConfig();

            Assert.That(readConfigResult, Is.Null);
        }
    }
}
