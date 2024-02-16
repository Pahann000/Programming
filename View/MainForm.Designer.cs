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
            Enumeration = new TabPage();
            label1 = new Label();
            textBox1 = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            EnumsTabControl.SuspendLayout();
            Enumeration.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabControl
            // 
            EnumsTabControl.Controls.Add(Enumeration);
            EnumsTabControl.Dock = DockStyle.Fill;
            EnumsTabControl.Location = new Point(0, 0);
            EnumsTabControl.Name = "EnumsTabControl";
            EnumsTabControl.SelectedIndex = 0;
            EnumsTabControl.Size = new Size(800, 450);
            EnumsTabControl.TabIndex = 0;
            // 
            // Enumeration
            // 
            Enumeration.Controls.Add(label1);
            Enumeration.Controls.Add(textBox1);
            Enumeration.Controls.Add(ValuesListBox);
            Enumeration.Controls.Add(EnumsListBox);
            Enumeration.Location = new Point(4, 29);
            Enumeration.Name = "Enumeration";
            Enumeration.Padding = new Padding(3);
            Enumeration.Size = new Size(792, 417);
            Enumeration.TabIndex = 0;
            Enumeration.Text = "Enumeration";
            Enumeration.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(597, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(303, 35);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(176, 304);
            ValuesListBox.TabIndex = 1;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(33, 35);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(178, 304);
            EnumsListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnumsTabControl);
            Name = "MainForm";
            Text = "Form1";
            EnumsTabControl.ResumeLayout(false);
            Enumeration.ResumeLayout(false);
            Enumeration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage Enumeration;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label label1;
        private TextBox textBox1;
    }
}
