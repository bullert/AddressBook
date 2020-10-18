using AddressBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class GenderAdapter
    {
        public GenderAdapter()
        {
            PairsList = new List<KeyValuePair<Gender, string>> {
                new KeyValuePair<Gender, string>( AddressBook.Enums.Gender.Male, "Mężczyzna" ),
                new KeyValuePair<Gender, string>( AddressBook.Enums.Gender.Female, "Kobieta" )
            };

            ExtendedPairsList = new List<KeyValuePair<Gender, string>>(PairsList);
            ExtendedPairsList.Add(new KeyValuePair<Gender, string>(AddressBook.Enums.Gender.None, "Brak"));
        }

        public List<KeyValuePair<Gender, string>> PairsList { get; private set; }
        public List<KeyValuePair<Gender, string>> ExtendedPairsList { get; private set; }

        public string GetLabelByValue(Gender gender)
        {
            return ExtendedPairsList.FirstOrDefault(item => item.Key == gender).Value;
        }

        public Gender GetValueByLabel(string gender)
        {
            return ExtendedPairsList.FirstOrDefault(item => item.Value == gender).Key;
        }
    }
}
