using System.Windows;
using System.Windows.Controls;

namespace Kafe.Controls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Kafe.Controls.UserControls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Kafe.Controls.UserControls;assembly=Kafe.Controls.UserControls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class TextBoxDesign : TextBox
    {
        static TextBoxDesign()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextBoxDesign), new FrameworkPropertyMetadata(typeof(TextBoxDesign)));
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.RegisterAttached("Label", typeof(string), typeof(TextBoxDesign), new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetLabel(DependencyObject dependency, string value) => dependency.SetValue(LabelProperty, value);

        public static string GetLabel(DependencyObject dependency) => (string)dependency.GetValue(LabelProperty);

        public static readonly DependencyProperty CommentProperty =
            DependencyProperty.RegisterAttached("Comment", typeof(string), typeof(TextBoxDesign), new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetComment(DependencyObject dependency, string value) => dependency.SetValue(CommentProperty, value);

        public static string GetComment(DependencyObject dependency) => (string)dependency.GetValue(CommentProperty);

        public readonly static DependencyProperty LabelCollapedProperty =
            DependencyProperty.RegisterAttached("LabelCollaped", typeof(bool), typeof(TextBoxDesign),
                new FrameworkPropertyMetadata(default(bool), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetLabelCollaped(DependencyObject dependency, bool value) => dependency.SetValue(LabelCollapedProperty, value);

        public static bool GetLabelCollaped(DependencyObject dependency) => (bool)dependency.GetValue(LabelCollapedProperty);

        public readonly static DependencyProperty LabelWidthProperty =
            DependencyProperty.RegisterAttached("LabelWidth", typeof(double), typeof(TextBoxDesign),
                new FrameworkPropertyMetadata(default(double), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetLabelWidth(DependencyObject dependency, double value) => dependency.SetValue(LabelWidthProperty, value);

        public static double GetLabelWidth(DependencyObject dependency) => (double)dependency.GetValue(LabelWidthProperty);
    }
}