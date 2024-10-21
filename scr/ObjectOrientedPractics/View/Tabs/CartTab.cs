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
    public partial class CartTab : UserControl
    {
        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Хранит список покупателей.
        /// </summary>
        private List<Customer> _customer = new List<Customer>();

        public CartTab()
        {
            InitializeComponent();

            if (ItemsListBox.SelectedIndex > 0) UpdateListBox();
            if (CustomerNameComboBox.SelectedIndex > 0) UpdateComboBox();
        }


        /// <summary>
        /// Задает и возращает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customer; }
            set
            {
                _customer = value;
    
            }
        }

        /// <summary>
        /// Задает и возращает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Задает и возращает текущего покупателя.
        /// </summary>
        private Customer CurrentCustomer { get; set; }


        /// <summary>
        /// Заполнение ListBox
        /// </summary>
        private void UpdateListBox()
        {
            
            ItemsListBox.Items.Clear();
            for (int i = 0; i < Items.Count; i++)
            {
                ItemsListBox.Items.Add(Items[i].Id.ToString() + ". " + Items[i].Name.ToString());
            }
        }

        /// <summary>
        /// Обновление данных во вкладке.
        /// </summary>
        public void RefreshData()
        {
            UpdateListBox();
            UpdateComboBox();
        }

        /// <summary>
        /// Перезапись имени покупателя при его изменении.
        /// </summary>
        private void UpdateComboBox()
        {
            CustomerNameComboBox.Items.Clear();
            for (int i = 0; i < Customers.Count; i++)
            {
                CustomerNameComboBox.Items.Add(Customers[i].FullName);
            }
        }

        /// <summary>
        /// Изменение стоимости товаров при изменении изначальной стоимости товаров.
        /// </summary>
        private void ChangeCart()
        {
            AmountTextBox.Text = $"{CurrentCustomer.Cart.Amount:n2}";
        }

        private void CustomerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartItemsListBox.Items.Clear();
            int selectedIndex = CustomerNameComboBox.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < Customers.Count)
            {
                CurrentCustomer = Customers[selectedIndex];
                if (CurrentCustomer != null && CurrentCustomer.Cart != null && CurrentCustomer.Cart.Items != null)
                {
                    foreach (var item in CurrentCustomer.Cart.Items)
                    {
                        if (item != null && item.Name != null)
                        {
                            CartItemsListBox.Items.Add(item.Name);
                        }
                    }
                    ChangeCart();
                }
            }

        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameComboBox.SelectedIndex < 0) return;
            CurrentCustomer.Cart.Items.Clear();
            CartItemsListBox.Items.Clear();

            ChangeCart();
        }

        private void AddItemToCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameComboBox.SelectedIndex > -1)
            {
                CurrentCustomer = _customer[CustomerNameComboBox.SelectedIndex];

                if (CurrentCustomer != null || ItemsListBox.SelectedIndex > 0 || ItemsListBox.SelectedItem == null)
                {
                    int selectedIndex = ItemsListBox.SelectedIndex;
                    var newItem = _items[selectedIndex];

                    if (newItem != null && !string.IsNullOrEmpty(newItem.Name))
                    {
                        CurrentCustomer.Cart.Items.Add(newItem);
                        CartItemsListBox.Items.Add(newItem.Name);
                        ChangeCart();
                    }
                }
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartItemsListBox.SelectedIndex > 0)
            {
                CurrentCustomer.Cart.Items.RemoveAt(CartItemsListBox.SelectedIndex);
                CartItemsListBox.Items.RemoveAt(CartItemsListBox.SelectedIndex);

                ChangeCart();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameComboBox.SelectedIndex < 0) return;
            Order currentOrder = new Order();
            currentOrder.Items = new List<Item>(CurrentCustomer.Cart.Items);
            currentOrder.Amount = CurrentCustomer.Cart.Amount;
            currentOrder.Status = (OrderStatus)Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray()[0];
            currentOrder.Address = CurrentCustomer.Address;
            CurrentCustomer.Order.Add(currentOrder);
            CurrentCustomer.Cart.Items.Clear();
            CartItemsListBox.Items.Clear();

            ChangeCart();
        }
    }
}
