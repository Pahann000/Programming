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
        private static List<Customer> _customers = new List<Customer>();
        public CustomerTab()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Хранит данные о текущем клиенте.
        /// </summary>
        private static Customer _currentCustomer = null;
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
            Customer newCustomer = new Customer("Empty", "Nothing");
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
            _currentCustomer.FullName = CustomerNameTextBox.Text;
            _currentCustomer.Address = CustomerAddressRichTextBox.Text;
            ChangeTextElemListBoxInstitution();
        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerNameTextBox.Text)) return;
            try
            {
                CustomerNameTextBox.BackColor = AppColors.trueText;
                string customerFullName = CustomerNameTextBox.Text;
                _currentCustomer.FullName = customerFullName;
            }
            catch (Exception)
            {
                CustomerNameTextBox.BackColor = AppColors.falseText;
            }
        }

        private void CustomerAddressRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerAddressRichTextBox.Text)) return;
            try
            {
                CustomerAddressRichTextBox.BackColor = AppColors.trueText;
                string customerAdress = CustomerAddressRichTextBox.Text;
                _currentCustomer.Address = customerAdress;
            }
            catch (Exception)
            {
                CustomerAddressRichTextBox.BackColor = AppColors.falseText;
            }
        }

        private void CustomerListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CustomerListListBox.SelectedIndex == -1 )
            {
                CustomerNameTextBox.Text = string.Empty;
                CustomerAddressRichTextBox.Text = string.Empty;
                CustomerIdTextBox.Text = string.Empty;
            }

            else
            {
                _currentCustomer = _customers[CustomerListListBox.SelectedIndex];
                CustomerNameTextBox.Text = _currentCustomer.FullName.ToString();
                CustomerAddressRichTextBox.Text = _currentCustomer.Address.ToString();
                CustomerIdTextBox.Text = _currentCustomer.Id.ToString();
            }
        }
    }
}
