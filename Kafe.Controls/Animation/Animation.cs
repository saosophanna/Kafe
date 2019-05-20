using System;
using System.Threading.Tasks;
using System.Windows;

namespace Kafe.Controls
{
    public class Animation
    {
        public static void SetAnimation(DependencyObject dependency, SlideAninmation aninmation) => dependency.SetValue(AnimationProperty, aninmation);
        
        public static SlideAninmation GetAnimation(DependencyObject dependency) => (SlideAninmation)dependency.GetValue(AnimationProperty);

        public readonly static DependencyProperty AnimationProperty =
            DependencyProperty.RegisterAttached("AnimationProperty",
                typeof(SlideAninmation), typeof(Animation),
                new UIPropertyMetadata(default(SlideAninmation),
                    OnValueChange,OnValueUpdate,true));

        private static void OnValueChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        private static object OnValueUpdate(DependencyObject dependency ,object value)
        {
            if (!(dependency is FrameworkElement element))
                return value;

            void OnLoad(object sender,RoutedEventArgs eventArgs)
            {
                EnterAnimation(element, (SlideAninmation)value);
            }
            element.Loaded += OnLoad;

            return value;
        }

        private async static void EnterAnimation(FrameworkElement element,SlideAninmation slideAninmation)
        {
            await element.EnterAnimation(slideAninmation);
        }
    }
}
