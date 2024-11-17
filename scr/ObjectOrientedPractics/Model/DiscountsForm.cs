using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    public partial class DiscountsForm : Form
    {
        public DiscountsForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());

        }

        /// <summary>
        /// Получает или задает процентную скидку, которая будет добавлена.
        /// </summary>
        public PercentDiscount PercentDiscount { get; set; }


        /// <summary>
        /// Обрабатывает нажатие кнопки ОК.
        /// Проверяет, выбрана ли категория, и закрывает форму, возвращая результат ОК.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали категорию!");
                return;
            }
            PercentDiscount = new PercentDiscount((Category)CategoryComboBox.SelectedItem, 0);
            DialogResult = DialogResult.OK;
            Close();
        }
        /// <summary>
        /// Обрабатывает нажатие кнопки Отмена.
        /// Закрывает форму с результатом Cancel.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
