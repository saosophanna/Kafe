using System;
using System.Globalization;

namespace Kafe.Controls
{
    public class ConvertNumberToBoolean : BaseValueConvertor<ConvertNumberToBoolean>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var number = (int)value;

            return number == 0 ? false : true;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}