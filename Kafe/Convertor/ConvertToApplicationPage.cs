using Kafe.Controls;
using System;
using System.Globalization;

namespace Kafe
{
    public class ConvertToApplicationPage : BaseValueConvertor<ConvertToApplicationPage>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.LogIn:
                    return new Menu();
                case ApplicationPage.Menu:
                    return new Menu();
                default:
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
