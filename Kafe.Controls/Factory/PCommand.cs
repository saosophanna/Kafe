using System;
using System.Windows.Input;

namespace Kafe.Controls
{
    public class PCommand : ICommand
    {
        private Action<object> delegateCommand;

        public PCommand(Action<object> action) => delegateCommand = action;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => delegateCommand?.Invoke(parameter);
    }
}