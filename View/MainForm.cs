using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:
                    PopulateSecondListBoxWithDataFromFirst<Colors>();
                    break;
                case 1:
                    PopulateSecondListBoxWithDataFromFirst<EducationForm>();
                    break;
                case 2:
                    PopulateSecondListBoxWithDataFromFirst<Genre>();
                    break;
                case 3:
                    PopulateSecondListBoxWithDataFromFirst<Manufactures>();
                    break;
                case 4:
                    PopulateSecondListBoxWithDataFromFirst<Season>();
                    break;
                case 5:
                    PopulateSecondListBoxWithDataFromFirst<Weekday>();
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexTextBox.Clear();
            indexTextBox.Text = ValuesListBox.SelectedIndex.ToString();

        }
        private void PopulateSecondListBoxWithDataFromFirst<T>()
        {
            Type enumType = typeof(T);
            foreach (var item in Enum.GetValues(enumType))
            {
                ValuesListBox.Items.Add(item);
            }
        }
        public void WeekdayParsing(object sender, EventArgs e) 
        {
            Weekday weekday;
            string userDay = weekdayTextBox.Text;
            if(!string.IsNullOrEmpty(userDay))
            {
                if (Enum.TryParse(userDay, out weekday))
                {
                    weekdayLabel.Text = $"Этот день недели ({weekday} ={(int)weekday})";
                }
                else
                {
                    weekdayLabel.Text = "Нет такого дня недели";
                }
            }
            else
            {
                MessageBox.Show("Введите день для проверки");
            }

        }
    }
}

