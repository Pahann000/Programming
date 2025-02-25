using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Класс для сериализации и десериализации контактов в формате JSON.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Хранит путь до необходимого дериктория с файлом. Доступен только на чтение.
        /// </summary>
        private readonly string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "Contact", "contacts.json");

        /// <summary>
        /// Конструктор класса. Проверяет существование директории для хранения контактов и создает ее, если она не существует.
        /// </summary>
        public ContactSerializer()
        {
            if (!Directory.Exists(Path.GetDirectoryName(_path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_path));
            }
        }

        /// <summary>
        /// Сохраняет контакт в JSON файл.
        /// </summary>
        /// <param name="contact">Контакт, который нужно сохранить.</param>
        public void SaveContact(Contact contact)
        {
            string contactInString = JsonConvert.SerializeObject(contact);
            File.WriteAllText(_path, contactInString);
        }

        /// <summary>
        /// Загружает контакт из JSON файла.
        /// </summary>
        /// <returns>Десериализованный объект контакта. Если файл не существует, возвращает новый экземпляр контакта.</returns>
        public Contact LoadContact()
        {
            if (File.Exists(_path))
            {
                string contactInString = File.ReadAllText(_path);
                return JsonConvert.DeserializeObject<Contact>(contactInString);
            }

            return new Contact();
        }
    }
}