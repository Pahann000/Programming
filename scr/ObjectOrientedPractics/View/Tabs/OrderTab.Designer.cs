namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrderTab
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
            components = new System.ComponentModel.Container();
            Address address1 = new Address();
            AmountTextBox = new TextBox();
            TotalAmountLabel = new Label();
            CartItemsListBox = new ListBox();
            OrdersInfoGroupBox = new GroupBox();
            CustomerOrderAddressControl = new Controls.CustomerAddressControl();
            OrderStatusLabel = new Label();
            OrderStatusComboBox = new ComboBox();
            OrderTimeTextBox = new TextBox();
            OrderIdTextBox = new TextBox();
            OrderDateTimeLabel = new Label();
            OrderIdLabel = new Label();
            OrdersDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            OrderDataBindingSourse = new BindingSource(components);
            OrdersInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderDataBindingSourse).BeginInit();
            SuspendLayout();
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(679, 410);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(153, 27);
            AmountTextBox.TabIndex = 24;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Location = new Point(767, 387);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(65, 20);
            TotalAmountLabel.TabIndex = 23;
            TotalAmountLabel.Text = "Amount:";
            // 
            // CartItemsListBox
            // 
            CartItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CartItemsListBox.FormattingEnabled = true;
            CartItemsListBox.Location = new Point(385, 443);
            CartItemsListBox.Name = "CartItemsListBox";
            CartItemsListBox.Size = new Size(447, 144);
            CartItemsListBox.TabIndex = 2;
            // 
            // OrdersInfoGroupBox
            // 
            OrdersInfoGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersInfoGroupBox.BackColor = SystemColors.ButtonHighlight;
            OrdersInfoGroupBox.Controls.Add(CustomerOrderAddressControl);
            OrdersInfoGroupBox.Controls.Add(OrderStatusLabel);
            OrdersInfoGroupBox.Controls.Add(OrderStatusComboBox);
            OrdersInfoGroupBox.Controls.Add(OrderTimeTextBox);
            OrdersInfoGroupBox.Controls.Add(OrderIdTextBox);
            OrdersInfoGroupBox.Controls.Add(OrderDateTimeLabel);
            OrdersInfoGroupBox.Controls.Add(OrderIdLabel);
            OrdersInfoGroupBox.Location = new Point(379, 11);
            OrdersInfoGroupBox.Name = "OrdersInfoGroupBox";
            OrdersInfoGroupBox.Size = new Size(464, 360);
            OrdersInfoGroupBox.TabIndex = 20;
            OrdersInfoGroupBox.TabStop = false;
            OrdersInfoGroupBox.Text = "Select order:";
            // 
            // CustomerOrderAddressControl
            // 
            address1.Apartment = "507";
            address1.Building = "18";
            address1.City = "Tomsk";
            address1.Country = "Russia";
            address1.Index = 100001;
            address1.Street = "F. Lytkin st.";
            CustomerOrderAddressControl.Address = address1;
            CustomerOrderAddressControl.Location = new Point(6, 137);
            CustomerOrderAddressControl.Name = "CustomerOrderAddressControl";
            CustomerOrderAddressControl.Size = new Size(457, 227);
            CustomerOrderAddressControl.TabIndex = 22;
            // 
            // OrderStatusLabel
            // 
            OrderStatusLabel.AutoSize = true;
            OrderStatusLabel.Location = new Point(6, 103);
            OrderStatusLabel.Name = "OrderStatusLabel";
            OrderStatusLabel.Size = new Size(52, 20);
            OrderStatusLabel.TabIndex = 21;
            OrderStatusLabel.Text = "Status:";
            // 
            // OrderStatusComboBox
            // 
            OrderStatusComboBox.FormattingEnabled = true;
            OrderStatusComboBox.Location = new Point(64, 103);
            OrderStatusComboBox.Name = "OrderStatusComboBox";
            OrderStatusComboBox.Size = new Size(151, 28);
            OrderStatusComboBox.TabIndex = 20;
            // 
            // OrderTimeTextBox
            // 
            OrderTimeTextBox.Location = new Point(76, 59);
            OrderTimeTextBox.Name = "OrderTimeTextBox";
            OrderTimeTextBox.Size = new Size(125, 27);
            OrderTimeTextBox.TabIndex = 19;
            // 
            // OrderIdTextBox
            // 
            OrderIdTextBox.Location = new Point(37, 26);
            OrderIdTextBox.Name = "OrderIdTextBox";
            OrderIdTextBox.ReadOnly = true;
            OrderIdTextBox.Size = new Size(125, 27);
            OrderIdTextBox.TabIndex = 18;
            // 
            // OrderDateTimeLabel
            // 
            OrderDateTimeLabel.AutoSize = true;
            OrderDateTimeLabel.Location = new Point(6, 59);
            OrderDateTimeLabel.Name = "OrderDateTimeLabel";
            OrderDateTimeLabel.Size = new Size(64, 20);
            OrderDateTimeLabel.TabIndex = 17;
            OrderDateTimeLabel.Text = "Created:";
            // 
            // OrderIdLabel
            // 
            OrderIdLabel.AutoSize = true;
            OrderIdLabel.Location = new Point(6, 26);
            OrderIdLabel.Name = "OrderIdLabel";
            OrderIdLabel.Size = new Size(25, 20);
            OrderIdLabel.TabIndex = 14;
            OrderIdLabel.Text = "Id:";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AutoGenerateColumns = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, orderDataGridViewTextBoxColumn });
            OrdersDataGridView.DataSource = OrderDataBindingSourse;
            OrdersDataGridView.Location = new Point(9, 11);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.Size = new Size(370, 556);
            OrdersDataGridView.TabIndex = 25;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            orderDataGridViewTextBoxColumn.HeaderText = "Order";
            orderDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            orderDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrderDataBindingSourse
            // 
            OrderDataBindingSourse.DataSource = typeof(OrdersFullData);
            // 
            // OrderTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrdersDataGridView);
            Controls.Add(CartItemsListBox);
            Controls.Add(AmountTextBox);
            Controls.Add(TotalAmountLabel);
            Controls.Add(OrdersInfoGroupBox);
            Name = "OrderTab";
            Size = new Size(860, 600);
            OrdersInfoGroupBox.ResumeLayout(false);
            OrdersInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderDataBindingSourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox AmountTextBox;
        private Label TotalAmountLabel;
        private ListBox CartItemsListBox;
        private GroupBox OrdersInfoGroupBox;
        private Label OrderDateTimeLabel;
        private Label OrderIdLabel;
        private ComboBox OrderStatusComboBox;
        private TextBox OrderTimeTextBox;
        private TextBox OrderIdTextBox;
        private Label OrderStatusLabel;
        private Controls.CustomerAddressControl CustomerOrderAddressControl;
        private DataGridView OrdersDataGridView;
        private BindingSource OrderDataBindingSourse;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
    }
}
