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
        }

        /// <summary>
        /// Хранит данные о текущем товаре
        /// </summary>
        private static Item _currentItem = null;

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (ItemListListBox.SelectedIndex < 0) { return; }
            else 
            { 
                _items.RemoveAt(ItemListListBox.SelectedIndex); 
                ItemListListBox.Items.RemoveAt(ItemListListBox.SelectedIndex);
            }
        }

        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            newItem.Price = 0;
            newItem.Name = "Item Prototype";
            newItem.Info = "Empty";

            _items.Add(newItem);
            ItemListListBox.Items.Add(newItem);
        }

        private void ItemListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemListListBox.SelectedIndex < 0)
            {
                ItemPriceTextBox.Text = string.Empty;
                ItemInfoRichTextBox.Text = string.Empty;
                ItemNameRichTextBox.Text = string.Empty;
                ItemIdTextBox.Text = string.Empty;
            }

            else
            {
                _currentItem = _items[ItemListListBox.SelectedIndex];
                ItemPriceTextBox.Text = _currentItem.Price.ToString();
                ItemInfoRichTextBox.Text = _currentItem.Info.ToString();
                ItemNameRichTextBox.Text = _currentItem.Name.ToString();
                ItemIdTextBox.Text = _currentItem.Id.ToString();
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
            }
            catch(Exception)
            {
                ItemPriceTextBox.BackColor = AppColors.falseText;
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
            }
            catch(Exception)
            {
                ItemNameRichTextBox.BackColor = AppColors.falseText;
            }
        }

        private void ItemInfoRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ItemInfoRichTextBox.Text)) return;
            try
            {
                ItemInfoRichTextBox.BackColor = AppColors.trueText;
                string itemInfo = ItemInfoRichTextBox.Text;
                _currentItem.Name = itemInfo;
            }
            catch( Exception ) 
            {
                ItemInfoRichTextBox.BackColor = AppColors.falseText;
            }
        }

        /// <summary>
        /// Записывает имена товаров в элемент ListBox.
        /// </summary>
        private void ChangeTextElemListBoxInstitution()
        {
            ItemListListBox.Items[ItemListListBox.SelectedIndex] = _items[ItemListListBox.SelectedIndex].Name;
        }

        private void ItemSaveButton_Click(object sender, EventArgs e)
        {
            _currentItem.Name = ItemNameRichTextBox.Text;
            _currentItem.Info = ItemInfoRichTextBox.Text;
            _currentItem.Price = Convert.ToDouble(ItemPriceTextBox.Text);
            ChangeTextElemListBoxInstitution();
            
        }

        /// <summary>
        /// Сохраняет данные в файл
        /// </summary>
        public void SaveData()
        {
            string path = Environment.CurrentDirectory + @"\OOPdata.txt";
            string data = JsonSerializer.Serialize(_items);

            File.WriteAllText(path, data);
        }

        /// <summary>
        /// Загружает данные.
        /// </summary>
        public void LoadData()
        {
            string path = Environment.CurrentDirectory + @"\OOPdata.txt";

            if (!File.Exists(path)) return;

            string data = File.ReadAllText(path);

            _items = JsonSerializer.Deserialize<List<Item>>(data);

        }
    }


}
