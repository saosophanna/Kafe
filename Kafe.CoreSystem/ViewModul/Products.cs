using Kafe.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Kafe.CoreSystem
{
    public class Products:ValidateField 
    {
        public static Products Instand { get => new Products(); }

        #region Public Property And Private  Field
        private string code;
        
        [Required(AllowEmptyStrings =false,ErrorMessage ="Code could't be Empty")]
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                ValidateModul(this, code);
            }
        }

        private string name;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Code could't be empty")]
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                ValidateModul(this, name);
            }
        }

        private string type;
        [Required(AllowEmptyStrings =false,ErrorMessage ="Type cound't be empty")]
        public string Type
        {
            get { return type; }
            set { type = value; ValidateModul(this, type); }
        }

        private int quantity;

        [Required(AllowEmptyStrings =false,ErrorMessage ="Quantity not null allow")]
        [NumberOnly(typeof(int),ErrorMessage ="Quantity can be only number")]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; ValidateModul(this, quantity); }
        }

        private float price;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Price not null allow")]
        [NumberOnly(typeof(float), ErrorMessage = "Price can be only number")]
        public float Price
        {
            get { return price; }
            set { price = value; ValidateModul(this, price); }
        }

        private float disPercent;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Discount not null allow")]
        [NumberOnly(typeof(float),maxNumber:100, ErrorMessage = "Discount can be only number")]
        public float DisPercent
        {
            get { return disPercent; }
            set
            {
                disPercent = value;
                ValidateModul(this, disPercent);
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; ValidateModul(this, value); }
        }

        public float DisPrice { get=>(float)Math.Round(Price-(Price*DisPercent/100),2); set=>OnPropertyChanged(); }

        private bool isShow;

        public bool IsShow
        {
            get { return isShow; }
            set { isShow = value;OnPropertyChanged(); }
        }

        public bool IsDiscount { get => DisPercent == 0; }

        #endregion
        
        #region Label
        public Languages LabelCode { get; set; }

        public Languages LabelType { get; set; }

        public Languages LabelDiscription { get; set; }
        #endregion

        #region Constructor

        public Products(string code, string name, string type, int quantity, float price, float disPercent, string description):this()
        {
            Code = code;
            Name = name;
            Type = type;
            Quantity = quantity;
            Price = price;
            DisPercent = disPercent;
            Description = description;
        }

        public Products()
        {
            Code = "P001";
            Name = "Epresso";
            Type = "Drink";
            Quantity = 10;
            Price = 2.5f;
            DisPercent = 10;
            Description = "The most popular in the week";
            IsShow = true;
            ChangLanguage();

            IoC.Get<LanguageViewModul>().LanguageChanged += (sender) => ChangLanguage();

            OnPropertyChanged();
        }

        #endregion

        #region Event
        private void ChangLanguage()
        {
            LabelCode = new Languages("កូដ", "Code");
            LabelType = new Languages("ប្រភេទ", "Type");
            LabelDiscription = new Languages("ពត័មាន", "Description");
        }
        #endregion
    }
}
