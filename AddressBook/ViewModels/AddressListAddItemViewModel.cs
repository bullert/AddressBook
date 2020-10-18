using AddressBook.Commands;
using AddressBook.Enums;
using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AddressBook.ViewModels
{
    public class AddressListAddItemViewModel : ValidableViewModel, IViewModel
    {
        private Subscriber subscriber;
        private List<KeyValuePair<int, string>> ageList;
        private GenderAdapter genderAdapter;
        private YearOfBirthAdapter yearOfBirthAdapter;

        public AddressListAddItemViewModel(MainViewModel mainViewModel) : base(mainViewModel)
        {
            Initialize();
        }

        public ICommand AddSubscriberCommand { get; private set; }

        public GenderAdapter GenderAdapter
        {
            get
            {
                return genderAdapter;
            }
            private set
            {
                genderAdapter = value;
                OnPropertyChanged();
            }
        }

        public YearOfBirthAdapter YearOfBirthAdapter
        {
            get
            {
                return yearOfBirthAdapter;
            }
            private set
            {
                yearOfBirthAdapter = value;
                OnPropertyChanged();
            }
        }

        public Subscriber Subscriber
        {
            get
            {
                return subscriber;
            }
            set
            {
                subscriber = value;
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "To pole nie może być puste.")]
        [RegularExpression(@"^([a-zA-Z' '])*$", ErrorMessage = "Nieprawidłowy format.")]
        public string FirstName
        {
            get
            {
                return subscriber.FirstName;
            }
            set
            {
                subscriber.FirstName = value;
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "To pole nie może być puste.")]
        [RegularExpression(@"^([a-zA-Z' '])*$", ErrorMessage = "Nieprawidłowy format.")]
        public string LastName
        {
            get
            {
                return subscriber.LastName;
            }
            set
            {
                subscriber.LastName = value;
                OnPropertyChanged();
            }
        }

        [RegularExpression(@"^(?!0$).*$", ErrorMessage = "To pole nie może być puste.")]
        public int YearOfBirth
        {
            get
            {
                return subscriber.YearOfBirth;
            }
            set
            {
                subscriber.YearOfBirth = value;
                OnPropertyChanged();
            }
        }

        [RegularExpression(@"^(?!None$).*$", ErrorMessage = "To pole nie może być puste.")]
        public Gender Gender
        {
            get
            {
                return subscriber.Gender;
            }
            set
            {
                subscriber.Gender = value;
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "To pole nie może być puste.")]
        [RegularExpression(@"^([a-zA-Z' '])*$", ErrorMessage = "Nieprawidłowy format.")]
        public string City
        {
            get
            {
                return subscriber.Address.City;
            }
            set
            {
                subscriber.Address.City = value;
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "To pole nie może być puste.")]
        [RegularExpression(@"^([a-zA-Z' '])*$", ErrorMessage = "Nieprawidłowy format.")]
        public string Street
        {
            get
            {
                return subscriber.Address.Street;
            }
            set
            {
                subscriber.Address.Street = value;
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "To pole nie może być puste.")]
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Nieprawidłowy format.")]
        public string Postcode
        {
            get
            {
                return subscriber.Address.Postcode;
            }
            set
            {
                subscriber.Address.Postcode = value;
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "To pole nie może być puste.")]
        [RegularExpression(@"^([\d])+([a-zA-Z\d'/'])*$", ErrorMessage = "Nieprawidłowy format.")]
        public string PropertyNumber
        {
            get
            {
                return subscriber.Address.PropertyNumber;
            }
            set
            {
                subscriber.Address.PropertyNumber = value;
                OnPropertyChanged();
            }
        }

        private void Initialize()
        {
            genderAdapter = new GenderAdapter();
            yearOfBirthAdapter = new YearOfBirthAdapter();

            Subscriber = new Subscriber();
            Subscriber.Address = new Address();

            ValidateProperty("FirstName", true);
            ValidateProperty("LastName", true);
            ValidateProperty("Gender", true);
            ValidateProperty("YearOfBirth", true);
            ValidateProperty("City", true);
            ValidateProperty("Street", true);
            ValidateProperty("Postcode", true);
            ValidateProperty("PropertyNumber", true);

            AddSubscriberCommand = new AddSubscriberCommand(this);
        }

        public void AddSubscriber()
        {
            foreach (var property in ValidatedProperties)
            {
                OnPropertyChanged(property);
            }

            if (IsValid)
            {
                var addressListVM = MainViewModel.GetViewModelInstance(ViewModel.AddressListViewModel);
                (addressListVM as AddressListViewModel).AddSubscriber(Subscriber);
                MainViewModel.ResetViewModel(ViewModel.AddressListAddItemViewModel);
                MainViewModel.ChangeViewModel(ViewModel.AddressListViewModel);
            }
        }
    }
}
