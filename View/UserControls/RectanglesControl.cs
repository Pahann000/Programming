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
    public partial class RectanglesControl : UserControl
    {
        private static Rectangle[] _rectangles = null;
        private static Rectangle _currentRectangle = null;
        public RectanglesControl()
        {
            InitializeComponent();
            _rectangles = GetRandomRectangles(5);
            InitListBoxRectangles(5);
        }
        private Rectangle[] GetRandomRectangles(int size)
        {
            Rectangle[] myRectangles = new Rectangle[size];
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                myRectangles[i] = new Rectangle();
                myRectangles[i].RectangleWidth = ran.Next(10, 200);
                myRectangles[i].RectangleHeight = ran.Next(10, 200);
                myRectangles[i].CenterOfRectangle = new Point2D(ran.Next(0, 528), ran.Next(0, 451));
            }

            return myRectangles;
        }
        private void InitListBoxRectangles(int count)
        {
            for (int i = 0; i < count; i++)
            {
                RectangleListBox.Items.Add($"Rectangle {i + 1}");
            }
        }
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double MaxWidth = rectangles[0].RectangleWidth;
            int MaxWidthIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].RectangleWidth > MaxWidth)
                {
                    MaxWidth = rectangles[i].RectangleWidth;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;

        }
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WidthTextBox.Clear();
            LengthTextBox.Clear();
            ColorTextBox.Clear();
            if (RectangleListBox.SelectedIndex == null) { return; }
            _currentRectangle = _rectangles[RectangleListBox.SelectedIndex];
            WidthTextBox.Text = _currentRectangle.RectangleWidth.ToString();
            LengthTextBox.Text = _currentRectangle.RectangleHeight.ToString();
            ColorTextBox.Text = _currentRectangle.RectangleColor.ToString();
            RectangleCenterXCoordinatesTextBox.Text = _currentRectangle.CenterOfRectangle.Y.ToString();
            RectangleCenterYCoordinatesTextBox.Text = _currentRectangle.CenterOfRectangle.X.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LengthTextBox.BackColor = System.Drawing.Color.White;
                double RectangleLength = double.Parse(LengthTextBox.Text);
                _currentRectangle.RectangleHeight = RectangleLength;
            }
            catch (Exception)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                double RectangleWidth = double.Parse(WidthTextBox.Text);
                _currentRectangle.RectangleWidth = RectangleWidth;
            }
            catch (Exception)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {

            if (_currentRectangle == null) return;
            if (TryGetEnumValue(ColorTextBox.Text, out Colors value))
            {
                _currentRectangle.RectangleColor = value;
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int rectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = rectangleMaxWidthIndex;

        }
    }
}
