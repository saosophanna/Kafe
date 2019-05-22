using Kafe.Controls;
using System;
using System.Windows.Input;

namespace Kafe.CoreSystem
{
    public class ProductDesign : Products
    {
        public new static ProductDesign Instand { get => new ProductDesign(); }

        public event Action<ProductDesign, bool> SelectChange = (sender, value) => { };

        #region Public Property and Priavate Field

        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                SelectChange(this, isSelected);
                OnPropertyChanged();
            }
        }

        public ICommand SelectCommand { get; set; }

        #endregion Public Property and Priavate Field

        #region Label

        public Languages LabelCode { get; set; }

        public Languages LabelType { get; set; }

        public Languages LabelDiscription { get; set; }

        #endregion Label

        #region Constructor

        public ProductDesign() : base()
        {
            SelectCommand = new RelayCommand(() => IsSelected ^= true);

            ChangLanguage();

            IoC.Get<LanguageViewModul>().LanguageChanged += (sender) => ChangLanguage();
        }

        #endregion Constructor

        #region Event

        private void ChangLanguage()
        {
            LabelCode = new Languages("កូដ", "Code");
            LabelType = new Languages("ប្រភេទ", "Type");
            LabelDiscription = new Languages("ពត័មាន", "Info");
        }

        #endregion Event
    }
}