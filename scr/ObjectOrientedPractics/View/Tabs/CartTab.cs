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
        /// Обновляет DiscountsCheckedListBox
        /// </summary>
        private void UpdateDiscountsCheckedListBox()
        {
            DiscountsCheckedListBox.Items.Clear();

            if (CurrentCustomer != null)
            {
                foreach (var discount in CurrentCustomer.Discounts)
                {
                    DiscountsCheckedListBox.Items.Add(discount.Info, true);
                }
            }
            UpdateTotalAmountLabel();
        }

        /// <summary>
        /// Обновляет CartListBox
        /// </summary>
        private void UpdateCartListBox()
        {
            CartItemsListBox.Items.Clear();
            foreach (var item in CurrentCustomer.Cart.Items)
            {
                CartItemsListBox.Items.Add(item.Name);
            }
            UpdateAmountLabel();
            UpdateTotalAmountLabel();
        }

        /// <summary>
        /// Обновляет AmountLabel
        /// </summary>
        private void UpdateAmountLabel()
        {
            AmountLabel.Text = CurrentCustomer?.Cart?.Amount.ToString("C") ?? "0.00";
        }

        /// <summary>
        /// Обновляет TotalAmountLabel
        /// </summary>
        private void UpdateTotalAmountLabel()
        {
            double discountAmount = CalculateDiscount();
            double totalAmount = CurrentCustomer.Cart.Amount - discountAmount;
            DiscountAmountLabel.Text = discountAmount.ToString("C");
            TotalAmountLabel.Text = totalAmount.ToString("C");
        }

        /// <summary>
        /// Высчитывает размер скидки
        /// </summary>
        /// <returns>Размер скидки</returns>
        private double CalculateDiscount()
        {
            double discountAmount = 0;
            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                discountAmount += CurrentCustomer.Discounts[index].Calculate(CurrentCustomer.Cart.Items);
            }

            return discountAmount;
        }
        private void CustomerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerNameComboBox.SelectedIndex != -1)
            {
                CurrentCustomer = Customers[CustomerNameComboBox.SelectedIndex];
                UpdateCartItemsListBox();
                UpdateDiscountsCheckedListBox();
                CheckAllItems();
            }
            else
            {
                CartItemsListBox.Items.Clear();
            }
        

        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameComboBox.SelectedIndex < 0) return;
            CurrentCustomer.Cart.Items.Clear();
            CartItemsListBox.Items.Clear();

            UpdateCartListBox();

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

            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameComboBox.SelectedIndex < 0) return;

            double discountAmount = 0;
            List<IDiscount> selectedDiscounts = new List<IDiscount>(); 

            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                var discount = CurrentCustomer.Discounts[index];
                discountAmount += discount.Apply(CurrentCustomer.Cart.Items);
                selectedDiscounts.Add(discount); 
            }

            if (CurrentCustomer.IsPriority)
            {
                PriorityOrder priorityOrder = new PriorityOrder(CurrentCustomer.Address, CurrentCustomer.Cart.Amount,
                (OrderStatus)Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray()[0], new List<Item>(CurrentCustomer.Cart.Items),
                DateTime.Now.Date.AddDays(3), "9:00-11:00");
                CurrentCustomer.Order.Add(priorityOrder);
            }
            else
            {
                Order currentOrder = new Order(CurrentCustomer.Address, CurrentCustomer.Cart.Amount,
                (OrderStatus)Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray()[0], new List<Item>(CurrentCustomer.Cart.Items));
                CurrentCustomer.Order.Add(currentOrder);
                
            }

            foreach (var discount in CurrentCustomer.Discounts)
            {
                discount.Update(CurrentCustomer.Cart.Items);
            }

            UpdateDiscountsCheckedListBox();

            CurrentCustomer.Cart.Items.Clear();
            CartItemsListBox.Items.Clear();

            UpdateCartListBox();

        }

        /// <summary>
        /// Обновление предметов в корзине.
        /// </summary>
        private void UpdateCartItemsListBox()
        {
            CartItemsListBox.Items.Clear();
            if (CurrentCustomer?.Cart?.Items != null)
            {
                foreach (var cartItem in CurrentCustomer.Cart.Items)
                {
                    CartItemsListBox.Items.Add(cartItem.Name);
                }
            }
        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalAmountLabel();
        }

        /// <summary>
        /// Обновляет сумму скидки и итоговую сумму заказа.
        /// </summary>
        private void UpdateDiscountAndTotalAmount()
        {
            int discountAmount = 0;
            DiscountAmountLabel.Text = "0";
            TotalAmountLabel.Text = "0";
            if (CurrentCustomer == null) return;
            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                discountAmount += (int)CurrentCustomer.Discounts[index].Calculate(CurrentCustomer.Cart.Items);
            }
            AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            DiscountAmountLabel.Text = discountAmount.ToString();
            TotalAmountLabel.Text = (CurrentCustomer.Cart.Amount - discountAmount).ToString();
        }

        /// <summary>
        /// Устанавливает флажки для всех элементов в списке скидок.
        /// </summary>
        private void CheckAllItems()
        {
            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                DiscountsCheckedListBox.SetItemChecked(i, true);
            }
        }

    }
}
