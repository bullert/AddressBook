using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.ViewModels
{
    public interface IViewModel
    {
        MainViewModel MainViewModel { get; set; }
    }
    public abstract class BaseViewModel : ObservableObject, IViewModel
    {
        private MainViewModel mainViewModel;

        public BaseViewModel() : this(null)
        {
            
        }
        public BaseViewModel(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public MainViewModel MainViewModel
        {
            get
            {
                return mainViewModel;
            }
            set
            {
                mainViewModel = value;
                OnPropertyChanged();
            }
        }
    }
}
