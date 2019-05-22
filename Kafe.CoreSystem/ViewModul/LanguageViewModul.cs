using Kafe.Controls;
using System;

namespace Kafe.CoreSystem
{
    public class LanguageViewModul : BaseViewModul
    {
        public event Action<TranslateTo> LanguageChanged = (sender) => { };

        public static LanguageViewModul Instand { get => new LanguageViewModul(); }

        private TranslateTo translate = TranslateTo.Khmer;

        public TranslateTo Translate
        {
            get { return translate; }
            set
            {
                if (translate == value)
                    return;
                translate = value;
                LanguageChanged(translate);
                OnPropertyChanged();
            }
        }
    }
}