using Kafe.Controls;
using System;
using System.Globalization;

namespace Kafe
{
    public class ConvertBooleanToLetfHiddenAnimation : BaseValueConvertor<ConvertBooleanToLetfHiddenAnimation>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? SlideAninmation.FromHiddenLeftToRight : SlideAninmation.ToHiddenLeft;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
