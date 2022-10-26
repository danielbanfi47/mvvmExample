using MVVMExample.Model.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MVVMExample.Model.Services
{
    public class FileManipulationService : IFileManipulationService
    {
        public bool FileExist(string fileLink)
        {
            return File.Exists(fileLink);
        }

        public bool DirectoryExist(string directoryLink)
        {
            return Directory.Exists(directoryLink);
        }

        public List<string> ReadFileToList(string fileLink)
        {
            if (!FileExist(fileLink))
            {
                return new List<string>();
            }

            return File.ReadAllLines(fileLink).ToList<string>();
        }

        public string ReadFile(string fileLink)
        {
            if (!FileExist(fileLink))
            {
                return null;
            }

            return File.ReadAllText(fileLink);
        }

        public bool WriteFile(string fileLink, List<string> content)
        {
            if (string.IsNullOrWhiteSpace(fileLink))
            {
                return false;
            }

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fileLink));
                File.WriteAllLines(fileLink, content);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool WriteFile(string fileLink, string content)
        {
            if (string.IsNullOrWhiteSpace(fileLink))
            {
                return false;
            }

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fileLink));
                File.WriteAllText(fileLink, content);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T ReadJsonFromFile<T>(string fileLink)
        {
            return JsonConvert.DeserializeObject<T>(ReadFile(fileLink));
        }

        public string SerializeJson<T>(T content)
        {
            return  JsonConvert.SerializeObject(content, Formatting.Indented);
        }
    }
}
