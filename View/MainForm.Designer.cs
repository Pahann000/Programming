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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            EnumsTabControl.Tag = "ge";
            // 
            // Enums
            // 
            Enums.AccessibleName = "";
            Enums.Controls.Add(label4);
            Enums.Controls.Add(label3);
            Enums.Controls.Add(label2);
            Enums.Controls.Add(label1);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(581, 308);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 6;
            label4.Text = "Type value for parsing:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 12);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 5;
            label3.Text = "Choose value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 12);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 4;
            label2.Text = "Choose enumeration:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(597, 12);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 3;
            label1.Text = "Int value:";
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
            ValuesListBox.Size = new Size(176, 304);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color ", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(33, 35);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(178, 304);
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
        private Label label1;
        private TextBox indexTextBox;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
