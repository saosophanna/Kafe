using Kafe.Controls;

namespace Kafe.CoreSystem
{
    public class ApplicationViewModul : BaseViewModul
    {
        public static ApplicationViewModul Instand { get => new ApplicationViewModul(); }

        private ApplicationPage currentPage = ApplicationPage.Menu;

        public ApplicationPage CurrentPage
        {
            get { return currentPage; }
            set
            {
                if (currentPage == value)
                    return;
                currentPage = value;
                OnPropertyChanged();
            }
        }
    }
}