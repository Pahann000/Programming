namespace Programming.View.UserControls
{
    partial class SeasonHandlesControl
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
            SeasonGroupBox = new GroupBox();
            SeasonLabel = new Label();
            SeasonComboBox = new ComboBox();
            SeasonButton = new Button();
            SeasonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Controls.Add(SeasonButton);
            SeasonGroupBox.Location = new Point(3, 3);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(401, 172);
            SeasonGroupBox.TabIndex = 18;
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
            SeasonButton.Click += GoButton_Click;
            // 
            // SeasonHandlesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonGroupBox);
            Name = "SeasonHandlesControl";
            Size = new Size(413, 182);
            Load += SeasonHandlesControl_Load;
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox SeasonGroupBox;
        private Label SeasonLabel;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
    }
}
