using Kafe.CoreSystem;
using System.Windows.Controls;

namespace Kafe
{
    /// <summary>
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : UserControl
    {
        public Sales()
        {
            InitializeComponent();
            DataContext = new SaleViewModul();
        }
    }
}