using Kafe.CoreSystem;
using System.Windows;

namespace Kafe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IoC.CallSetUp();
        }
    }
}