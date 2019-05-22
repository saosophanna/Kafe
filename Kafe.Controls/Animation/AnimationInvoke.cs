using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Kafe.Controls
{
    public static class AnimationInvoke
    {
        public static ThicknessAnimation GetThicknessAnimation(Thickness from, Thickness to, int timeSpan, float decorate = .9f)
        {
            return new ThicknessAnimation()
            {
                From = from,
                To = to,
                Duration = TimeSpan.FromMilliseconds(timeSpan),
                DecelerationRatio = decorate,
                EasingFunction = new QuarticEase()
            };
        }

        public static DoubleAnimation GetOpacityAnimation(bool IsShow, int timeSpan)
        {
            return new DoubleAnimation()
            {
                From = IsShow ? 0 : 1,
                To = IsShow ? 1 : 0,
                Duration = TimeSpan.FromMilliseconds(timeSpan),
                EasingFunction = new QuarticEase()
            };
        }

        public static async Task FromBotttomWithOpacityAsync(this FrameworkElement element, int timeSpan = 2500, float decorate = .9f)
        {
            var ta = GetThicknessAnimation(new Thickness(0, element.ActualHeight / 3, 0, -element.ActualHeight / 3),
                new Thickness(0), timeSpan, decorate);
            var oa = GetOpacityAnimation(true, timeSpan);

            element.BeginAnimation(FrameworkElement.MarginProperty, ta);

            element.BeginAnimation(UIElement.OpacityProperty, oa);

            await Task.Delay(timeSpan);
        }

        public static async Task FadeOut(this FrameworkElement element, int timeSpan = 1500, float decorate = .9f)
        {
            var ta = GetThicknessAnimation(new Thickness(element.ActualWidth / 4, element.ActualHeight / 4,
                element.ActualWidth / 4, element.ActualHeight / 4),
                new Thickness(0), timeSpan, decorate);

            var oa = GetOpacityAnimation(true, timeSpan);

            element.BeginAnimation(FrameworkElement.MarginProperty, ta);

            element.BeginAnimation(UIElement.OpacityProperty, oa);

            await Task.Delay(timeSpan);
        }

        public static async Task FadeIn(this FrameworkElement element, int timeSpan = 1500, float decorate = .9f)
        {
            var ta = GetThicknessAnimation(new Thickness(0),
                new Thickness(element.ActualWidth / 4, element.ActualHeight / 4,
                element.ActualWidth / 4, element.ActualHeight / 4), timeSpan, decorate);

            var oa = GetOpacityAnimation(true, timeSpan);

            element.BeginAnimation(FrameworkElement.MarginProperty, ta);

            element.BeginAnimation(UIElement.OpacityProperty, oa);

            await Task.Delay(timeSpan);
        }

        public static async Task LeftToRight(this FrameworkElement element, int timeSpan = 500, float decorate = 0.9f)
        {
            var ta = GetThicknessAnimation(new Thickness(0, 0, element.ActualWidth / 2, 0),
                new Thickness(element.ActualWidth / 2, 0, 0, 0), timeSpan, decorate);

            element.BeginAnimation(FrameworkElement.MarginProperty, ta);

            await Task.Delay(timeSpan);
        }

        public static async Task RightToLetf(this FrameworkElement element, int timeSpan = 500, float decorate = 0.9f)
        {
            var ta = GetThicknessAnimation(new Thickness(element.ActualWidth / 2, 0, 0, 0),
                new Thickness(0, 0, element.ActualWidth / 2, 0), timeSpan, decorate);

            element.BeginAnimation(FrameworkElement.MarginProperty, ta);

            await Task.Delay(timeSpan);
        }

        public static async Task FromTopON(this FrameworkElement element, int timeSpan = 700, float delerate = .9f)
        {
            var da = new DoubleAnimation()
            {
                From = 0,
                To = 80,
                Duration = TimeSpan.FromMilliseconds(timeSpan),
                EasingFunction = new QuarticEase(),
                DecelerationRatio = delerate
            };

            element.BeginAnimation(FrameworkElement.HeightProperty, da);

            await Task.Delay(timeSpan);
        }

        public static async Task FromTopOFF(this FrameworkElement element, int timeSpan = 700, float delerate = .9f)
        {
            var da = new DoubleAnimation()
            {
                From = 80,
                To = 0,
                Duration = TimeSpan.FromMilliseconds(timeSpan),
                EasingFunction = new QuarticEase(),
                DecelerationRatio = delerate
            };

            element.BeginAnimation(FrameworkElement.HeightProperty, da);

            await Task.Delay(timeSpan);
        }

        public static async Task FromHiddenLeftToRitht(this FrameworkElement element, int timeSpan=1300, float descelerate = .9f)
        {
            var ta = GetThicknessAnimation(new Thickness(-element.ActualWidth, 0, element.ActualHeight, 0),
                new Thickness(0), timeSpan, descelerate);

            var oa = GetOpacityAnimation(true, timeSpan);
            
            element.BeginAnimation(FrameworkElement.MarginProperty, ta);

            element.BeginAnimation(UIElement.OpacityProperty, oa);

            await Task.Delay(timeSpan);
        }

        public static async Task ToHidenLeft(this FrameworkElement element, int timeSpan=1300, float descelerate = .9f)
        {
            var ta = GetThicknessAnimation(new Thickness(0),
                new Thickness(-element.ActualWidth+70, 0, element.ActualHeight+70, 0), timeSpan, descelerate);

            var oa = GetOpacityAnimation(true, timeSpan);

            element.BeginAnimation(FrameworkElement.MarginProperty, ta);

            element.BeginAnimation(UIElement.OpacityProperty, oa);

            await Task.Delay(timeSpan);
        }


        public static async Task EnterAnimation(this FrameworkElement element, SlideAninmation slideAninmation)
        {
            switch (slideAninmation)
            {
                case SlideAninmation.None:
                    break;

                case SlideAninmation.FromBottomWithOpacity:
                    await element.FromBotttomWithOpacityAsync();
                    break;

                case SlideAninmation.FadeOut:
                    await element.FadeOut();
                    break;

                case SlideAninmation.FadeIn:
                    await element.FadeIn();
                    break;

                case SlideAninmation.LetfToRight:
                    await element.LeftToRight();
                    break;

                case SlideAninmation.RightToLetf:
                    await element.RightToLetf();
                    break;

                case SlideAninmation.FromTop:
                    await element.FromTopON();
                    break;

                case SlideAninmation.ToTop:
                    await element.FromTopOFF();
                    break;
                case SlideAninmation.FromHiddenLeftToRight:
                    await element.FromHiddenLeftToRitht();
                    break;
                case SlideAninmation.ToHiddenLeft:
                    await element.ToHidenLeft();
                    break;
                default:
                    return;
            }
        }
    }
}