using MVVMExample.VM.Interface;
using System.Windows;

namespace MVVMExample.MessageBox
{
    public class MessageBoxWindow : IMessageBoxWindow
    {
        public bool ShowMessageBox()
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Question", "Title", MessageBoxButton.YesNoCancel);
            return result == MessageBoxResult.Yes ? true : false;
        }
    }
}
