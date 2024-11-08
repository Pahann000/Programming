namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            Address address1 = new Address();
            PrOrderCartItemsListBox = new ListBox();
            PrOrderAmountTextBox = new TextBox();
            TotalAmountLabel = new Label();
            ClearOrderPrOrderTextBox = new Button();
            AddItemPrOrderTextBox = new Button();
            RemoveItemPrOrderTextBox = new Button();
            OrdersInfoGroupBox = new GroupBox();
            PriorityOrderLabel1 = new Label();
            PriorityOrderComboBox = new ComboBox();
            PriorityOrderAddressControl = new Controls.CustomerAddressControl();
            PrOrderStatusLabel = new Label();
            PrOrderStatusComboBox = new ComboBox();
            PrOrderTimeTextBox = new TextBox();
            PrOrderIdTextBox = new TextBox();
            PrOrderDateTimeLabel = new Label();
            PrOrderIdLabel = new Label();
            OrdersInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // PrOrderCartItemsListBox
            // 
            PrOrderCartItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PrOrderCartItemsListBox.FormattingEnabled = true;
            PrOrderCartItemsListBox.Location = new Point(9, 373);
            PrOrderCartItemsListBox.Name = "PrOrderCartItemsListBox";
            PrOrderCartItemsListBox.Size = new Size(447, 124);
            PrOrderCartItemsListBox.TabIndex = 41;
            // 
            // PrOrderAmountTextBox
            // 
            PrOrderAmountTextBox.Location = new Point(484, 406);
            PrOrderAmountTextBox.Name = "PrOrderAmountTextBox";
            PrOrderAmountTextBox.Size = new Size(153, 27);
            PrOrderAmountTextBox.TabIndex = 44;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Location = new Point(575, 386);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(65, 20);
            TotalAmountLabel.TabIndex = 43;
            TotalAmountLabel.Text = "Amount:";
            // 
            // ClearOrderPrOrderTextBox
            // 
            ClearOrderPrOrderTextBox.Location = new Point(525, 444);
            ClearOrderPrOrderTextBox.Name = "ClearOrderPrOrderTextBox";
            ClearOrderPrOrderTextBox.Size = new Size(112, 45);
            ClearOrderPrOrderTextBox.TabIndex = 40;
            ClearOrderPrOrderTextBox.Text = "Clear Order";
            ClearOrderPrOrderTextBox.UseVisualStyleBackColor = true;
            ClearOrderPrOrderTextBox.Click += ClearOrderPrOrderTextBox_Click;
            // 
            // AddItemPrOrderTextBox
            // 
            AddItemPrOrderTextBox.Location = new Point(9, 503);
            AddItemPrOrderTextBox.Name = "AddItemPrOrderTextBox";
            AddItemPrOrderTextBox.Size = new Size(112, 45);
            AddItemPrOrderTextBox.TabIndex = 39;
            AddItemPrOrderTextBox.Text = "Add Item";
            AddItemPrOrderTextBox.UseVisualStyleBackColor = true;
            AddItemPrOrderTextBox.Click += AddItemPrOrderTextBox_Click;
            // 
            // RemoveItemPrOrderTextBox
            // 
            RemoveItemPrOrderTextBox.Location = new Point(136, 503);
            RemoveItemPrOrderTextBox.Name = "RemoveItemPrOrderTextBox";
            RemoveItemPrOrderTextBox.Size = new Size(112, 45);
            RemoveItemPrOrderTextBox.TabIndex = 38;
            RemoveItemPrOrderTextBox.Text = "Remove Item";
            RemoveItemPrOrderTextBox.UseVisualStyleBackColor = true;
            RemoveItemPrOrderTextBox.Click += RemoveItemPrOrderTextBox_Click;
            // 
            // OrdersInfoGroupBox
            // 
            OrdersInfoGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersInfoGroupBox.BackColor = SystemColors.ButtonHighlight;
            OrdersInfoGroupBox.Controls.Add(PriorityOrderLabel1);
            OrdersInfoGroupBox.Controls.Add(PriorityOrderComboBox);
            OrdersInfoGroupBox.Controls.Add(PriorityOrderAddressControl);
            OrdersInfoGroupBox.Controls.Add(PrOrderStatusLabel);
            OrdersInfoGroupBox.Controls.Add(PrOrderStatusComboBox);
            OrdersInfoGroupBox.Controls.Add(PrOrderTimeTextBox);
            OrdersInfoGroupBox.Controls.Add(PrOrderIdTextBox);
            OrdersInfoGroupBox.Controls.Add(PrOrderDateTimeLabel);
            OrdersInfoGroupBox.Controls.Add(PrOrderIdLabel);
            OrdersInfoGroupBox.Location = new Point(3, 3);
            OrdersInfoGroupBox.Name = "OrdersInfoGroupBox";
            OrdersInfoGroupBox.Size = new Size(664, 364);
            OrdersInfoGroupBox.TabIndex = 45;
            OrdersInfoGroupBox.TabStop = false;
            OrdersInfoGroupBox.Text = "Select order:";
            // 
            // PriorityOrderLabel1
            // 
            PriorityOrderLabel1.AutoSize = true;
            PriorityOrderLabel1.Location = new Point(495, 16);
            PriorityOrderLabel1.Name = "PriorityOrderLabel1";
            PriorityOrderLabel1.Size = new Size(115, 20);
            PriorityOrderLabel1.TabIndex = 24;
            PriorityOrderLabel1.Text = "Priority Options:";
            // 
            // PriorityOrderComboBox
            // 
            PriorityOrderComboBox.FormattingEnabled = true;
            PriorityOrderComboBox.Location = new Point(495, 39);
            PriorityOrderComboBox.Name = "PriorityOrderComboBox";
            PriorityOrderComboBox.Size = new Size(151, 28);
            PriorityOrderComboBox.TabIndex = 23;
            // 
            // PriorityOrderAddressControl
            // 
            address1.Apartment = "507";
            address1.Building = "18";
            address1.City = "Tomsk";
            address1.Country = "Russia";
            address1.Index = 100001;
            address1.Street = "F. Lytkin st.";
            PriorityOrderAddressControl.Address = address1;
            PriorityOrderAddressControl.Location = new Point(6, 137);
            PriorityOrderAddressControl.Name = "PriorityOrderAddressControl";
            PriorityOrderAddressControl.Size = new Size(457, 227);
            PriorityOrderAddressControl.TabIndex = 22;
            // 
            // PrOrderStatusLabel
            // 
            PrOrderStatusLabel.AutoSize = true;
            PrOrderStatusLabel.Location = new Point(6, 103);
            PrOrderStatusLabel.Name = "PrOrderStatusLabel";
            PrOrderStatusLabel.Size = new Size(52, 20);
            PrOrderStatusLabel.TabIndex = 21;
            PrOrderStatusLabel.Text = "Status:";
            // 
            // PrOrderStatusComboBox
            // 
            PrOrderStatusComboBox.FormattingEnabled = true;
            PrOrderStatusComboBox.Location = new Point(64, 103);
            PrOrderStatusComboBox.Name = "PrOrderStatusComboBox";
            PrOrderStatusComboBox.Size = new Size(151, 28);
            PrOrderStatusComboBox.TabIndex = 20;
            // 
            // PrOrderTimeTextBox
            // 
            PrOrderTimeTextBox.Location = new Point(76, 59);
            PrOrderTimeTextBox.Name = "PrOrderTimeTextBox";
            PrOrderTimeTextBox.ReadOnly = true;
            PrOrderTimeTextBox.Size = new Size(125, 27);
            PrOrderTimeTextBox.TabIndex = 19;
            // 
            // PrOrderIdTextBox
            // 
            PrOrderIdTextBox.Location = new Point(37, 26);
            PrOrderIdTextBox.Name = "PrOrderIdTextBox";
            PrOrderIdTextBox.ReadOnly = true;
            PrOrderIdTextBox.Size = new Size(125, 27);
            PrOrderIdTextBox.TabIndex = 18;
            // 
            // PrOrderDateTimeLabel
            // 
            PrOrderDateTimeLabel.AutoSize = true;
            PrOrderDateTimeLabel.Location = new Point(6, 59);
            PrOrderDateTimeLabel.Name = "PrOrderDateTimeLabel";
            PrOrderDateTimeLabel.Size = new Size(64, 20);
            PrOrderDateTimeLabel.TabIndex = 17;
            PrOrderDateTimeLabel.Text = "Created:";
            // 
            // PrOrderIdLabel
            // 
            PrOrderIdLabel.AutoSize = true;
            PrOrderIdLabel.Location = new Point(6, 26);
            PrOrderIdLabel.Name = "PrOrderIdLabel";
            PrOrderIdLabel.Size = new Size(25, 20);
            PrOrderIdLabel.TabIndex = 14;
            PrOrderIdLabel.Text = "Id:";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrdersInfoGroupBox);
            Controls.Add(PrOrderCartItemsListBox);
            Controls.Add(PrOrderAmountTextBox);
            Controls.Add(TotalAmountLabel);
            Controls.Add(ClearOrderPrOrderTextBox);
            Controls.Add(AddItemPrOrderTextBox);
            Controls.Add(RemoveItemPrOrderTextBox);
            Name = "PriorityOrdersTab";
            Size = new Size(685, 552);
            Load += PriorityOrdersTab_Load;
            OrdersInfoGroupBox.ResumeLayout(false);
            OrdersInfoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PrOrderCartItemsListBox;
        private TextBox PrOrderAmountTextBox;
        private Label TotalAmountLabel;
        private Button ClearOrderPrOrderTextBox;
        private Button AddItemPrOrderTextBox;
        private Button RemoveItemPrOrderTextBox;
        private GroupBox OrdersInfoGroupBox;
        private Label PriorityOrderLabel1;
        private ComboBox PriorityOrderComboBox;
        private Controls.CustomerAddressControl PriorityOrderAddressControl;
        private Label PrOrderStatusLabel;
        private ComboBox PrOrderStatusComboBox;
        private TextBox PrOrderTimeTextBox;
        private TextBox PrOrderIdTextBox;
        private Label PrOrderDateTimeLabel;
        private Label PrOrderIdLabel;
    }
}
