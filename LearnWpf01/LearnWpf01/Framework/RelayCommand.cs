using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearnWpf01.Framework
{
    class RelayCommand : ICommand
    {
        Func<bool> _canExecute;
        Action<object> _execute;

        public RelayCommand(string name, Func<bool> canExecute, Action<object> execute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
             return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
