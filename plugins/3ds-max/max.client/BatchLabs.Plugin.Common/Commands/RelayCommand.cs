
using System;
using System.Diagnostics;
using System.Windows.Input;

namespace BatchLabs.Plugin.Common.Commands
{
    /// <summary>
    /// Implemenation of the MVVM toolkit DelegateCommand
    /// </summary>
    public class RelayCommand : ICommand
    {
        readonly Predicate<object> _canExecute;
        readonly Action<object> _execute;

        public RelayCommand(Action<object> execute)
            : this(execute, null)
        { }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            _execute = execute;
            _canExecute = canExecute;
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
