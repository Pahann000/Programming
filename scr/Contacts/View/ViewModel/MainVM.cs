using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна приложения, реализующая интерфейс INotifyPropertyChanged,
    /// чтобы уведомлять интерфейс пользователя об изменениях в данных.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие, которое вызывается при изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Команда для загрузки контакта.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Команда для сохранения контакта.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Метод для вызова события PropertyChanged. Вызывается, 
        /// когда значение свойства изменяется.
        /// </summary>
        /// <param name="propertyName">Имя свойства, которое изменилось.</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Contact _contact;

        private ContactSerializer _contactSerializer;

        /// <summary>
        /// Свойство для получения или установки текущего контакта.
        /// При установке вызывается событие PropertyChanged.
        /// </summary>
        public Contact Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Email));
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Свойство для получения или установки имени контакта.
        /// При установке вызывается событие PropertyChanged.
        /// </summary>
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name)); 
            }
        }

        /// <summary>
        /// Свойство для получения или установки электронной почты контакта.
        /// При установке вызывается событие PropertyChanged.
        /// </summary>
        public string Email
        {
            get { return _contact.Email; }
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email)); 
            }
        }

        /// <summary>
        /// Свойство для получения или установки номера телефона контакта.
        /// При установке вызывается событие PropertyChanged.
        /// </summary>
        public string Phone
        {
            get { return _contact.Phone; }
            set
            {
                _contact.Phone = value;
                OnPropertyChanged(nameof(Phone)); 
            }
        }

        /// <summary>
        /// Конструктор по умолчанию для MainVM.
        /// Инициализирует сериализатор контактов, загружает контакт,
        /// и создает команды для сохранения и загрузки контакта.
        /// </summary>
        public MainVM()
        {
            _contactSerializer = new ContactSerializer(); 
            Contact = _contactSerializer.LoadContact(); 
            SaveCommand = new SaveCommand(_contactSerializer, this); 
            LoadCommand = new LoadCommand(_contactSerializer, this); 
        }
    }
}