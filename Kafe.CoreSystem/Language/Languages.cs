using Kafe.Controls;

namespace Kafe.CoreSystem
{
    public class Languages:BaseViewModul
    {

        public TranslateTo TranslateTo { get => IoC.Get<LanguageViewModul>().Translate; }

        public static TranslateTo[] LoadLanguage { get => new TranslateTo[] {TranslateTo.Khmer,TranslateTo.English }; }

        private string khmer;

        public string Khmer
        {
            get { return khmer; }
            set { khmer = value; OnPropertyChanged(); }
        }

        private string english;

        public string English
        {
            get { return english; }
            set { english = value; OnPropertyChanged(); }
        }

        public string Translate
        {
            get
            {
                switch (TranslateTo)
                {
                    case TranslateTo.Khmer:
                        return Khmer;
                    case TranslateTo.English:
                        return English;
                    default:
                        return string.Empty;
                }
            }
        }

        public Languages(string khmer, string english)
        {
            Khmer = khmer;
            English = english;
        }


    }
}
