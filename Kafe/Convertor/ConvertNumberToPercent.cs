using System;
using System.Globalization;

namespace Kafe
{
    public class ConvertNumberToPercent : Controls.BaseValueConvertor<ConvertNumberToPercent>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "-"+value + "%";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
