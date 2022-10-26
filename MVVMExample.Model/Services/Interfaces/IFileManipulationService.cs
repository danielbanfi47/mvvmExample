using System.Collections.Generic;

namespace MVVMExample.Model.Services.Interfaces
{
    public interface IFileManipulationService
    {
        bool DirectoryExist(string directoryLink);
        bool FileExist(string fileLink);
        List<string> ReadFileToList(string fileLink);
        string ReadFile(string fileLink);
        bool WriteFile(string fileLink, List<string> content);
        bool WriteFile(string fileLink, string content);
        T ReadJsonFromFile<T>(string fileLink);
        string SerializeJson<T>(T content);
    }
}