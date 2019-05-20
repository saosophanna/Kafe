using Kafe.Controls;
using System;
using System.Globalization;
using System.Windows;

namespace Kafe.Convertor
{
    public class ConvertBooleanToVisibility : BaseValueConvertor<ConvertBooleanToVisibility>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
