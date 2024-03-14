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
            enumsPage = new TabPage();
            SeasonGroupBox = new GroupBox();
            SeasonLabel = new Label();
            SeasonComboBox = new ComboBox();
            SeasonButton = new Button();
            ParsingGroupBox = new GroupBox();
            WeekdayLabel = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            ParsingLabel = new Label();
            EnumerationsGroupBox = new GroupBox();
            ValueListBoxLabel = new Label();
            EnumsListBoxLabel = new Label();
            TextBoxLabel = new Label();
            IndexTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            classesPage = new TabPage();
            rectanglesGroupBox = new GroupBox();
            rectangleListBox = new ListBox();
            lenghtTextBox = new TextBox();
            widthTextBox = new TextBox();
            colorTextBox = new TextBox();
            lengthLabel = new Label();
            widthLabel = new Label();
            colorLabel = new Label();
            findRectangleButton = new Button();
            EnumsTabControl.SuspendLayout();
            enumsPage.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            ParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            classesPage.SuspendLayout();
            rectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabControl
            // 
            EnumsTabControl.Controls.Add(enumsPage);
            EnumsTabControl.Controls.Add(classesPage);
            EnumsTabControl.Dock = DockStyle.Fill;
            EnumsTabControl.Location = new Point(0, 0);
            EnumsTabControl.Name = "EnumsTabControl";
            EnumsTabControl.SelectedIndex = 0;
            EnumsTabControl.Size = new Size(836, 484);
            EnumsTabControl.TabIndex = 0;
            EnumsTabControl.Tag = "";
            // 
            // enumsPage
            // 
            enumsPage.AccessibleName = "";
            enumsPage.Controls.Add(SeasonGroupBox);
            enumsPage.Controls.Add(ParsingGroupBox);
            enumsPage.Controls.Add(EnumerationsGroupBox);
            enumsPage.ImeMode = ImeMode.NoControl;
            enumsPage.Location = new Point(4, 29);
            enumsPage.Name = "enumsPage";
            enumsPage.Padding = new Padding(3);
            enumsPage.Size = new Size(828, 451);
            enumsPage.TabIndex = 0;
            enumsPage.Text = "Enums";
            enumsPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Controls.Add(SeasonButton);
            SeasonGroupBox.Location = new Point(419, 275);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(401, 173);
            SeasonGroupBox.TabIndex = 16;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
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
            SeasonButton.Click += SeasonMoves;
            // 
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(WeekdayLabel);
            ParsingGroupBox.Controls.Add(ParseButton);
            ParsingGroupBox.Controls.Add(WeekdayTextBox);
            ParsingGroupBox.Controls.Add(ParsingLabel);
            ParsingGroupBox.Location = new Point(3, 275);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(410, 173);
            ParsingGroupBox.TabIndex = 15;
            ParsingGroupBox.TabStop = false;
            ParsingGroupBox.Text = "Weekday Parsing";
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
            ParseButton.Click += WeekdayParsing;
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
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(ValueListBoxLabel);
            EnumerationsGroupBox.Controls.Add(EnumsListBoxLabel);
            EnumerationsGroupBox.Controls.Add(TextBoxLabel);
            EnumerationsGroupBox.Controls.Add(IndexTextBox);
            EnumerationsGroupBox.Controls.Add(ValuesListBox);
            EnumerationsGroupBox.Controls.Add(EnumsListBox);
            EnumerationsGroupBox.Location = new Point(3, 6);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Size = new Size(817, 263);
            EnumerationsGroupBox.TabIndex = 14;
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
            // classesPage
            // 
            classesPage.Controls.Add(rectanglesGroupBox);
            classesPage.Location = new Point(4, 29);
            classesPage.Name = "classesPage";
            classesPage.Size = new Size(828, 451);
            classesPage.TabIndex = 1;
            classesPage.Text = "Classes";
            classesPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesGroupBox
            // 
            rectanglesGroupBox.Controls.Add(findRectangleButton);
            rectanglesGroupBox.Controls.Add(colorLabel);
            rectanglesGroupBox.Controls.Add(widthLabel);
            rectanglesGroupBox.Controls.Add(lengthLabel);
            rectanglesGroupBox.Controls.Add(colorTextBox);
            rectanglesGroupBox.Controls.Add(widthTextBox);
            rectanglesGroupBox.Controls.Add(lenghtTextBox);
            rectanglesGroupBox.Controls.Add(rectangleListBox);
            rectanglesGroupBox.Location = new Point(3, 3);
            rectanglesGroupBox.Name = "rectanglesGroupBox";
            rectanglesGroupBox.Size = new Size(339, 281);
            rectanglesGroupBox.TabIndex = 0;
            rectanglesGroupBox.TabStop = false;
            rectanglesGroupBox.Text = "Rectangles";
            // 
            // rectangleListBox
            // 
            rectangleListBox.FormattingEnabled = true;
            rectangleListBox.Location = new Point(6, 26);
            rectangleListBox.Name = "rectangleListBox";
            rectangleListBox.Size = new Size(150, 164);
            rectangleListBox.TabIndex = 0;
            // 
            // lenghtTextBox
            // 
            lenghtTextBox.Location = new Point(186, 42);
            lenghtTextBox.Name = "lenghtTextBox";
            lenghtTextBox.Size = new Size(125, 27);
            lenghtTextBox.TabIndex = 1;
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(186, 103);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(125, 27);
            widthTextBox.TabIndex = 2;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(186, 163);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(125, 27);
            colorTextBox.TabIndex = 3;
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(186, 19);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(57, 20);
            lengthLabel.TabIndex = 4;
            lengthLabel.Text = "Length:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(186, 80);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(52, 20);
            widthLabel.TabIndex = 5;
            widthLabel.Text = "Width:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(186, 140);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(48, 20);
            colorLabel.TabIndex = 6;
            colorLabel.Text = "Color:";
            // 
            // findRectangleButton
            // 
            findRectangleButton.Location = new Point(186, 226);
            findRectangleButton.Name = "findRectangleButton";
            findRectangleButton.Size = new Size(94, 29);
            findRectangleButton.TabIndex = 7;
            findRectangleButton.Text = "Find";
            findRectangleButton.UseVisualStyleBackColor = true;
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
            enumsPage.ResumeLayout(false);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            ParsingGroupBox.ResumeLayout(false);
            ParsingGroupBox.PerformLayout();
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            classesPage.ResumeLayout(false);
            rectanglesGroupBox.ResumeLayout(false);
            rectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage enumsPage;
        private Label SeasonLabel;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
        private GroupBox ParsingGroupBox;
        private Label WeekdayLabel;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label ParsingLabel;
        private Label ValueListBoxLabel;
        private Label EnumsListBoxLabel;
        private Label TextBoxLabel;
        private TextBox IndexTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        public GroupBox SeasonGroupBox;
        public GroupBox EnumerationsGroupBox;
        private TabPage classesPage;
        private GroupBox rectanglesGroupBox;
        private Label colorLabel;
        private Label widthLabel;
        private Label lengthLabel;
        private TextBox colorTextBox;
        private TextBox widthTextBox;
        private TextBox lenghtTextBox;
        private ListBox rectangleListBox;
        private Button findRectangleButton;
    }
}
