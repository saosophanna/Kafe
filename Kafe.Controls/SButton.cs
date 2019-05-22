using System.Windows;
using System.Windows.Controls;

namespace Kafe.Controls
{
    public class SButton : Button
    {
        public static void SetCornerRadius(DependencyObject dependency, CornerRadius value) => dependency.SetValue(CornerRadiusProperty, value);

        public static CornerRadius GetCornerRadius(DependencyObject dependency) => (CornerRadius)dependency.GetValue(CornerRadiusProperty);

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(SButton), new FrameworkPropertyMetadata(default(CornerRadius), FrameworkPropertyMetadataOptions.Inherits));
    }
}