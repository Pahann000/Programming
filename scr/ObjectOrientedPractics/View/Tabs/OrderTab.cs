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

            OrderStatusComboBox.Enabled = true;
            OrderTimeComboBox.Enabled = true;

            _orderData.Columns.Add("Id", typeof(string));
            _orderData.Columns.Add("Date", typeof(string));
            _orderData.Columns.Add("FullName", typeof(string));
            _orderData.Columns.Add("Address", typeof(string));
            _orderData.Columns.Add("Amount", typeof(string));
            _orderData.Columns.Add("Status", typeof(string));

        }
        /// <summary>
        /// Хранит список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        private DataTable _orderData = new DataTable();

        /// <summary>
        /// Текущий заказ
        /// </summary>
        private static int _currentIndex = -1;


        private static List<Order> _orders = new List<Order>();


        /// <summary>
        /// Выбранный заказ
        /// </summary>
        private Order _selectedOrder = new Order();

        /// <summary>
        /// Выбранный приоритетный заказ
        /// </summary>
        private PriorityOrder _selectedPriorityOrder = null;

        /// <summary>
        /// Задает и возращает список покупателей.
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
        /// Обновляет данные во вкладке.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }



        /// <summary>
        /// Перезаписывает данные о заказе при их изменении в других вкладках
        /// </summary>
        private void UpdateOrders()
        {
            OrdersDataGridView.DataSource = null;
            _orderData.Clear();

            foreach (var customer in _customers)
            {
                foreach (var order in customer.Order)
                {
                    DataRow row = _orderData.NewRow();
                    row["Id"] = order.Id;
                    row["Date"] = order.Date.ToString();
                    row["FullName"] = customer.FullName;
                    row["Address"] = order.Address.ToString();
                    row["Amount"] = $"{order.Amount:n2}";
                    row["Status"] = order.Status.ToString();

                    _orderData.Rows.Add(row);

                    _orders.Add(order);
                }
            }
            OrdersDataGridView.DataSource = _orderData;
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
                _currentIndex = OrdersDataGridView.SelectedCells[0].RowIndex;
                OrderIdTextBox.Text = _orders[_currentIndex].Id.ToString();
                OrderTimeTextBox.Text = _orders[_currentIndex].Date.ToString();
                OrderStatusComboBox.Text = _orders[_currentIndex].Status.ToString();
                CustomerOrderAddressControl.Address = _orders[_currentIndex].Address;
                for (int i = 0; i < _orders[_currentIndex].Items.Count; i++)
                {
                    CartItemsListBox.Items.Add(_orders[_currentIndex].Items[i].Name);
                }
                AmountTextBox.Text = _orders[_currentIndex].Amount.ToString();

                _selectedOrder = _orders[_currentIndex];

                if (_selectedOrder is PriorityOrder priority)
                {
                    _selectedPriorityOrder = priority;
                    PriorityPanel.Visible = true;
                    OrderTimeComboBox.Text = _selectedPriorityOrder.OrderTime;

                }
                else
                {
                    _selectedPriorityOrder = null;
                    PriorityPanel.Visible = false;
                }
            }
        }

        private void OrderTab_Load(object sender, EventArgs e)
        {
            OrderStatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            OrderTimeComboBox.DataSource = PriorityOrder.OrderTimes;
        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OrderStatusComboBox.Text)) return;
            OrderStatus currentStatus = (OrderStatus)OrderStatusComboBox.SelectedIndex;
            _selectedOrder.Status = currentStatus;

        }

        private void OrderTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder == null || string.IsNullOrEmpty(OrderTimeComboBox.Text)) return;
            string currentDateTime = OrderStatusComboBox.SelectedItem.ToString();
            _selectedPriorityOrder.OrderTime = currentDateTime;
        }
    }
}
