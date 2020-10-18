using AddressBook.Enums;
using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AddressBook.Converters
{
    [ValueConversion(typeof(Gender), typeof(String))]
    public class GenderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new GenderAdapter().GetLabelByValue((Gender)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new GenderAdapter().GetValueByLabel((string)value);
        }
    }
}
