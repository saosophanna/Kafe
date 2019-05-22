using System.Windows;
using System.Windows.Controls;

namespace Kafe.Controls
{
    public class PasswordAttach
    {
        public static void SetHasPassword(DependencyObject dependency, bool value) => dependency.SetValue(HasPasswordProperty, value);

        public static bool GetHasPassword(DependencyObject dependency) => (bool)dependency.GetValue(HasPasswordProperty);

        public static readonly DependencyProperty HasPasswordProperty =
            DependencyProperty.RegisterAttached("HasPassword", typeof(bool), typeof(PasswordAttach), new UIPropertyMetadata(default(bool), OnValueChanged));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is PasswordBox password))
                return;
            if (!(bool)e.NewValue)
                return;
            void Onload(object sender, RoutedEventArgs ev)
            {
                password.Loaded -= Onload;
                password.PasswordChanged += Password_PasswordChanged;
            }
            password.Loaded += Onload;
        }

        private static void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var password = sender as PasswordBox;
            SetHasPassword(password, password.SecurePassword.Length > 0);
        }
    }
}