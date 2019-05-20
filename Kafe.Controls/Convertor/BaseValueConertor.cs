using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Kafe.Controls
{
    public abstract class BaseValueConvertor<Chile> : MarkupExtension, IValueConverter where
        Chile:BaseValueConvertor<Chile>,new()
    {
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new Chile();
        }
    }
}
