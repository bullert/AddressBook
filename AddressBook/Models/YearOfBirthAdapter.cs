using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class YearOfBirthAdapter
    {
        public YearOfBirthAdapter()
        {
            PairsList = new List<KeyValuePair<int, string>>();

            int year = DateTime.Now.Year, gap = 150, len = year - gap;
            for (int i = year; i > len; i--)
            {
                PairsList.Add(new KeyValuePair<int, string>(i, i.ToString()));
            }

            ExtendedPairsList = new List<KeyValuePair<int, string>>(PairsList);
            ExtendedPairsList.Add(new KeyValuePair<int, string>(0, "Brak"));
        }

        public List<KeyValuePair<int, string>> PairsList { get; private set; }
        public List<KeyValuePair<int, string>> ExtendedPairsList { get; private set; }

        public string GetLabelByValue(int gender)
        {
            return ExtendedPairsList.FirstOrDefault(item => item.Key == gender).Value;
        }

        public int GetValueByLabel(string gender)
        {
            return ExtendedPairsList.FirstOrDefault(item => item.Value == gender).Key;
        }
    }
}
