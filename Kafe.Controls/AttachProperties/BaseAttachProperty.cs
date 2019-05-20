using System.Windows;

namespace Kafe.Controls
{
    public class BaseAttachProperty<Child,Property>:FrameworkElement where
        Child:BaseAttachProperty<Child,Property>,new()
    {
        public static void SetValue(DependencyObject dependency, Property value) => dependency.SetValue(ValueProperty, value);

        public static Property GetValue(DependencyObject dependency) => (Property)dependency.GetValue(ValueProperty);

        public static Child Instand { get => new Child(); }

        public readonly static DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value",
                typeof(Property), typeof(BaseAttachProperty<Child, Property>),
                new UIPropertyMetadata(default(Property),
                    OnValueChange,OnValueUpdate,true));

        private static object OnValueUpdate(DependencyObject d, object baseValue)
        {
            if (!(d is FrameworkElement framework))
                return baseValue;

            Instand.OnValueUpdated(framework, baseValue);
            
            return baseValue;
        }

        private static void OnValueChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is FrameworkElement framework))
                return;
            Instand.OnValueChanged(framework, e);
        }

        public virtual void OnValueChanged(DependencyObject dependency, DependencyPropertyChangedEventArgs value) { }

        public virtual void OnValueUpdated(DependencyObject dependency, object value) { }
    }
}
