using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class RectangleCollisionControl : UserControl
    {
        private static List<Rectangle> _newRectangle = new List<Rectangle>();
        private static Rectangle _currentNewRectangle = null;
        private static List<Panel> _rectanglePanels = new List<Panel>();
        public RectangleCollisionControl()
        {
            InitializeComponent();
        }
        private void RectangleAddButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(1, RectangleRectanglesViewPanel.Width, RectangleRectanglesViewPanel.Height)[0];
            _newRectangle.Add(newRectangle);

            ListBoxNewRectangle.Items.Add($"{newRectangle.Id}. ({newRectangle.CenterOfRectangle} W = {newRectangle.RectangleWidth}; H = {newRectangle.RectangleHeight})");

            Panel newPanel = new Panel();
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.Location = new Point((int)(newRectangle.CenterOfRectangle.X - newRectangle.RectangleWidth / 2), (int)(newRectangle.CenterOfRectangle.Y - newRectangle.RectangleHeight / 2));
            newPanel.Width = (int)newRectangle.RectangleWidth;
            newPanel.Height = (int)newRectangle.RectangleHeight;

            _rectanglePanels.Add(newPanel);
            RectangleRectanglesViewPanel.Controls.Add(newPanel);
            CheckCollision();
        }
        private void CheckCollision()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_newRectangle[i], _newRectangle[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
        private void RectangleDeleteButton_Click(object sender, EventArgs e)
        {
            if (ListBoxNewRectangle.SelectedIndex < 0) return;
            _newRectangle.RemoveAt(ListBoxNewRectangle.SelectedIndex);
            _rectanglePanels.RemoveAt(ListBoxNewRectangle.SelectedIndex);
            RectangleRectanglesViewPanel.Controls.RemoveAt(ListBoxNewRectangle.SelectedIndex);
            ListBoxNewRectangle.Items.RemoveAt(ListBoxNewRectangle.SelectedIndex);
            CheckCollision();
        }
        private void ChangeTextElemListBoxRectangle()
        {
            ListBoxNewRectangle.Items[ListBoxNewRectangle.SelectedIndex] = $"{_newRectangle[ListBoxNewRectangle.SelectedIndex].Id}. (" +
                $"{_newRectangle[ListBoxNewRectangle.SelectedIndex].CenterOfRectangle} W = {_newRectangle[ListBoxNewRectangle.SelectedIndex].RectangleWidth}; " +
                $"H = {_newRectangle[ListBoxNewRectangle.SelectedIndex].RectangleHeight})";
        }

        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectanglesXTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectanglesXTextBox.Text);
                _currentNewRectangle.CenterOfRectangle = new Point2D(text, _currentNewRectangle.CenterOfRectangle.Y);
                RectanglesXTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Location = new Point(
                    text - _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Width / 2,
                    _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Location.Y);

                CheckCollision();
            }
            catch (Exception)
            {
                RectanglesXTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(RectanglesYTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectanglesYTextBox.Text);
                _currentNewRectangle.CenterOfRectangle = new Point2D(_currentNewRectangle.CenterOfRectangle.X, int.Parse(RectanglesYTextBox.Text));
                RectanglesYTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Location = new Point(
                    _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Location.X,
                    text - _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Height / 2);

                CheckCollision();
            }
            catch (Exception)
            {
                RectanglesYTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleWidthTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectangleWidthTextBox.Text);
                _currentNewRectangle.RectangleWidth = text;
                RectangleWidthTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Width = text;

                CheckCollision();
            }
            catch (Exception)
            {
                RectangleWidthTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleHeightTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectangleHeightTextBox.Text);
                _currentNewRectangle.RectangleHeight = text;
                RectangleHeightTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Height = text;

                CheckCollision();
            }
            catch (Exception)
            {
                RectangleHeightTextBox.BackColor = Color.LightPink;
            }
        }

        private void ListBoxNewRectangle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxNewRectangle.SelectedIndex < 0)
            {
                RectangleWidthTextBox.Text = string.Empty;
                RectangleHeightTextBox.Text = string.Empty;
                RectanglesXTextBox.Text = string.Empty;
                RectanglesYTextBox.Text = string.Empty;
                RectanglesIDTextBox.Text = string.Empty;
            }

            else
            {
                _currentNewRectangle = _newRectangle[ListBoxNewRectangle.SelectedIndex];

                RectangleWidthTextBox.Text = _currentNewRectangle.RectangleWidth.ToString();
                RectangleHeightTextBox.Text = _currentNewRectangle.RectangleHeight.ToString();
                RectanglesXTextBox.Text = _currentNewRectangle.CenterOfRectangle.X.ToString();
                RectanglesYTextBox.Text = _currentNewRectangle.CenterOfRectangle.Y.ToString();
                RectanglesIDTextBox.Text = _currentNewRectangle.Id.ToString();
            }
        }

    }
}
