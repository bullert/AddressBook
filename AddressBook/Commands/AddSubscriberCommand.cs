using AddressBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AddressBook.Commands
{
    public class AddSubscriberCommand : ICommand
    {
        private AddressListAddItemViewModel viewModel;

        public AddSubscriberCommand(AddressListAddItemViewModel viewModel)
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
            viewModel.AddSubscriber();
        }
    }
}
