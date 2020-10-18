using AddressBook.Commands;
using AddressBook.Enums;
using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AddressBook.ViewModels
{
    public class MainViewModel : BaseViewModel, IViewModel
    {
        private IViewModel selectedViewModel;
        private Dictionary<ViewModel, IViewModel> viewModelsRegister;

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            
            viewModelsRegister = new Dictionary<ViewModel, IViewModel>
            {
                { ViewModel.AddressListViewModel, new AddressListViewModel(this) },
                { ViewModel.AddressListAddItemViewModel, new AddressListAddItemViewModel(this) }
            };

            selectedViewModel = new AddressListViewModel(this);
        }

        public IViewModel SelectedViewModel
        {
            get
            {
                return selectedViewModel;
            }
            set
            {
                selectedViewModel = value;
                OnPropertyChanged();
            }
        }

        public ICommand UpdateViewCommand { get; private set; }

        public void ChangeViewModel(string parameter)
        {
            ViewModel viewModel = (ViewModel)Enum.Parse(typeof(ViewModel), parameter);
            ChangeViewModel(viewModel);
        }

        public void ChangeViewModel(ViewModel viewModel)
        {
            SelectedViewModel = GetViewModelInstance(viewModel);
        }

        public IViewModel GetViewModelInstance(ViewModel viewModel)
        {
            IViewModel instance;
            viewModelsRegister.TryGetValue(viewModel, out instance);
            return instance;
        }

        public void ResetViewModel(ViewModel viewModel)
        {
            Type type = GetViewModelInstance(viewModel).GetType();
            IViewModel instance = (IViewModel)Activator.CreateInstance(type, this);
            viewModelsRegister[viewModel] = instance;
        }
    }
}
