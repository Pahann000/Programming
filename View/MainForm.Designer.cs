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
            weekdayLabel = new Label();
            parseButton = new Button();
            weekdayTextBox = new TextBox();
            parsingLabel = new Label();
            valueListBoxLabel = new Label();
            enumsListBoxLabel = new Label();
            textBoxLabel = new Label();
            indexTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            EnumsTabControl.SuspendLayout();
            Enums.SuspendLayout();
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
            Enums.Controls.Add(weekdayLabel);
            Enums.Controls.Add(parseButton);
            Enums.Controls.Add(weekdayTextBox);
            Enums.Controls.Add(parsingLabel);
            Enums.Controls.Add(valueListBoxLabel);
            Enums.Controls.Add(enumsListBoxLabel);
            Enums.Controls.Add(textBoxLabel);
            Enums.Controls.Add(indexTextBox);
            Enums.Controls.Add(ValuesListBox);
            Enums.Controls.Add(EnumsListBox);
            Enums.ImeMode = ImeMode.NoControl;
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(828, 451);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // weekdayLabel
            // 
            weekdayLabel.AutoSize = true;
            weekdayLabel.Location = new Point(33, 389);
            weekdayLabel.Name = "weekdayLabel";
            weekdayLabel.Size = new Size(0, 20);
            weekdayLabel.TabIndex = 9;
            // 
            // parseButton
            // 
            parseButton.Location = new Point(217, 341);
            parseButton.Name = "parseButton";
            parseButton.Size = new Size(94, 29);
            parseButton.TabIndex = 8;
            parseButton.Text = "Parse";
            parseButton.UseVisualStyleBackColor = true;
            parseButton.Click += WeekdayParsing;
            // 
            // weekdayTextBox
            // 
            weekdayTextBox.Location = new Point(33, 341);
            weekdayTextBox.Name = "weekdayTextBox";
            weekdayTextBox.Size = new Size(125, 27);
            weekdayTextBox.TabIndex = 7;
            // 
            // parsingLabel
            // 
            parsingLabel.AutoSize = true;
            parsingLabel.Location = new Point(24, 318);
            parsingLabel.Name = "parsingLabel";
            parsingLabel.Size = new Size(158, 20);
            parsingLabel.TabIndex = 6;
            parsingLabel.Text = "Type value for parsing:";
            // 
            // valueListBoxLabel
            // 
            valueListBoxLabel.AutoSize = true;
            valueListBoxLabel.Location = new Point(303, 12);
            valueListBoxLabel.Name = "valueListBoxLabel";
            valueListBoxLabel.Size = new Size(100, 20);
            valueListBoxLabel.TabIndex = 5;
            valueListBoxLabel.Text = "Choose value:";
            // 
            // enumsListBoxLabel
            // 
            enumsListBoxLabel.AutoSize = true;
            enumsListBoxLabel.Location = new Point(33, 12);
            enumsListBoxLabel.Name = "enumsListBoxLabel";
            enumsListBoxLabel.Size = new Size(149, 20);
            enumsListBoxLabel.TabIndex = 4;
            enumsListBoxLabel.Text = "Choose enumeration:";
            // 
            // textBoxLabel
            // 
            textBoxLabel.AutoSize = true;
            textBoxLabel.Location = new Point(597, 12);
            textBoxLabel.Name = "textBoxLabel";
            textBoxLabel.Size = new Size(68, 20);
            textBoxLabel.TabIndex = 3;
            textBoxLabel.Text = "Int value:";
            // 
            // indexTextBox
            // 
            indexTextBox.Location = new Point(597, 35);
            indexTextBox.Name = "indexTextBox";
            indexTextBox.Size = new Size(125, 27);
            indexTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(303, 35);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(176, 204);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color ", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(33, 35);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(178, 204);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
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
            Enums.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage Enums;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label textBoxLabel;
        private TextBox indexTextBox;
        private Label valueListBoxLabel;
        private Label enumsListBoxLabel;
        private Label parsingLabel;
        private Label weekdayLabel;
        private Button parseButton;
        private TextBox weekdayTextBox;
    }
}
