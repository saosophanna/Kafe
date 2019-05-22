using Kafe.Controls;
using System;
using System.Globalization;

namespace Kafe
{
    public class ConvertNumberToCurrency : BaseValueConvertor<ConvertNumberToCurrency>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "$" + value;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}