using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TemplateSolution.Common
{
    public class Command<T> : ICommand
    {
        private Action<T> _action;
        private Func<bool> _canExecute;

        public Command(Action<T> action)
        {
            _action = action;
            _canExecute = () => true;
        }

        public Command(Action<T> action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            if (_action != null)
            {
                var castParameter = (T)Convert.ChangeType(parameter, typeof(T));
                _action(castParameter);
            }
        }
    }
}
