using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ContactCollection.ViewModel
{
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат, представляющий метод для выполнения.
        /// </summary>
        private Action<object> _execute;

        /// <summary>
        /// Делегат, представляющий метод для проверки 
        /// возможности выполнения команды.
        /// </summary>
        private Predicate<object> _canExecute;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Делегат, представляющий метод для выполнения.</param>
        /// <param name="canExecute">Делегат, представляющий метод для проверки
        /// возможности выполнения команды (необязательный).</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если <paramref name="execute"/> 
        /// равен null.</exception>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        /// Определяет, может ли команда выполняться в текущем состоянии.
        /// </summary>
        /// <param name="parameter">Данные, используемые командой.
        /// Этот параметр можно использовать для передачи
        /// информации в метод <see cref="_canExecute"/>.</param>
        /// <returns>true, если команда может быть выполнена, 
        /// иначе false.</returns>
        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="parameter">Данные, используемые командой.</param>
        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        /// <summary>
        /// Событие, возникающее при изменении
        /// возможности выполнения команды.
        /// </summary>/// <summary>
        /// Событие, возникающее при изменении
        /// возможности выполнения команды.
        /// </summary>
        private event EventHandler _canExecuteChanged;

        /// <summary>
        /// Событие, возникающее при изменении
        /// возможности выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                _canExecuteChanged += value; CommandManager.RequerySuggested += value;
            }
            remove
            {
                _canExecuteChanged -= value; CommandManager.RequerySuggested -= value;
            }
        }

        ///<inheritdoc/>
        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}