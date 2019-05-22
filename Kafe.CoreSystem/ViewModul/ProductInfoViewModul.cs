using Kafe.Controls;

namespace Kafe.CoreSystem
{
    public class ProductInfoViewModul : BaseViewModul
    {
        public static ProductInfoViewModul Instand { get => new ProductInfoViewModul(); }

        public ProductDesign Product { get; set; }

        public Languages LabelCode { get; set; }

        public Languages CommentCode { get; set; }

        public Languages LabelName { get; set; }

        public Languages CommentName { get; set; }

        public Languages LabelType { get; set; }

        public Languages CommentType { get; set; }

        public Languages LabelQuantity { get; set; }

        public Languages CommentQuantity { get; set; }

        public Languages LabelPrice { get; set; }

        public Languages CommentPrice { get; set; }

        public Languages LabelDiscount { get; set; }

        public Languages CommentDiscount { get; set; }

        public Languages LabelInfo { get; set; }

        public Languages CommentInfo { get; set; }

        public ProductInfoViewModul()
        {
            Product = new ProductDesign();
            LanguageChange();
            IoC.Get<LanguageViewModul>().LanguageChanged += (sender) => LanguageChange();
        }

        private void LanguageChange()
        {
            LabelCode = new Languages("កូដ", "Code");
            CommentCode = new Languages("បញ្ចូលលេខកូដ", "Enter code");
            LabelName = new Languages("ឈ្មោះផលិតផល", "Product name");
            CommentName = new Languages("ដាក់ឈ្មោះផលិតផល", "Enter product's name");
            LabelType = new Languages("ប្រភេទផលិតផល", "Product Type");
            CommentType = new Languages("បញ្ចូលប្រភេទរបស់ផលិតផល", "Enter product's type");
            LabelQuantity = new Languages("ចំនួន", "Quantity");
            CommentQuantity = new Languages("បញ្ចូលចំនួនរបស់ផលិតផល", "Enter product's quantity");
            LabelPrice = new Languages("តម្លៃ", "Price");
            CommentPrice = new Languages("បញ្ចូលតម្លៃ", "Enter product's price");
            LabelDiscount = new Languages("បញ្ចុះតម្លៃ(%)", "Discount(%)");
            CommentDiscount = new Languages("បញ្ចូលចំនូននៃការបញ្ចុះតម្លៃ", "Enter discount percent");
            LabelInfo = new Languages("ពត័មាន", "Description");
            CommentInfo = new Languages("បញ្ចូលពត័មាន", "Any Decription?");
        }
    }
}