namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnumsTabControl = new TabControl();
            Enums = new TabPage();
            groupBox1 = new GroupBox();
            ValueListBoxLabel = new Label();
            EnumsListBoxLabel = new Label();
            TextBoxLabel = new Label();
            IndexTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            groupBox2 = new GroupBox();
            WeekdayLabel = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            ParsingLabel = new Label();
            groupBox3 = new GroupBox();
            SeasonLabel = new Label();
            SeasonComboBox = new ComboBox();
            SeasonButton = new Button();
            EnumsTabControl.SuspendLayout();
            Enums.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabControl
            // 
            EnumsTabControl.Controls.Add(Enums);
            EnumsTabControl.Dock = DockStyle.Fill;
            EnumsTabControl.Location = new Point(0, 0);
            EnumsTabControl.Name = "EnumsTabControl";
            EnumsTabControl.SelectedIndex = 0;
            EnumsTabControl.Size = new Size(836, 484);
            EnumsTabControl.TabIndex = 0;
            EnumsTabControl.Tag = "";
            // 
            // Enums
            // 
            Enums.AccessibleName = "";
            Enums.Controls.Add(groupBox3);
            Enums.Controls.Add(groupBox2);
            Enums.Controls.Add(groupBox1);
            Enums.ImeMode = ImeMode.NoControl;
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(828, 451);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ValueListBoxLabel);
            groupBox1.Controls.Add(EnumsListBoxLabel);
            groupBox1.Controls.Add(TextBoxLabel);
            groupBox1.Controls.Add(IndexTextBox);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(817, 263);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
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
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color ", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(64, 61);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(178, 164);
            EnumsListBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(WeekdayLabel);
            groupBox2.Controls.Add(ParseButton);
            groupBox2.Controls.Add(WeekdayTextBox);
            groupBox2.Controls.Add(ParsingLabel);
            groupBox2.Location = new Point(3, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 173);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Parsing";
            // 
            // WeekdayLabel
            // 
            WeekdayLabel.AutoSize = true;
            WeekdayLabel.Location = new Point(16, 112);
            WeekdayLabel.Name = "WeekdayLabel";
            WeekdayLabel.Size = new Size(0, 20);
            WeekdayLabel.TabIndex = 13;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(200, 64);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 12;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(16, 66);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(125, 27);
            WeekdayTextBox.TabIndex = 11;
            // 
            // ParsingLabel
            // 
            ParsingLabel.AutoSize = true;
            ParsingLabel.Location = new Point(7, 41);
            ParsingLabel.Name = "ParsingLabel";
            ParsingLabel.Size = new Size(158, 20);
            ParsingLabel.TabIndex = 10;
            ParsingLabel.Text = "Type value for parsing:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SeasonLabel);
            groupBox3.Controls.Add(SeasonComboBox);
            groupBox3.Controls.Add(SeasonButton);
            groupBox3.Location = new Point(419, 275);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(401, 173);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Season Handle";
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(69, 41);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(110, 20);
            SeasonLabel.TabIndex = 15;
            SeasonLabel.Text = "Choose season:";
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            SeasonComboBox.Location = new Point(69, 64);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(151, 28);
            SeasonComboBox.TabIndex = 14;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(250, 64);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(94, 29);
            SeasonButton.TabIndex = 13;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 484);
            Controls.Add(EnumsTabControl);
            Name = "MainForm";
            Text = "Programming Demo";
            EnumsTabControl.ResumeLayout(false);
            Enums.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage Enums;
        private GroupBox groupBox3;
        private Label SeasonLabel;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
        private GroupBox groupBox2;
        private Label WeekdayLabel;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label ParsingLabel;
        private GroupBox groupBox1;
        private Label ValueListBoxLabel;
        private Label EnumsListBoxLabel;
        private Label TextBoxLabel;
        private TextBox IndexTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
    }
}
