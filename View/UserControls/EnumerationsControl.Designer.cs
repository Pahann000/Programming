namespace Programming.View.UserControls
{
    partial class EnumerationsControl
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
            EnumerationsGroupBox = new GroupBox();
            ValueListBoxLabel = new Label();
            EnumsListBoxLabel = new Label();
            TextBoxLabel = new Label();
            IndexTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            EnumerationsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(ValueListBoxLabel);
            EnumerationsGroupBox.Controls.Add(EnumsListBoxLabel);
            EnumerationsGroupBox.Controls.Add(TextBoxLabel);
            EnumerationsGroupBox.Controls.Add(IndexTextBox);
            EnumerationsGroupBox.Controls.Add(ValuesListBox);
            EnumerationsGroupBox.Controls.Add(EnumsListBox);
            EnumerationsGroupBox.Dock = DockStyle.Fill;
            EnumerationsGroupBox.Location = new Point(0, 0);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Size = new Size(817, 263);
            EnumerationsGroupBox.TabIndex = 15;
            EnumerationsGroupBox.TabStop = false;
            EnumerationsGroupBox.Text = "Enumerations";
            // 
            // ValueListBoxLabel
            // 
            ValueListBoxLabel.AutoSize = true;
            ValueListBoxLabel.Location = new Point(334, 38);
            ValueListBoxLabel.Name = "ValueListBoxLabel";
            ValueListBoxLabel.Size = new Size(100, 20);
            ValueListBoxLabel.TabIndex = 11;
            ValueListBoxLabel.Text = "Choose value:";
            // 
            // EnumsListBoxLabel
            // 
            EnumsListBoxLabel.AutoSize = true;
            EnumsListBoxLabel.Location = new Point(64, 38);
            EnumsListBoxLabel.Name = "EnumsListBoxLabel";
            EnumsListBoxLabel.Size = new Size(149, 20);
            EnumsListBoxLabel.TabIndex = 10;
            EnumsListBoxLabel.Text = "Choose enumeration:";
            // 
            // TextBoxLabel
            // 
            TextBoxLabel.AutoSize = true;
            TextBoxLabel.Location = new Point(628, 38);
            TextBoxLabel.Name = "TextBoxLabel";
            TextBoxLabel.Size = new Size(68, 20);
            TextBoxLabel.TabIndex = 9;
            TextBoxLabel.Text = "Int value:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(628, 61);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(125, 27);
            IndexTextBox.TabIndex = 8;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(334, 61);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(178, 164);
            ValuesListBox.TabIndex = 7;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color ", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(64, 61);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(178, 164);
            EnumsListBox.TabIndex = 6;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumerationsGroupBox);
            Name = "EnumerationsControl";
            Size = new Size(817, 263);
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox EnumerationsGroupBox;
        private Label ValueListBoxLabel;
        private Label EnumsListBoxLabel;
        private Label TextBoxLabel;
        private TextBox IndexTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
    }
}
