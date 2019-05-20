using Kafe.CoreSystem;
using System.Windows.Controls;

namespace Kafe
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
            DataContext = new MenuViewModul();
        }
    }
}
