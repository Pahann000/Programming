using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контакт с именем, электронной почтой и номером телефона.
    /// </summary>
    public class Contact
    {
        
        /// <summary>
        /// Свойство для получения или установки имени контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Свойство для получения или установки электронной почты контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Свойство для получения или установки номера телефона контакта.
        /// </summary>
        public string Phone { get; set; } 

        /// <summary>
        /// Конструктор для создания объекта Contact с указанными именем, электронной почтой и номером телефона.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="email">Электронная почта контакта.</param>
        /// <param name="phone">Номер телефона контакта.</param>
        public Contact(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        /// <summary>
        /// Конструктор по умолчанию для создания пустого объекта Contact.
        /// </summary>
        public Contact()
        {
            
        }
    }
}