using Kafe.Controls;
using System.Runtime.Serialization;

namespace Kafe.CoreSystem
{
    public class Languages : BaseViewModul, ISerializable
    {
        public TranslateTo TranslateTo { get => IoC.Get<LanguageViewModul>().Translate; }

        public static TranslateTo[] LoadLanguage { get => new TranslateTo[] { TranslateTo.Khmer, TranslateTo.English }; }

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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(TranslateTo), TranslateTo);
            info.AddValue(nameof(Khmer), Khmer);
            info.AddValue(nameof(English), English);
        }
    }
}