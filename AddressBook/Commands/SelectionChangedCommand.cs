using AddressBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AddressBook.Commands
{
    public class SelectionChangedCommand : ICommand
    {
        private AddressListViewModel viewModel;

        public SelectionChangedCommand(AddressListViewModel viewModel)
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
            //viewModel.GenderFilter = "afsfas";
            throw new Exception();
        }
    }
}
