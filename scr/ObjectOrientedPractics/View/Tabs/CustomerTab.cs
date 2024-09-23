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
        /// 
        /// </summary>
        private static List<Customer> _customers = new List<Customer>();
        public CustomerTab()
        {
            InitializeComponent();
        }

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
            Customer newCustomer = new Customer();
            newCustomer.FullName = "Empty string";
            newCustomer.Address = "Unfinded";
            _customers.Add(newCustomer);
            CustomerListListBox.Items.Add(newCustomer);
        }

        private void CustomerSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerAddressRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
