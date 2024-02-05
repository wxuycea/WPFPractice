using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMPractice {
    public class RelayCommand(Action execute, Func<bool>? canExecute = null) : ICommand {
        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter) {
            return canExecute == null || canExecute();
        }

        public void Execute(object? parameter) {
            execute();
        }
    }
}
