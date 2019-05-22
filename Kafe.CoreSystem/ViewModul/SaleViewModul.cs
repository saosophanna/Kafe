using Kafe.Controls;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Kafe.CoreSystem
{
    public class SaleViewModul : ValidateField
    {
        public static SaleViewModul Instand { get => new SaleViewModul(); }

        private bool isShowPayment=false;

        public bool IsShowPayment
        {
            get { return isShowPayment; }
            set { isShowPayment = value; OnPropertyChanged(); }
        }

        private double cashIn;

        public double CashIn
        {
            get { return cashIn; }
            set { cashIn = value; ValidateModul(this, cashIn); }
        }

        public double Return { get
            {
                try
                {
                    return CashIn - TotalPrice;
                }
                finally
                {
                    OnErrorChanage();
                }
            }
        }

        public ObservableCollection<ProductDesign> Product { get; set; }

        public ObservableCollection<OrderDetail> OrderDetails { get; set; }

        public double TotalPrice { get => OrderDetails.Sum(p => p.Price); }

        public ICommand SelectCommand { get; set; }

        public ICommand GotoPayCommand { get; set; }

        public ICommand BacktoPayCommand { get; set; }

        public ICommand PaymentCommand { get; set; }

        public SaleViewModul()
        {
            SelectCommand = new PCommand(para => SelectItem(para));

            GotoPayCommand = new RelayCommand(GotoPayment);

            BacktoPayCommand = new RelayCommand(BacktoPayment);

            PaymentCommand = new RelayCommand(Payment);

            Product = new ObservableCollection<ProductDesign>();

            OrderDetails = new ObservableCollection<OrderDetail>();

            for (int i = 0; i < 6; i++)
            {
                Product.Add(new ProductDesign());
            }
        }

        private void Payment()
        {
            throw new NotImplementedException();
        }

        private void BacktoPayment()
        {
            CashIn = 0;
            IsShowPayment = false;
        }

        private void GotoPayment()
        {
            IsShowPayment = true;
        }

        private void SelectItem(object para)
        {
            var product = para as ProductDesign;

            product.IsSelected ^= true;

            try
            {
                if (product.IsSelected == false)
                {
                    OrderDetails.Remove(OrderDetails.ToList().Find(o => o.ProductID == product.Code));
                    return;
                }

                OrderDetails.Add(new OrderDetail()
                {
                    ProductID = product.Code,
                    ProductName = product.Name,
                    Unite = product.Quantity,
                    Price = product.DisPrice
                });
            }
            finally
            {
                OnPropertyChanged(nameof(TotalPrice));
            }
            
        }
    }
}