using Kafe.Controls;
using System;
using System.Globalization;
using System.Windows.Media;

namespace Kafe
{
    public class ConvertBooleanToSoftblueBackground : BaseValueConvertor<ConvertBooleanToSoftblueBackground>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? new SolidColorBrush(Color.FromRgb(25, 166, 255)) : new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}