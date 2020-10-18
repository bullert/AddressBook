using AddressBook.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Subscriber
    {
        public Subscriber() : this(null, null, 0, Gender.None, new Address())
        {

        }

        public Subscriber(string firstName, string lastName, int yearOfBirth, Gender gender, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
            Gender = gender;
            Address = address;
            CanDelete = false;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public Gender Gender { get; set; }

        public Address Address { get; set; }

        public bool CanDelete { get; set; }
    }
}
