using Kafe.Controls;
using System;
using System.Globalization;

namespace Kafe
{
    public class ConvertBooleanToSlideToTop : BaseValueConvertor<ConvertBooleanToSlideToTop>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? SlideAninmation.FromTop : SlideAninmation.ToTop;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}