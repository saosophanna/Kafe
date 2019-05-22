using Kafe.Controls;

namespace Kafe.CoreSystem
{
    public class OrderDetail : BaseViewModul
    {
        #region Public property and private field

        private string productID;

        public string ProductID
        {
            get { return productID; }
            set { productID = value; OnPropertyChanged(); }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; OnPropertyChanged(); }
        }

        private int unite;

        public int Unite
        {
            get { return unite; }
            set { unite = value; OnPropertyChanged(); }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        #endregion Public property and private field

        #region Constructor

        public OrderDetail()
        {
            ProductName = "Espresso";
            Unite = 1;
            Price = 2.5d;
        }

        #endregion Constructor
    }
}