using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для сохранения контакта в файл с помощью сериализатора.
    /// Реализует интерфейс ICommand.
    /// </summary>
    public class SaveCommand : ICommand
    {
        // Событие, которое возникает при изменении состояния команды.
        public event EventHandler? CanExecuteChanged;

        // Приватное поле для сериализатора контактов.
        private ContactSerializer _serializer;

        // Приватное поле для главного ViewModel.
        private MainVM _mainVM;

        /// <summary>
        /// Конструктор для инициализации команды сохранения.
        /// </summary>
        /// <param name="serializer">Сериализатор контактов, используемый для сохранения данных.</param>
        /// <param name="mainVM">Главный ViewModel, который содержит контакт для сохранения.</param>
        public SaveCommand(ContactSerializer serializer, MainVM mainVM)
        {
            _serializer = serializer; 
            _mainVM = mainVM; 
        }

        /// <summary>
        /// Метод для проверки возможности выполнения команды. Всегда возвращает true.
        /// </summary>
        /// <param name="parameter">Дополнительный параметр (не используется).</param>
        /// <returns>Всегда возвращает true, указывая, что команда может быть выполнена.</returns>
        public bool CanExecute(object? parameter)
        {
            return true; // Команда всегда доступна для выполнения.
        }

        /// <summary>
        /// Метод, который выполняется при вызове команды.
        /// Сохраняет текущий контакт в файл с помощью сериализатора.
        /// </summary>
        /// <param name="parameter">Дополнительный параметр (не используется).</param>
        public void Execute(object? parameter)
        {
            // Сохраняет контакт с помощью сериализатора.
            _serializer.SaveContact(_mainVM.Contact);
        }
    }
}