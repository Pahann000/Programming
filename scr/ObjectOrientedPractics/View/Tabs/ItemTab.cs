using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemTab : UserControl
    {
        /// <summary>
        /// Хранит данные о созданных товарах
        /// </summary>
        private static List<Item> _items = new List<Item>();
        public ItemTab()
        {
            InitializeComponent();
            ItemsGroupBox.Enabled = false;
            if (_items.Count < 0) UpdateListBox();
            SortComboBox.Items.AddRange(["Name", "Cost (Ascending)", "Cost (Descending)"]);
            SortComboBox.SelectedIndex = 0;

        }

        /// <summary>
        /// Флаг фильтрации
        /// </summary>
        private bool _isRefreshed = false;

        /// <summary>
        /// Отсортировванные товары
        /// </summary>
        private List<Item> sortedItems;

        /// <summary>
        /// Хранит данные о текущем товаре
        /// </summary>
        private static Item _currentItem = null;

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                if (value != null)
                {

                    _items = value;
                    Refresh();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Refresh()
        {
            if (Items == null) return;
            if (_isRefreshed)
            {
                _isRefreshed = false;
                return;
            }
            var filteredItems = DataTools.Filter(Items, (item) => item.Name.Contains(FindTextBox.Text, StringComparison.OrdinalIgnoreCase));
            switch (SortComboBox.SelectedIndex)
            {
                case 1:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => item1.Price > item2.Price);
                    break;
                case 2:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => item1.Price < item2.Price);
                    break;
                default:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => string.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase) > 0);
                    break;
            }
            ItemListListBox.Items.Clear();

            for (int i = 0; i < sortedItems.Count; i++)
            {
                ItemListListBox.Items.Add(sortedItems[i].Name);
            }
            _isRefreshed = true;
        }
        private void ItemTab_Load(object sender, EventArgs e)
        {
            ItemCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));

        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (ItemListListBox.SelectedItem == null) return;
            _items.RemoveAt(ItemListListBox.SelectedIndex);
            ItemListListBox.Items.RemoveAt(ItemListListBox.SelectedIndex);
            _isRefreshed = false;
            Refresh();



        }

        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item("Name", "Info", 0, Category.Сhildish);
            newItem.Name = $"Item # {newItem.Id}";
            _items.Add(newItem);
            ItemListListBox.Items.Add(newItem.Id + ". " + newItem.Name.ToString());
            ItemListListBox.Enabled = true;
            _isRefreshed = false;
            Refresh();
        }

        private void ItemListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemListListBox.SelectedIndex < 0 || ItemListListBox.SelectedItem == null)
            {
                ItemPriceTextBox.Text = string.Empty;
                ItemInfoRichTextBox.Text = string.Empty;
                ItemNameRichTextBox.Text = string.Empty;
                ItemIdTextBox.Text = string.Empty;
                ItemCategoryComboBox.SelectedIndex = -1;
                ItemsGroupBox.Enabled = false;
            }

            else
            {
                ItemsGroupBox.Enabled = true;
                _currentItem = _items[_items.IndexOf(sortedItems[ItemListListBox.SelectedIndex])];
                ItemPriceTextBox.Text = _currentItem.Price.ToString();
                ItemInfoRichTextBox.Text = _currentItem.Info.ToString();
                ItemNameRichTextBox.Text = _currentItem.Name.ToString();
                ItemIdTextBox.Text = _currentItem.Id.ToString();
                ItemCategoryComboBox.Text = _currentItem.Category.ToString();



            }
        }

        private void ItemPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ItemPriceTextBox.Text)) return;
            try
            {
                ItemPriceTextBox.BackColor = AppColors.trueText;
                double itemPrice = double.Parse(ItemPriceTextBox.Text);
                _currentItem.Price = itemPrice;
                ItemListListBox.Enabled = true;
            }
            catch (Exception)
            {
                ItemPriceTextBox.BackColor = AppColors.falseText;
                ItemListListBox.Enabled = false;
            }
        }

        private void ItemNameRichTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ItemNameRichTextBox.Text)) return;
            try
            {
                ItemNameRichTextBox.BackColor = AppColors.trueText;
                string itemName = ItemNameRichTextBox.Text;
                _currentItem.Name = itemName;
                ItemListListBox.Enabled = true;
                _isRefreshed = false;
                Refresh();
            }
            catch (Exception)
            {
                ItemNameRichTextBox.BackColor = AppColors.falseText;
                ItemListListBox.Enabled = false;
            }
        }

        private void ItemInfoRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ItemInfoRichTextBox.Text)) return;
            try
            {
                ItemInfoRichTextBox.BackColor = AppColors.trueText;
                string itemInfo = ItemInfoRichTextBox.Text;
                _currentItem.Info = itemInfo;
                ItemListListBox.Enabled = true;
            }
            catch (Exception)
            {
                ItemInfoRichTextBox.BackColor = AppColors.falseText;
                ItemListListBox.Enabled = false;
            }
        }

        private void ItemSaveButton_Click(object sender, EventArgs e)
        {
            if (ItemListListBox.SelectedIndex > 0) return;
            _currentItem.Name = ItemNameRichTextBox.Text;
            _currentItem.Info = ItemInfoRichTextBox.Text;
            _currentItem.Price = Convert.ToDouble(ItemPriceTextBox.Text);
            _currentItem.Category = (Category)ItemCategoryComboBox.SelectedValue;
            UpdateListBox();

        }

        /// <summary>
        /// Обновление списка товаров.
        /// </summary>
        private void UpdateListBox()
        {
            ItemListListBox.Items.Clear();
            for (int i = 0; i < Items.Count; i++)
            {
                ItemListListBox.Items.Add(Items[i].Name.ToString());
            }
        }

        private void ItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemCategoryComboBox.SelectedItem is Category selectedCategory && _currentItem != null)
            {
                _currentItem.Category = selectedCategory;
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            _isRefreshed = false;
            Refresh();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isRefreshed = false;
            Refresh();
        }
    }


}
