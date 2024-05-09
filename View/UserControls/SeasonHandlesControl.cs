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
    public partial class SeasonHandlesControl : UserControl
    {
        public SeasonHandlesControl()
        {

            InitializeComponent();
        }

        private void SeasonHandlesControl_Load(object sender, EventArgs e)
        {
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonComboBox.SelectedIndex = 0;
        }

        private void SeasonHandleGroupBox_SizeChanged(object sender, EventArgs e)
        {
            SeasonComboBox.Width = this.Width - 87;
            SeasonButton.Left = this.Width - 78;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Season currentSeason = (Season)SeasonComboBox.SelectedItem;
            switch (currentSeason)
            {
                case Season.Winter:
                    MessageBox.Show("зима");
                    break;
                case Season.Spring:
                    MessageBox.Show("весна");
                    break;
                case Season.Summer:
                    SeasonButton.BackColor = System.Drawing.Color.Black;
                    break;
                case Season.Autumn:
                    MessageBox.Show("осень");
                    break;
            }
        }
    }
}
