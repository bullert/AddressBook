using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Address
    {
        public Address() : this(null, null, null, null)
        {

        }

        public Address(string city, string street, string postcode, string  propertyNumber)
        {
            City = city;
            Street = street;
            Postcode = postcode;
            PropertyNumber = propertyNumber;
        }

        public string City { get; set; }

        public string Street { get; set; }

        public string Postcode { get; set; }

        public string PropertyNumber { get; set; }
    }
}
