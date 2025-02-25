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
        /// <summary>
        /// Событие, вызывающееся при изменении условий влияющих на возможность выполнения
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Передает данные из класса ContactSerializer
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Передает данные из класса MainVM
        /// </summary>
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
            return true; 
        }

        /// <summary>
        /// Метод, который выполняется при вызове команды.
        /// Сохраняет текущий контакт в файл с помощью сериализатора.
        /// </summary>
        /// <param name="parameter">Дополнительный параметр (не используется).</param>
        public void Execute(object? parameter)
        {
            _serializer.SaveContact(_mainVM.Contact);
        }
    }
}