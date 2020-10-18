using AddressBook.Commands;
using AddressBook.Enums;
using AddressBook.Models;
using AddressBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AddressBook.ViewModels
{
    public class A
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }

    public class AddressListViewModel : BaseViewModel, IViewModel
    {
        private List<Subscriber> subscribersList;
        private List<Subscriber> filteredSubscribersList;
        private string firstNameFilter;
        private string lastNameFilter;
        private Gender genderFilter;
        private int yearOfBirthMinRangeFilter;
        private int yearOfBirthMaxRangeFilter;
        private string streetFilter;
        private string cityFilter;
        private string propertyNumberFilter;
        private string postcodeFilter;
        private GenderAdapter genderAdapter;
        private YearOfBirthAdapter yearOfBirthAdapter;
        private bool isEditModeEnabled = false;
        private bool toggleSelectAll = false;

        public AddressListViewModel(MainViewModel mainViewModel) : base(mainViewModel)
        {
            SaveAddressListCommand = new SaveAddressListCommand(this);
            LoadAddressListCommand = new LoadAddressListCommand(this);
            ToggleEditModeCommand = new ToggleEditModeCommand(this);
            DeleteSelectedSubscribersCommand = new DeleteSelectedSubscribersCommand(this);

            LoadAddressList();

            genderAdapter = new GenderAdapter();
            yearOfBirthAdapter = new YearOfBirthAdapter();
            
            FilterList();
        }

        public List<Subscriber> SubscribersList
        {
            get
            {
                return subscribersList;
            }
            set
            {
                subscribersList = value;
                OnPropertyChanged();
            }
        }

        public List<Subscriber> FilteredSubscribersList
        {
            get
            {
                return filteredSubscribersList;
            }
            set
            {
                filteredSubscribersList = value;
                OnPropertyChanged();
            }
        }

        public string FirstNameFilter
        {
            get
            {
                return firstNameFilter;
            }
            set
            {
                firstNameFilter = value;
                OnPropertyChanged();
                FilterList();
            }
        }

        public string LastNameFilter
        {
            get
            {
                return lastNameFilter;
            }
            set
            {
                lastNameFilter = value;
                OnPropertyChanged();
                FilterList();
            }
        }

        public Gender GenderFilter
        {
            get
            {
                return genderFilter;
            }
            set
            {
                genderFilter = value;
                OnPropertyChanged();
                FilterList();
            }
        }

        public int YearOfBirthMinRangeFilter
        {
            get
            {
                return yearOfBirthMinRangeFilter;
            }
            set
            {
                yearOfBirthMinRangeFilter = value;
                OnPropertyChanged();
                FilterList();
            }
        }

        public int YearOfBirthMaxRangeFilter
        {
            get
            {
                return yearOfBirthMaxRangeFilter;
            }
            set
            {
                yearOfBirthMaxRangeFilter = value;
                OnPropertyChanged();
                FilterList();
            }
        }

        public string CityFilter
        {
            get
            {
                return cityFilter;
            }
            set
            {
                cityFilter = value;
                OnPropertyChanged();
                FilterList();
            }
        }

        public string StreetFilter
        {
            get
            {
                return streetFilter;
            }
            set
            {
                streetFilter = value;
                OnPropertyChanged();
                FilterList();
            }
        }

        public string PropertyNumberFilter
        {
            get
            {
                return propertyNumberFilter;
            }
            set
            {
                propertyNumberFilter = value;
                OnPropertyChanged();
                FilterList();
            }
        }

        public string PostcodeFilter
        {
            get
            {
                return postcodeFilter;
            }
            set
            {
                postcodeFilter = value;
                OnPropertyChanged();
                FilterList();
            }
        }

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

        public bool IsEditModeEnabled
        {
            get
            {
                return isEditModeEnabled;
            }
            set
            {
                isEditModeEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool ToggleSelectAll
        {
            get
            {
                return toggleSelectAll;
            }
            set
            {
                toggleSelectAll = value;
                OnPropertyChanged();
                FilteredSubscribersList.ForEach(item => item.CanDelete = ToggleSelectAll);
                RefreshSubscribersProperties();
            }
        }

        public ICommand SaveAddressListCommand { get; private set; }

        public ICommand LoadAddressListCommand { get; private set; }

        public ICommand ToggleEditModeCommand { get; private set; }

        public ICommand DeleteSelectedSubscribersCommand { get; private set; }

        public void AddSubscriber(Subscriber subscriber)
        {
            SubscribersList.Add(subscriber);
        }

        public void SaveAddressList()
        {
            new AddressListWriter().SaveAddressList(SubscribersList);
        }

        public void LoadAddressList()
        {
            SubscribersList = new AddressListReader().LoadAddressList();
        }

        public void DeleteSelectedSubscribers()
        {
            FilteredSubscribersList.RemoveAll(item => item.CanDelete == true);
            RefreshSubscribersProperties();
        }

        private void RefreshSubscribersProperties()
        {
            FilteredSubscribersList = new List<Subscriber>(FilteredSubscribersList);
        }

        public void FilterList()
        {
            var partlyFilteredList = SubscribersList;

            if (FirstNameFilter != null && FirstNameFilter != string.Empty)
            {
                partlyFilteredList = partlyFilteredList.FindAll(
                    i => i.FirstName.ToLower().Contains(FirstNameFilter.ToLower())
                );
            }
            if (LastNameFilter != null && LastNameFilter != string.Empty)
            {
                partlyFilteredList = partlyFilteredList.FindAll(
                    i => i.LastName.ToLower().Contains(LastNameFilter.ToLower())
                );
            }
            if (GenderFilter != Gender.None)
            {
                partlyFilteredList = partlyFilteredList.FindAll(
                    i => i.Gender == GenderFilter
                );
            }
            if (YearOfBirthMinRangeFilter != 0)
            {
                partlyFilteredList = partlyFilteredList.FindAll(
                    i => i.YearOfBirth >= YearOfBirthMinRangeFilter
                );
            }
            if (YearOfBirthMaxRangeFilter != 0)
            {
                partlyFilteredList = partlyFilteredList.FindAll(
                    i => i.YearOfBirth <= YearOfBirthMaxRangeFilter
                );
            }
            if (CityFilter != null && CityFilter != string.Empty)
            {
                partlyFilteredList = partlyFilteredList.FindAll(
                    i => i.Address.City.ToLower().Contains(CityFilter.ToLower())
                );
            }
            if (StreetFilter != null && StreetFilter != string.Empty)
            {
                partlyFilteredList = partlyFilteredList.FindAll(
                    i => i.Address.Street.ToLower().Contains(StreetFilter.ToLower())
                );
            }
            if (PropertyNumberFilter != null && PropertyNumberFilter != string.Empty)
            {
                partlyFilteredList = partlyFilteredList.FindAll(
                    i => i.Address.PropertyNumber.ToLower().Contains(PropertyNumberFilter.ToLower())
                );
            }
            if (PostcodeFilter != null && PostcodeFilter != string.Empty)
            {
                partlyFilteredList = partlyFilteredList.FindAll(
                    i => i.Address.Postcode.ToLower().Contains(PostcodeFilter.ToLower())
                );
            }

            FilteredSubscribersList = partlyFilteredList;
        }
    }
}
