using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Kafe.Controls
{
    public class BaseViewModul : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) =>{};

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
