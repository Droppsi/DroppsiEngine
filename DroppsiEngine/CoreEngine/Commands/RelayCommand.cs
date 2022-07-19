using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DroppsiEngine.Engine.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = (x) => { execute(); };
            _canExecute = (x) => { return true; };
        }

        public RelayCommand(Action<object> execute)
        {
            _execute = execute;
            _canExecute = (x) => { return true; } ;
        }

        public RelayCommand(Action execute)
        {
            _execute = (x) => { execute(); };
            _canExecute = (x) => { return true; };
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
