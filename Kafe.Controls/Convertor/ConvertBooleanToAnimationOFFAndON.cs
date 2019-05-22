using System;
using System.Globalization;

namespace Kafe.Controls
{
    public class ConvertBooleanToAnimationOFFAndON : BaseValueConvertor<ConvertBooleanToAnimationOFFAndON>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? SlideAninmation.LetfToRight : SlideAninmation.RightToLetf;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}