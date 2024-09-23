namespace Programming.View.UserControls
{
    partial class RectanglesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelID = new Label();
            IdTextBox = new TextBox();
            labelY = new Label();
            labelX = new Label();
            RectangleCenterYCoordinatesTextBox = new TextBox();
            RectangleCenterXCoordinatesTextBox = new TextBox();
            FindRectangleButton = new Button();
            colorLabel = new Label();
            widthLabel = new Label();
            lengthLabel = new Label();
            ColorTextBox = new TextBox();
            WidthTextBox = new TextBox();
            LengthTextBox = new TextBox();
            RectangleListBox = new ListBox();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(129, 187);
            labelID.Name = "labelID";
            labelID.Size = new Size(25, 20);
            labelID.TabIndex = 27;
            labelID.Text = "Id:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(129, 208);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(36, 27);
            IdTextBox.TabIndex = 26;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(70, 188);
            labelY.Name = "labelY";
            labelY.Size = new Size(20, 20);
            labelY.TabIndex = 25;
            labelY.Text = "Y:";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(11, 188);
            labelX.Name = "labelX";
            labelX.Size = new Size(21, 20);
            labelX.TabIndex = 24;
            labelX.Text = "X:";
            // 
            // RectangleCenterYCoordinatesTextBox
            // 
            RectangleCenterYCoordinatesTextBox.Location = new Point(70, 208);
            RectangleCenterYCoordinatesTextBox.Name = "RectangleCenterYCoordinatesTextBox";
            RectangleCenterYCoordinatesTextBox.ReadOnly = true;
            RectangleCenterYCoordinatesTextBox.Size = new Size(36, 27);
            RectangleCenterYCoordinatesTextBox.TabIndex = 23;
            // 
            // RectangleCenterXCoordinatesTextBox
            // 
            RectangleCenterXCoordinatesTextBox.Location = new Point(12, 208);
            RectangleCenterXCoordinatesTextBox.Name = "RectangleCenterXCoordinatesTextBox";
            RectangleCenterXCoordinatesTextBox.ReadOnly = true;
            RectangleCenterXCoordinatesTextBox.Size = new Size(36, 27);
            RectangleCenterXCoordinatesTextBox.TabIndex = 22;
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.Location = new Point(192, 220);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(94, 29);
            FindRectangleButton.TabIndex = 21;
            FindRectangleButton.Text = "Find";
            FindRectangleButton.UseVisualStyleBackColor = true;
            FindRectangleButton.TextChanged += FindRectangleButton_Click;
            FindRectangleButton.Click += FindRectangleButton_Click;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(192, 130);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(48, 20);
            colorLabel.TabIndex = 20;
            colorLabel.Text = "Color:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(192, 70);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(52, 20);
            widthLabel.TabIndex = 19;
            widthLabel.Text = "Width:";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(192, 9);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(57, 20);
            lengthLabel.TabIndex = 18;
            lengthLabel.Text = "Length:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(192, 153);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 17;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(192, 93);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 16;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(192, 32);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 15;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // RectangleListBox
            // 
            RectangleListBox.FormattingEnabled = true;
            RectangleListBox.Location = new Point(6, 16);
            RectangleListBox.Name = "RectangleListBox";
            RectangleListBox.Size = new Size(150, 164);
            RectangleListBox.TabIndex = 14;
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelID);
            Controls.Add(IdTextBox);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(RectangleCenterYCoordinatesTextBox);
            Controls.Add(RectangleCenterXCoordinatesTextBox);
            Controls.Add(FindRectangleButton);
            Controls.Add(colorLabel);
            Controls.Add(widthLabel);
            Controls.Add(lengthLabel);
            Controls.Add(ColorTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(LengthTextBox);
            Controls.Add(RectangleListBox);
            Name = "RectanglesControl";
            Size = new Size(334, 274);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private TextBox IdTextBox;
        private Label labelY;
        private Label labelX;
        private TextBox RectangleCenterYCoordinatesTextBox;
        private TextBox RectangleCenterXCoordinatesTextBox;
        private Button FindRectangleButton;
        private Label colorLabel;
        private Label widthLabel;
        private Label lengthLabel;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private ListBox RectangleListBox;
    }
}
