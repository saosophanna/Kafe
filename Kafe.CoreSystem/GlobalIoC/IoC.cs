using Ninject;

namespace Kafe.CoreSystem
{
    public class IoC
    {
        public static IKernel Kernel { get; set; } = new StandardKernel();

        public static T Get<T>() => Kernel.Get<T>();

        public static void CallSetUp()
        {
            SetBinding();
        }

        private static void SetBinding()
        {
            Kernel.Bind<LanguageViewModul>().ToConstant(new LanguageViewModul());
        }
    }
}
