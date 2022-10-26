using MVVMExample.Model.Models;
using MVVMExample.Model.Services.Interfaces;
using MVVMExample.VM.Interface;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using MVVMExample.Model.Services;

namespace MVVMExample.VM.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        #region Variables and Properties
        private readonly IFileService _fileService;
        private readonly IMessageBoxWindow _messageBoxWindow;
        private ConfigModel _configModel;

        public RelayCommand ClosingCommand { get; set; }

        #endregion

        public MainWindowViewModel(
            IFileService fileService,
            IMessageBoxWindow messageBoxWindow)
        {
            _fileService = fileService;
            _messageBoxWindow = messageBoxWindow;
            ClosingCommand = new RelayCommand(() => Closing(), () => true);
            Initializing();
        }

        private void Question()
        {
            var respond = _messageBoxWindow.ShowMessageBox();
        }

        private void Initializing()
        {
            _configModel = _fileService.ReadConfig();
        }

        public void Closing()
        {

        }
    }
}
