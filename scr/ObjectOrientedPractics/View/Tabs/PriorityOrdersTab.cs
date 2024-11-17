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
    public partial class PriorityOrdersTab : UserControl
    {
        public PriorityOrdersTab()
        {
            InitializeComponent();
        }

        private PriorityOrder _currentPriorityOrder = new PriorityOrder();

        private List<Item> _orderItems = new List<Item>();  

        private List<Item> _items = new List<Item>();


        public List<Item> Items
        {
            get { return _orderItems; }
            set { _orderItems = value; }
        }
        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            PriorityOrderComboBox.DataSource = PriorityOrder.OrderTimes;
            PrOrderStatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

        }

        private void PriorityOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrOrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PriorityOrderComboBox_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PriorityOrderComboBox.Text)) return;
            try
            {
                PriorityOrderComboBox.BackColor = AppColors.trueText;
                string currentOrderDate = PriorityOrderComboBox.SelectedItem.ToString();
                _currentPriorityOrder.OrderTime = currentOrderDate;

            }
            catch (Exception)
            {
                MessageBox.Show("Выберите правильное время");

            }
        }

        private void PrOrderStatusComboBox_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PrOrderStatusComboBox.Text)) return;
            try
            {
                PrOrderStatusComboBox.BackColor = AppColors.trueText;
                OrderStatus currentOrderStatus = (OrderStatus)(PrOrderStatusComboBox.SelectedIndex);
                _currentPriorityOrder.Status = currentOrderStatus;

            }
            catch (Exception)
            {
                MessageBox.Show("Выберите правильный статус");
            }
        }

        private void AddItemPrOrderButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(Items.Count);
            Item newItem = Items[index];
            PrOrderCartItemsListBox.Items.Add(newItem.Name);
            _currentPriorityOrder.Items.Add(newItem);

        }

        private void RemoveItemPrOrderButton_Click(object sender, EventArgs e)
        {
            if (PrOrderCartItemsListBox.SelectedIndex < 0) return;
            if (PrOrderCartItemsListBox.SelectedIndex + 1 != PrOrderCartItemsListBox.Items.Count)
            {
                PrOrderCartItemsListBox.SelectedIndex += 1;
                PrOrderCartItemsListBox.Items.RemoveAt(PrOrderCartItemsListBox.SelectedIndex - 1);
            }
            else
            {
                PrOrderCartItemsListBox.SelectedIndex -= 1;
                PrOrderCartItemsListBox.Items.RemoveAt(PrOrderCartItemsListBox.SelectedIndex + 1);
            }
            


        }

        private void ClearOrderPrOrderButton_Click(object sender, EventArgs e)
        {
            _currentPriorityOrder = null;

            _currentPriorityOrder = new PriorityOrder();

            UpdateOrderItems();
            
        }

        public void UpdateOrderItems()
        {
            PrOrderCartItemsListBox.Items.Clear();
        }

       

    }
}
