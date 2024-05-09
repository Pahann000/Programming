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
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
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
        private void PopulateSecondListBox<T>()
        {
            Type enumType = typeof(T);
            foreach (var item in Enum.GetValues(enumType))
            {
                ValuesListBox.Items.Add(item);
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexTextBox.Clear();
            IndexTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
    }
}
