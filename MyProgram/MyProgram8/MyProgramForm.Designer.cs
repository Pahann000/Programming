namespace MyProgram8
{
    partial class MyProgramForm
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
            AddNotesButton = new Button();
            ChangeNotesButton = new Button();
            CategoryComboBox = new ComboBox();
            NotesListBox = new ListBox();
            groupBoxChanging = new GroupBox();
            SavingTimeLabel = new Label();
            CategoriesLabel = new Label();
            TextLabel = new Label();
            TitleLabel = new Label();
            SavingTimeTextBox = new TextBox();
            NoteTextBox = new TextBox();
            TitleTextBox = new TextBox();
            DeleteNotesButton = new Button();
            groupBoxChanging.SuspendLayout();
            SuspendLayout();
            // 
            // AddNotesButton
            // 
            AddNotesButton.Location = new Point(0, 350);
            AddNotesButton.Name = "AddNotesButton";
            AddNotesButton.Size = new Size(94, 29);
            AddNotesButton.TabIndex = 0;
            AddNotesButton.Text = "Add";
            AddNotesButton.UseVisualStyleBackColor = true;
            AddNotesButton.Click += AddNotesButton_Click;
            // 
            // ChangeNotesButton
            // 
            ChangeNotesButton.Location = new Point(123, 350);
            ChangeNotesButton.Name = "ChangeNotesButton";
            ChangeNotesButton.Size = new Size(94, 29);
            ChangeNotesButton.TabIndex = 3;
            ChangeNotesButton.Text = "Change";
            ChangeNotesButton.UseVisualStyleBackColor = true;
            ChangeNotesButton.Click += ChangeNotesButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(95, 152);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 4;
            // 
            // NotesListBox
            // 
            NotesListBox.FormattingEnabled = true;
            NotesListBox.Location = new Point(0, 0);
            NotesListBox.Name = "NotesListBox";
            NotesListBox.Size = new Size(341, 344);
            NotesListBox.TabIndex = 5;
            NotesListBox.SelectedIndexChanged += NotesListBox_SelectedIndexChanged;
            // 
            // groupBoxChanging
            // 
            groupBoxChanging.Controls.Add(SavingTimeLabel);
            groupBoxChanging.Controls.Add(CategoriesLabel);
            groupBoxChanging.Controls.Add(TextLabel);
            groupBoxChanging.Controls.Add(TitleLabel);
            groupBoxChanging.Controls.Add(SavingTimeTextBox);
            groupBoxChanging.Controls.Add(NoteTextBox);
            groupBoxChanging.Controls.Add(TitleTextBox);
            groupBoxChanging.Controls.Add(CategoryComboBox);
            groupBoxChanging.Location = new Point(347, 12);
            groupBoxChanging.Name = "groupBoxChanging";
            groupBoxChanging.Size = new Size(450, 290);
            groupBoxChanging.TabIndex = 6;
            groupBoxChanging.TabStop = false;
            groupBoxChanging.Text = "Select Instruction:";
            // 
            // SavingTimeLabel
            // 
            SavingTimeLabel.AutoSize = true;
            SavingTimeLabel.Location = new Point(6, 205);
            SavingTimeLabel.Name = "SavingTimeLabel";
            SavingTimeLabel.Size = new Size(93, 20);
            SavingTimeLabel.TabIndex = 11;
            SavingTimeLabel.Text = "Saving Time:";
            // 
            // CategoriesLabel
            // 
            CategoriesLabel.AutoSize = true;
            CategoriesLabel.Location = new Point(6, 152);
            CategoriesLabel.Name = "CategoriesLabel";
            CategoriesLabel.Size = new Size(83, 20);
            CategoriesLabel.TabIndex = 10;
            CategoriesLabel.Text = "Categories:";
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(6, 99);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(39, 20);
            TextLabel.TabIndex = 9;
            TextLabel.Text = "Text:";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(6, 46);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 8;
            TitleLabel.Text = "Title:";
            // 
            // SavingTimeTextBox
            // 
            SavingTimeTextBox.Location = new Point(105, 202);
            SavingTimeTextBox.Name = "SavingTimeTextBox";
            SavingTimeTextBox.ReadOnly = true;
            SavingTimeTextBox.Size = new Size(141, 27);
            SavingTimeTextBox.TabIndex = 7;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(53, 99);
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(391, 27);
            NoteTextBox.TabIndex = 6;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(53, 46);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(391, 27);
            TitleTextBox.TabIndex = 5;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // DeleteNotesButton
            // 
            DeleteNotesButton.Location = new Point(247, 350);
            DeleteNotesButton.Name = "DeleteNotesButton";
            DeleteNotesButton.Size = new Size(94, 29);
            DeleteNotesButton.TabIndex = 7;
            DeleteNotesButton.Text = "Delete";
            DeleteNotesButton.UseVisualStyleBackColor = true;
            DeleteNotesButton.Click += DeleteNotesButton_Click;
            // 
            // MyProgramForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(DeleteNotesButton);
            Controls.Add(groupBoxChanging);
            Controls.Add(NotesListBox);
            Controls.Add(ChangeNotesButton);
            Controls.Add(AddNotesButton);
            Name = "MyProgramForm";
            Text = "MyProgram";
            FormClosing += MyProgramForm_FormClosing;
            Load += MyProgramForm_Load;
            groupBoxChanging.ResumeLayout(false);
            groupBoxChanging.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button AddNotesButton;
        private Button DeleteNotesButton;
        private Button button3;
        private Button ChangeNotesButton;
        private ComboBox CategoryComboBox;
        private ListBox NotesListBox;
        private GroupBox groupBoxChanging;
        private TextBox SavingTimeTextBox;
        private TextBox NoteTextBox;
        private TextBox TitleTextBox;
        private Label SavingTimeLabel;
        private Label CategoriesLabel;
        private Label TextLabel;
        private Label TitleLabel;
    }
}
