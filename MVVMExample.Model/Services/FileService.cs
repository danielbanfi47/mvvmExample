using MVVMExample.Model.Models;
using MVVMExample.Model.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace MVVMExample.Model.Services
{
    public class FileService : IFileService
    {
        private readonly IFileManipulationService _fileManipulationService;
        private static string CONFIG_FILE_LOCATION = @"config\config.json";

        public FileService(
            IFileManipulationService fileManipulationService)
        {
            _fileManipulationService = fileManipulationService;
        }


        public ConfigModel? ReadConfig()
        {
            if (!_fileManipulationService.FileExist(CONFIG_FILE_LOCATION))
            {
                CreateDefaultConfigFile();
            }

            try
            {
                return _fileManipulationService.ReadJsonFromFile<ConfigModel>(CONFIG_FILE_LOCATION);

            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool CreateDefaultConfigFile()
        {
            var defaultConfig = new ConfigModel();
            defaultConfig.TargetList = new List<TargetModel>();
            var configurationJson = _fileManipulationService.SerializeJson<ConfigModel>(defaultConfig);

            try
            {
                _fileManipulationService.WriteFile(@CONFIG_FILE_LOCATION, configurationJson);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
