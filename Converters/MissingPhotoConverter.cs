using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FitnessCenter.Converters
{
    public class MissingPhotoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || ((string)value) == "")
            {
                return "D:\\2k2s\\OOP_MY\\Курсач\\моя залупа\\Работал MyListBox и delete\\Test\\FintessCenter-08b29904dd9b128bdfdea8ffc3c463cad2e1991c\\Resources\\Images\\PhotoMssing.png";
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
