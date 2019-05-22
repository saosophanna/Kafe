using Kafe.Controls;
using Kafe.CoreSystem;
using System.Windows;
using System.Windows.Input;

namespace Kafe
{
    public class WindowViewModul : BaseViewModul
    {
        private Window mWindow;

        public static WindowViewModul Instand { get => new WindowViewModul(); }

        private string state = "[ ]";

        public string State
        {
            get { return state; }
            set { state = value; OnPropertyChanged(); }
        }

        public Languages Title { get; private set; }

        public TranslateTo SelectedTranslated
        {
            get => IoC.Get<LanguageViewModul>().Translate;
            set
            {
                if (IoC.Get<LanguageViewModul>().Translate == value)
                    return;
                IoC.Get<LanguageViewModul>().Translate = value;
            }
        }

        public ICommand MinimizeCommand { get; set; }

        public ICommand StateCommmand { get; set; }

        public ICommand CloseCommand { get; set; }

        public WindowViewModul(Window window) : this()
        {
            this.mWindow = window;

            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);

            StateCommmand = new RelayCommand(() => mWindow.WindowState = mWindow.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal);

            CloseCommand = new RelayCommand(() => mWindow.Close());

            mWindow.StateChanged += (sender, e) =>
            {
                State = mWindow.WindowState == WindowState.Normal ? "[ ]" : "[]";
            };
        }

        public WindowViewModul()
        {
            LanguagesChange();

            IoC.Get<LanguageViewModul>().LanguageChanged += (sender) =>
            {
                LanguagesChange();
            };
        }

        private void LanguagesChange()
        {
            Title = new Languages("កាហ្វេសូមស្វាគមន៏", "Welcome To Kafe");
            OnPropertyChanged(nameof(Title));
        }
    }
}