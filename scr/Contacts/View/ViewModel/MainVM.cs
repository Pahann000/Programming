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
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand LoadCommand
        {
            get;
        }

        public ICommand SaveCommand
        {
            get;
        }

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Contact _contact;

        private ContactSerializer _contactSerializer;
        public Contact Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        public string Name
        {
            get { return _contact.Name; }
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Email
        {
            get { return _contact.Email; }
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
                
            }
        }

        public string Phone
        {
            get { return _contact.Phone; }
            set
            {
                _contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public MainVM()
        {
            _contactSerializer = new ContactSerializer();
            Contact = _contactSerializer.LoadContact();
            SaveCommand = new SaveCommand(_contactSerializer, this);
            LoadCommand = new LoadCommand(_contactSerializer, this);
        }

    }
}
