using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WinIPTVApp.Dialogs.References;

namespace WinIPTVApp.Dialogs.AlertDialog
{
    public class AlertDialogViewModel:DialogViewModelBase<DialogResult>
    {
        public ICommand OKCommand { get; set; }

        public AlertDialogViewModel(string title, string message) : base(title, message)
        {
            OKCommand = new RelayCommand<IDialogWindow>(OK);
        }

        private void OK(IDialogWindow window)
        {
            CloseDialogWithResult(window, DialogResult.Undefined);
        }
    }
}
