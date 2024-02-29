using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
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
                    PopulateSecondListBox<Colors>();
                    break;
                case 1:
                    PopulateSecondListBox<EducationForm>();
                    break;
                case 2:
                    PopulateSecondListBox<Genre>();
                    break;
                case 3:
                    PopulateSecondListBox<Manufactures>();
                    break;
                case 4:
                    PopulateSecondListBox<Season>();
                    break;
                case 5:
                    PopulateSecondListBox<Weekday>();
                    break;
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexTextBox.Clear();
            IndexTextBox.Text = ValuesListBox.SelectedIndex.ToString();

        }
        private void PopulateSecondListBox<T>()
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
            string userDay = WeekdayTextBox.Text;
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
            }
            else
            {
                MessageBox.Show("Введите день для проверки");
            }

        }
        public void SeasonMoves(object sender, EventArgs e)
        {
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Бррр, холодно");
                    break;
                case 1:
                    Enums.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case 2:
                    MessageBox.Show("Ура!Солнце!");
                    break;
                case 3:
                    Enums.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
    }
}