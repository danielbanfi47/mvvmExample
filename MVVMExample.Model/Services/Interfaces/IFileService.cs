using MVVMExample.Model.Models;

namespace MVVMExample.Model.Services.Interfaces
{
    public interface IFileService
    {
        ConfigModel? ReadConfig();
    }
}