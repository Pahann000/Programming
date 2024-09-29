namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
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
            AddCustomerButton = new Button();
            DeleteCustomerButton = new Button();
            CustomerListGroupBox = new GroupBox();
            CustomerListListBox = new ListBox();
            CustomersGroupBox = new GroupBox();
            CustomerAddressRichTextBox = new RichTextBox();
            CustomerAddressLabel = new Label();
            CustomerFullNameLabel = new Label();
            CustomerIdLabel = new Label();
            CustomerIdTextBox = new TextBox();
            CustomerNameTextBox = new TextBox();
            CustomerSaveButton = new Button();
            CustomerListGroupBox.SuspendLayout();
            CustomersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCustomerButton.Location = new Point(261, 516);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(120, 45);
            AddCustomerButton.TabIndex = 0;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // DeleteCustomerButton
            // 
            DeleteCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteCustomerButton.Location = new Point(135, 516);
            DeleteCustomerButton.Name = "DeleteCustomerButton";
            DeleteCustomerButton.Size = new Size(120, 45);
            DeleteCustomerButton.TabIndex = 1;
            DeleteCustomerButton.Text = "Delete";
            DeleteCustomerButton.UseVisualStyleBackColor = true;
            DeleteCustomerButton.Click += DeleteCustomerButton_Click;
            // 
            // CustomerListGroupBox
            // 
            CustomerListGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomerListGroupBox.Controls.Add(CustomerListListBox);
            CustomerListGroupBox.Location = new Point(3, 3);
            CustomerListGroupBox.Name = "CustomerListGroupBox";
            CustomerListGroupBox.Size = new Size(401, 507);
            CustomerListGroupBox.TabIndex = 13;
            CustomerListGroupBox.TabStop = false;
            CustomerListGroupBox.Text = "Costumers";
            // 
            // CustomerListListBox
            // 
            CustomerListListBox.FormattingEnabled = true;
            CustomerListListBox.Location = new Point(6, 26);
            CustomerListListBox.Name = "CustomerListListBox";
            CustomerListListBox.Size = new Size(389, 464);
            CustomerListListBox.TabIndex = 2;
            CustomerListListBox.SelectedIndexChanged += CustomerListListBox_SelectedIndexChanged;
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersGroupBox.BackColor = SystemColors.ButtonHighlight;
            CustomersGroupBox.Controls.Add(CustomerAddressRichTextBox);
            CustomersGroupBox.Controls.Add(CustomerAddressLabel);
            CustomersGroupBox.Controls.Add(CustomerFullNameLabel);
            CustomersGroupBox.Controls.Add(CustomerIdLabel);
            CustomersGroupBox.Controls.Add(CustomerIdTextBox);
            CustomersGroupBox.Controls.Add(CustomerNameTextBox);
            CustomersGroupBox.Location = new Point(410, 14);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(447, 299);
            CustomersGroupBox.TabIndex = 12;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Selected Customer:";
            // 
            // CustomerAddressRichTextBox
            // 
            CustomerAddressRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerAddressRichTextBox.Location = new Point(6, 133);
            CustomerAddressRichTextBox.Name = "CustomerAddressRichTextBox";
            CustomerAddressRichTextBox.Size = new Size(435, 153);
            CustomerAddressRichTextBox.TabIndex = 11;
            CustomerAddressRichTextBox.Text = "";
            CustomerAddressRichTextBox.TextChanged += CustomerAddressRichTextBox_TextChanged;
            // 
            // CustomerAddressLabel
            // 
            CustomerAddressLabel.AutoSize = true;
            CustomerAddressLabel.Location = new Point(6, 110);
            CustomerAddressLabel.Name = "CustomerAddressLabel";
            CustomerAddressLabel.Size = new Size(65, 20);
            CustomerAddressLabel.TabIndex = 9;
            CustomerAddressLabel.Text = "Address:";
            // 
            // CustomerFullNameLabel
            // 
            CustomerFullNameLabel.AutoSize = true;
            CustomerFullNameLabel.Location = new Point(6, 72);
            CustomerFullNameLabel.Name = "CustomerFullNameLabel";
            CustomerFullNameLabel.Size = new Size(75, 20);
            CustomerFullNameLabel.TabIndex = 8;
            CustomerFullNameLabel.Text = "FullName:";
            // 
            // CustomerIdLabel
            // 
            CustomerIdLabel.AutoSize = true;
            CustomerIdLabel.Location = new Point(6, 34);
            CustomerIdLabel.Name = "CustomerIdLabel";
            CustomerIdLabel.Size = new Size(25, 20);
            CustomerIdLabel.TabIndex = 7;
            CustomerIdLabel.Text = "Id:";
            // 
            // CustomerIdTextBox
            // 
            CustomerIdTextBox.Location = new Point(87, 26);
            CustomerIdTextBox.Name = "CustomerIdTextBox";
            CustomerIdTextBox.ReadOnly = true;
            CustomerIdTextBox.Size = new Size(125, 27);
            CustomerIdTextBox.TabIndex = 4;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerNameTextBox.Location = new Point(87, 72);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(263, 27);
            CustomerNameTextBox.TabIndex = 5;
            CustomerNameTextBox.TextChanged += CustomerNameTextBox_TextChanged;
            // 
            // CustomerSaveButton
            // 
            CustomerSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CustomerSaveButton.Location = new Point(9, 516);
            CustomerSaveButton.Name = "CustomerSaveButton";
            CustomerSaveButton.Size = new Size(120, 45);
            CustomerSaveButton.TabIndex = 0;
            CustomerSaveButton.Text = "Save";
            CustomerSaveButton.UseVisualStyleBackColor = true;
            CustomerSaveButton.Click += CustomerSaveButton_Click;
            // 
            // CustomerTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomerSaveButton);
            Controls.Add(DeleteCustomerButton);
            Controls.Add(AddCustomerButton);
            Controls.Add(CustomerListGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomerTab";
            Size = new Size(860, 600);
            CustomerListGroupBox.ResumeLayout(false);
            CustomersGroupBox.ResumeLayout(false);
            CustomersGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button AddCustomerButton;
        private Button DeleteCustomerButton;
        private GroupBox CustomerListGroupBox;
        private ListBox CustomerListListBox;
        private GroupBox CustomersGroupBox;
        private RichTextBox CustomerAddressRichTextBox;
        private Label CustomerAddressLabel;
        private Label CustomerFullNameLabel;
        private Label CustomerIdLabel;
        private TextBox CustomerIdTextBox;
        private TextBox CustomerNameTextBox;
        private Button CustomerSaveButton;
    }
}
