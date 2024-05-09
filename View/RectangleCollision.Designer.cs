namespace Programming.View
{
    partial class RectangleCollisionControl
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
            RectangleRectanglesViewPanel = new Panel();
            ListBoxNewRectangle = new ListBox();
            RectanglesIDTextBox = new TextBox();
            RectanglesXTextBox = new TextBox();
            RectanglesYTextBox = new TextBox();
            RectangleWidthTextBox = new TextBox();
            RectangleHeightTextBox = new TextBox();
            RectangleAddButton = new Button();
            RectangleDeleteButton = new Button();
            RectangleCurrentLabel = new Label();
            RectangleXLabel = new Label();
            RectangleYLabel = new Label();
            RectangleIDLabel = new Label();
            RectangleWidthLabel = new Label();
            RectangleHeightLabel = new Label();
            RectangleCollisionGroupBox = new GroupBox();
            RectangleCollisionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectangleRectanglesViewPanel
            // 
            RectangleRectanglesViewPanel.Location = new Point(311, 3);
            RectangleRectanglesViewPanel.Name = "RectangleRectanglesViewPanel";
            RectangleRectanglesViewPanel.Size = new Size(528, 451);
            RectangleRectanglesViewPanel.TabIndex = 32;
            // 
            // ListBoxNewRectangle
            // 
            ListBoxNewRectangle.FormattingEnabled = true;
            ListBoxNewRectangle.Location = new Point(14, 31);
            ListBoxNewRectangle.Name = "ListBoxNewRectangle";
            ListBoxNewRectangle.Size = new Size(291, 204);
            ListBoxNewRectangle.TabIndex = 33;
            ListBoxNewRectangle.SelectedIndexChanged += ListBoxNewRectangle_SelectedIndexChanged;
            // 
            // RectanglesIDTextBox
            // 
            RectanglesIDTextBox.Location = new Point(56, 307);
            RectanglesIDTextBox.Name = "RectanglesIDTextBox";
            RectanglesIDTextBox.ReadOnly = true;
            RectanglesIDTextBox.Size = new Size(40, 27);
            RectanglesIDTextBox.TabIndex = 34;
            // 
            // RectanglesXTextBox
            // 
            RectanglesXTextBox.Location = new Point(56, 352);
            RectanglesXTextBox.Name = "RectanglesXTextBox";
            RectanglesXTextBox.Size = new Size(40, 27);
            RectanglesXTextBox.TabIndex = 35;
            RectanglesXTextBox.TextChanged += RectanglesXTextBox_TextChanged;
            // 
            // RectanglesYTextBox
            // 
            RectanglesYTextBox.Location = new Point(56, 400);
            RectanglesYTextBox.Name = "RectanglesYTextBox";
            RectanglesYTextBox.Size = new Size(40, 27);
            RectanglesYTextBox.TabIndex = 36;
            RectanglesYTextBox.TextChanged += RectanglesYTextBox_TextChanged;
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(194, 307);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(60, 27);
            RectangleWidthTextBox.TabIndex = 37;
            RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
            // 
            // RectangleHeightTextBox
            // 
            RectangleHeightTextBox.Location = new Point(199, 400);
            RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            RectangleHeightTextBox.Size = new Size(60, 27);
            RectangleHeightTextBox.TabIndex = 38;
            RectangleHeightTextBox.TextChanged += RectangleHeightTextBox_TextChanged;
            // 
            // RectangleAddButton
            // 
            RectangleAddButton.Location = new Point(16, 241);
            RectangleAddButton.Name = "RectangleAddButton";
            RectangleAddButton.Size = new Size(94, 29);
            RectangleAddButton.TabIndex = 39;
            RectangleAddButton.Text = "Add";
            RectangleAddButton.UseVisualStyleBackColor = true;
            RectangleAddButton.Click += RectangleAddButton_Click;
            // 
            // RectangleDeleteButton
            // 
            RectangleDeleteButton.Location = new Point(162, 241);
            RectangleDeleteButton.Name = "RectangleDeleteButton";
            RectangleDeleteButton.Size = new Size(94, 29);
            RectangleDeleteButton.TabIndex = 40;
            RectangleDeleteButton.Text = "Delete";
            RectangleDeleteButton.UseVisualStyleBackColor = true;
            RectangleDeleteButton.Click += RectangleDeleteButton_Click;
            // 
            // RectangleCurrentLabel
            // 
            RectangleCurrentLabel.AutoSize = true;
            RectangleCurrentLabel.Location = new Point(11, 284);
            RectangleCurrentLabel.Name = "RectangleCurrentLabel";
            RectangleCurrentLabel.Size = new Size(126, 20);
            RectangleCurrentLabel.TabIndex = 41;
            RectangleCurrentLabel.Text = "CurrentRectangle:";
            // 
            // RectangleXLabel
            // 
            RectangleXLabel.AutoSize = true;
            RectangleXLabel.Location = new Point(29, 352);
            RectangleXLabel.Name = "RectangleXLabel";
            RectangleXLabel.Size = new Size(21, 20);
            RectangleXLabel.TabIndex = 42;
            RectangleXLabel.Text = "X:";
            // 
            // RectangleYLabel
            // 
            RectangleYLabel.AutoSize = true;
            RectangleYLabel.Location = new Point(30, 400);
            RectangleYLabel.Name = "RectangleYLabel";
            RectangleYLabel.Size = new Size(20, 20);
            RectangleYLabel.TabIndex = 43;
            RectangleYLabel.Text = "Y:";
            // 
            // RectangleIDLabel
            // 
            RectangleIDLabel.AutoSize = true;
            RectangleIDLabel.Location = new Point(25, 307);
            RectangleIDLabel.Name = "RectangleIDLabel";
            RectangleIDLabel.Size = new Size(25, 20);
            RectangleIDLabel.TabIndex = 44;
            RectangleIDLabel.Text = "Id:";
            // 
            // RectangleWidthLabel
            // 
            RectangleWidthLabel.AutoSize = true;
            RectangleWidthLabel.Location = new Point(136, 307);
            RectangleWidthLabel.Name = "RectangleWidthLabel";
            RectangleWidthLabel.Size = new Size(52, 20);
            RectangleWidthLabel.TabIndex = 45;
            RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleHeightLabel
            // 
            RectangleHeightLabel.AutoSize = true;
            RectangleHeightLabel.Location = new Point(136, 400);
            RectangleHeightLabel.Name = "RectangleHeightLabel";
            RectangleHeightLabel.Size = new Size(57, 20);
            RectangleHeightLabel.TabIndex = 46;
            RectangleHeightLabel.Text = "Height:";
            // 
            // RectangleCollisionGroupBox
            // 
            RectangleCollisionGroupBox.Controls.Add(RectangleHeightLabel);
            RectangleCollisionGroupBox.Controls.Add(RectangleWidthLabel);
            RectangleCollisionGroupBox.Controls.Add(RectangleIDLabel);
            RectangleCollisionGroupBox.Controls.Add(RectangleYLabel);
            RectangleCollisionGroupBox.Controls.Add(RectangleXLabel);
            RectangleCollisionGroupBox.Controls.Add(RectangleCurrentLabel);
            RectangleCollisionGroupBox.Controls.Add(RectangleDeleteButton);
            RectangleCollisionGroupBox.Controls.Add(RectangleAddButton);
            RectangleCollisionGroupBox.Controls.Add(RectangleHeightTextBox);
            RectangleCollisionGroupBox.Controls.Add(RectangleWidthTextBox);
            RectangleCollisionGroupBox.Controls.Add(RectanglesYTextBox);
            RectangleCollisionGroupBox.Controls.Add(RectanglesXTextBox);
            RectangleCollisionGroupBox.Controls.Add(RectanglesIDTextBox);
            RectangleCollisionGroupBox.Controls.Add(ListBoxNewRectangle);
            RectangleCollisionGroupBox.Controls.Add(RectangleRectanglesViewPanel);
            RectangleCollisionGroupBox.Dock = DockStyle.Fill;
            RectangleCollisionGroupBox.Location = new Point(0, 0);
            RectangleCollisionGroupBox.Name = "RectangleCollisionGroupBox";
            RectangleCollisionGroupBox.Size = new Size(835, 454);
            RectangleCollisionGroupBox.TabIndex = 0;
            RectangleCollisionGroupBox.TabStop = false;
            RectangleCollisionGroupBox.Text = "RectanglesCollision";
            // 
            // RectangleCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectangleCollisionGroupBox);
            Name = "RectangleCollisionControl";
            Size = new Size(835, 454);
            RectangleCollisionGroupBox.ResumeLayout(false);
            RectangleCollisionGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel RectangleRectanglesViewPanel;
        private ListBox ListBoxNewRectangle;
        private TextBox RectanglesIDTextBox;
        private TextBox RectanglesXTextBox;
        private TextBox RectanglesYTextBox;
        private TextBox RectangleWidthTextBox;
        private TextBox RectangleHeightTextBox;
        private Button RectangleAddButton;
        private Button RectangleDeleteButton;
        private Label RectangleCurrentLabel;
        private Label RectangleXLabel;
        private Label RectangleYLabel;
        private Label RectangleIDLabel;
        private Label RectangleWidthLabel;
        private Label RectangleHeightLabel;
        private GroupBox RectangleCollisionGroupBox;
    }
}
