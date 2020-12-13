using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;

namespace OrkApplication.BaseApplicationClasses
{
    public class CommandClass : ICommand
    {
        Action _Action;

        public CommandClass(Action action)
        {
            _Action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _Action?.Invoke();
        }
    }
}
