using Kafe.CoreSystem;

namespace Kafe
{
    public class ShareApplication
    {
        public static ShareApplication Instand { get => new ShareApplication(); }

        public ApplicationViewModul Application { get; private set; } = ApplicationViewModul.Instand;
    }
}