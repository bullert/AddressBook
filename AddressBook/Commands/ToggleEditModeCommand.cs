using AddressBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AddressBook.Commands
{
    public class ToggleEditModeCommand : ICommand
    {
        private AddressListViewModel viewModel;

        public ToggleEditModeCommand(AddressListViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.IsEditModeEnabled = !viewModel.IsEditModeEnabled;
        }
    }
}
