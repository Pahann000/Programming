using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.UserControls
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка на день недели.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WeekdayParsing(object sender, EventArgs e)
        {
            Weekday weekday;
            var userDay = WeekdayTextBox.Text;
            int examination;
            bool isInt;
            if (!string.IsNullOrEmpty(userDay))
            {
                if (Enum.TryParse(userDay, out weekday))
                {
                    WeekdayLabel.Text = $"Этот день недели ({weekday} ={(int)weekday})";
                }
                else
                {
                    WeekdayLabel.Text = "Нет такого дня недели";
                }
                isInt = int.TryParse(userDay, out examination);
                if (isInt)
                {
                    WeekdayLabel.Text = "Введите название дня текстом.";
                }
            }
            else
            {
                MessageBox.Show("Введите день для проверки");
            }
        }
    }
}
