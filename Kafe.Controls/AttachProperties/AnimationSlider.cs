using System.Threading.Tasks;
using System.Windows;

namespace Kafe.Controls
{
    public class AnimationSlider : BaseAttachProperty<AnimationSlider, SlideAninmation>
    {
        public async override void OnValueUpdated(DependencyObject dependency, object value)
        {
            var element = dependency as FrameworkElement;

            await Task.Delay(50);

            await element.EnterAnimation((SlideAninmation)value);
        }
    }
}