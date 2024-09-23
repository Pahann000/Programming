namespace Programming.View.UserControls
{
    partial class WeekdayParsingControl
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
            ParsingGroupBox = new GroupBox();
            WeekdayLabel = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            ParsingLabel = new Label();
            ParsingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(WeekdayLabel);
            ParsingGroupBox.Controls.Add(ParseButton);
            ParsingGroupBox.Controls.Add(WeekdayTextBox);
            ParsingGroupBox.Controls.Add(ParsingLabel);
            ParsingGroupBox.Location = new Point(0, 3);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(410, 173);
            ParsingGroupBox.TabIndex = 16;
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
            // WeekdayParsingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ParsingGroupBox);
            Name = "WeekdayParsingControl";
            Size = new Size(410, 175);
            ParsingGroupBox.ResumeLayout(false);
            ParsingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ParsingGroupBox;
        private Label WeekdayLabel;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label ParsingLabel;
    }
}
