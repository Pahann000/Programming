using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrderTab : UserControl
    {
        public OrderTab()
        {
            InitializeComponent();
            UpdateOrders();
            OrdersInfoGroupBox.Enabled = false;
            OrderStatusComboBox.Enabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// 
        /// </summary>
        private List<OrdersFullData> _orderData = new List<OrdersFullData>();

        /// <summary>
        /// 
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateOrders();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateOrders()
        {
            OrderDataBindingSourse.Clear();
            OrdersDataGridView.DataSource = null;
            _orderData.Clear();
            
            foreach (var customer in _customers)
            {
                foreach (var order in customer.Order)
                {
                    OrdersFullData orderData = new OrdersFullData();
                    orderData.Id = order.Id.ToString();
                    orderData.Address = order.Address;
                    orderData.Status = order.Status.ToString();
                    orderData.Date = order.Date.ToString();
                    orderData.Amount = order.Amount.ToString();
                    orderData.FullName = customer.FullName;
                    orderData.Order = order;

                    _orderData.Add(orderData);
                    OrderDataBindingSourse.Add(orderData);
                }
            }
            OrdersDataGridView.DataSource = OrderDataBindingSourse;
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CartItemsListBox.Items.Clear();
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                OrderIdTextBox.Text = string.Empty;
                OrderTimeTextBox.Text = string.Empty;
                OrderStatusComboBox.Text = string.Empty;
                CustomerOrderAddressControl.Address = new Address(100000, "", "", "", "", "");
                AmountTextBox.Text = string.Empty;
            }
            else
            {
                OrdersFullData order = _orderData[OrdersDataGridView.SelectedCells[0].RowIndex];
                OrderIdTextBox.Text = order.Id;
                OrderTimeTextBox.Text = order.Date;
                OrderStatusComboBox.Text = order.Status;
                CustomerOrderAddressControl.Address = order.Address;
                for (int i = 0; i < order.Order.Items.Count; i++)
                {
                    CartItemsListBox.Items.Add(order.Order.Items[i].Name);
                }
                AmountTextBox.Text = order.Amount;
            }
        }
    }
}
