using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Хранит данные о клиентах.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        public CustomerTab()
        {
            InitializeComponent();
            CustomersGroupBox.Enabled = false;
        }

        /// <summary>
        /// true если данные введены в поля правильно, иначе - false
        /// </summary>
        private bool _isDataCorrect = true;

        /// <summary>
        /// Хранит данные о текущем клиенте.
        /// </summary>
        private static Customer _currentCustomer = null;

        /// <summary>
        /// Вызывает и задаёт список товаров
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateListBox();
            }
        }

        /// <summary>
        /// Обновляет ListBox
        /// </summary>
        private void UpdateListBox()
        {
            CustomerListListBox.Items.Clear();
            CustomerListListBox.Items.AddRange(_customers.ToArray());
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomerListListBox.SelectedIndex < 0) { return; }
            else
            {
                _customers.RemoveAt(CustomerListListBox.SelectedIndex);
                CustomerListListBox.Items.RemoveAt(CustomerListListBox.SelectedIndex);
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer("Empty", new Address(100000, "Country", "City", "Street", "Building", "Apartment"));
            _customers.Add(newCustomer);
            CustomerListListBox.Items.Add(newCustomer);
            
        }
        /// <summary>
        /// Добавляет ФИО покупателя в элемент ListBox.
        /// </summary>
        private void ChangeTextElemListBoxInstitution()
        {
            CustomerListListBox.Items[CustomerListListBox.SelectedIndex] = _customers[CustomerListListBox.SelectedIndex].FullName;
        }

        private void CustomerSaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerListListBox.SelectedItem == null) { return; }

            _isDataCorrect = true;
            CustomerSaveButton.Enabled = true; 

            CustomerNameTextBox.BackColor = Color.White;

            if (CustomerNewAddressControl.TryWriteAdressData())
            {
                _currentCustomer.Address = CustomerNewAddressControl.Address;
                CustomerSaveButton.Enabled = true;
            }
            else
            {
                _isDataCorrect = false;
                CustomerSaveButton.Enabled = false;
            }


            try
            {
                string newFullName = CustomerNameTextBox.Text;
                _currentCustomer.FullName = newFullName;
                CustomerSaveButton.Enabled = true;
            }
            catch (Exception)
            {
                _isDataCorrect = false;
                CustomerSaveButton.Enabled = false;
                CustomerNameTextBox.BackColor = Color.LightPink;
            }
            ChangeTextElemListBoxInstitution();
        }


        private void CustomerListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CustomerListListBox.SelectedIndex < 0) 
            { 
                return; 
            }
            if (!_isDataCorrect)
            {
                CustomerListListBox.SelectedItem = _currentCustomer;
                return;
            }
            CustomersGroupBox.Enabled = true;
            _currentCustomer = _customers[CustomerListListBox.SelectedIndex];

            CustomerIdTextBox.Text = _currentCustomer.Id.ToString();
            CustomerNameTextBox.Text = _currentCustomer.FullName;
            CustomerNewAddressControl.Address = _currentCustomer.Address;

        }
    }
}
