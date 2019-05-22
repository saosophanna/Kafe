using Kafe.Controls;

namespace Kafe.CoreSystem
{
    public class MenuViewModul : BaseViewModul
    {
        public static MenuViewModul Instand { get => new MenuViewModul(); }

        public Languages Sales { get; set; }

        public Languages Product { get; set; }

        public Languages Setting { get; set; }

        public Languages About { get; set; }

        public Languages Logout { get; set; }

        public ProductInfoViewModul ProductInfo { get; set; }

        public MenuViewModul()
        {
            ProductInfo = new ProductInfoViewModul();

            ChangeLanguage();

            IoC.Get<LanguageViewModul>().LanguageChanged += (sender) =>
              {
                  ChangeLanguage();
              };
        }

        private void ChangeLanguage()
        {
            Sales = new Languages("លក់", "Sale");
            Product = new Languages("ផលិតផល", "Product");
            Setting = new Languages("កំណត់", "Setting");
            About = new Languages("អំពី", "About");
            Logout = new Languages("ចាកចេញ", "Log Out");

            OnPropertyChanged();
        }
    }
}