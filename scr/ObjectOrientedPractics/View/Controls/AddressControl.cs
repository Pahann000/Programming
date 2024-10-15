using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class CustomerAddressControl : UserControl
    {

        /// <summary>
        /// Адрес покупателя
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает и задаёт адрес покупателя
        /// </summary>
        public Address Address
        {
            get 
            {
                TryWriteAdressData();
                return _address; 
            }
            set
            {
                _address = value;
                LoadAddress();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public CustomerAddressControl()
        {
            InitializeComponent();
            LoadAddress();
        }

        /// <summary>
        /// Вводит адрес в TextBox
        /// </summary>
        private void LoadAddress()
        {
            if (this.Address != null)
            {
                CustomerPostIndexTextBox.Text = _address.Index.ToString();
                CustomerCountryTextBox.Text = _address.Country;
                CustomerCityTextBox.Text = _address.City;
                CustomerStreetTextBox.Text = _address.Street;
                CustomerBuildingTextBox.Text = _address.Building;
                CustomerApartmentTextBox.Text = _address.Apartment;


            }
            else
            {
                CustomerPostIndexTextBox.Text = "100000";
                CustomerCountryTextBox.Text = " ";
                CustomerCityTextBox.Text = " ";
                CustomerStreetTextBox.Text = " ";
                CustomerBuildingTextBox.Text = " ";
                CustomerApartmentTextBox.Text = " ";
            }
        }

        /// <summary>
        /// Проверка данных адреса покупателя.
        /// </summary>
        /// <returns></returns>
        public bool TryWriteAdressData()
        {
            CustomerPostIndexTextBox.BackColor = AppColors.trueText;
            CustomerApartmentTextBox.BackColor = AppColors.trueText;
            CustomerBuildingTextBox.BackColor = AppColors.trueText;
            CustomerStreetTextBox.BackColor = AppColors.trueText;
            CustomerCountryTextBox.BackColor = AppColors.trueText;
            CustomerCityTextBox.BackColor = AppColors.trueText;

            bool IsDataCorrect = true;

            try
            {
                int newPostIndex = int.Parse(CustomerPostIndexTextBox.Text);
                _address.Index = newPostIndex;
            }
            catch
            {
                IsDataCorrect = false;
                CustomerPostIndexTextBox.BackColor = AppColors.falseText;
            }

            try
            {
                _address.Apartment = CustomerApartmentTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                CustomerApartmentTextBox.BackColor = AppColors.falseText;
            }

            try
            {
                _address.Building = CustomerBuildingTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                CustomerBuildingTextBox.BackColor = AppColors.falseText;
            }

            try
            {
                _address.Street = CustomerStreetTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                CustomerStreetTextBox.BackColor = AppColors.falseText;
            }

            try
            {
                _address.Country = CustomerCountryTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                CustomerCountryTextBox.BackColor = AppColors.falseText;
            }

            try
            {
                _address.City = CustomerCityTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                CustomerCityTextBox.BackColor = AppColors.falseText;
            }

            return IsDataCorrect;
        }



    }
}
