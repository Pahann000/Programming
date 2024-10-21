namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartTab
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
            CartItemsListGroupBox = new GroupBox();
            ItemsListBox = new ListBox();
            CustomerCartGroupBox = new GroupBox();
            CartItemLabel = new Label();
            CartItemsListBox = new ListBox();
            CustomerNameComboBox = new ComboBox();
            CustomerNameLabel = new Label();
            ClearCartButton = new Button();
            TotalAmountLabel = new Label();
            AmountTextBox = new TextBox();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            AddItemToCartButton = new Button();
            CartItemsListGroupBox.SuspendLayout();
            CustomerCartGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CartItemsListGroupBox
            // 
            CartItemsListGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CartItemsListGroupBox.Controls.Add(ItemsListBox);
            CartItemsListGroupBox.Location = new Point(3, 1);
            CartItemsListGroupBox.Name = "CartItemsListGroupBox";
            CartItemsListGroupBox.Size = new Size(274, 527);
            CartItemsListGroupBox.TabIndex = 13;
            CartItemsListGroupBox.TabStop = false;
            CartItemsListGroupBox.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(6, 26);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(255, 464);
            ItemsListBox.TabIndex = 2;
            // 
            // CustomerCartGroupBox
            // 
            CustomerCartGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerCartGroupBox.BackColor = SystemColors.ButtonHighlight;
            CustomerCartGroupBox.Controls.Add(CartItemLabel);
            CustomerCartGroupBox.Controls.Add(CartItemsListBox);
            CustomerCartGroupBox.Controls.Add(CustomerNameComboBox);
            CustomerCartGroupBox.Controls.Add(CustomerNameLabel);
            CustomerCartGroupBox.Location = new Point(283, 1);
            CustomerCartGroupBox.Name = "CustomerCartGroupBox";
            CustomerCartGroupBox.Size = new Size(556, 278);
            CustomerCartGroupBox.TabIndex = 12;
            CustomerCartGroupBox.TabStop = false;
            CustomerCartGroupBox.Text = "Select customer:";
            // 
            // CartItemLabel
            // 
            CartItemLabel.AutoSize = true;
            CartItemLabel.Location = new Point(6, 97);
            CartItemLabel.Name = "CartItemLabel";
            CartItemLabel.Size = new Size(39, 20);
            CartItemLabel.TabIndex = 17;
            CartItemLabel.Text = "Cart:";
            // 
            // CartItemsListBox
            // 
            CartItemsListBox.FormattingEnabled = true;
            CartItemsListBox.Location = new Point(6, 120);
            CartItemsListBox.Name = "CartItemsListBox";
            CartItemsListBox.Size = new Size(544, 124);
            CartItemsListBox.TabIndex = 16;
            // 
            // CustomerNameComboBox
            // 
            CustomerNameComboBox.FormattingEnabled = true;
            CustomerNameComboBox.Location = new Point(84, 50);
            CustomerNameComboBox.Name = "CustomerNameComboBox";
            CustomerNameComboBox.Size = new Size(363, 28);
            CustomerNameComboBox.TabIndex = 15;
            CustomerNameComboBox.SelectedIndexChanged += CustomerNameComboBox_SelectedIndexChanged;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(6, 53);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(75, 20);
            CustomerNameLabel.TabIndex = 14;
            CustomerNameLabel.Text = "Customer:";
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(727, 352);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(112, 45);
            ClearCartButton.TabIndex = 14;
            ClearCartButton.Text = "ClearCart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Location = new Point(774, 286);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(65, 20);
            TotalAmountLabel.TabIndex = 15;
            TotalAmountLabel.Text = "Amount:";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(686, 309);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(153, 27);
            AmountTextBox.TabIndex = 16;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(289, 352);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(112, 45);
            CreateOrderButton.TabIndex = 17;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(510, 352);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(112, 45);
            RemoveItemButton.TabIndex = 18;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemToCartButton
            // 
            AddItemToCartButton.Location = new Point(165, 534);
            AddItemToCartButton.Name = "AddItemToCartButton";
            AddItemToCartButton.Size = new Size(112, 45);
            AddItemToCartButton.TabIndex = 19;
            AddItemToCartButton.Text = "Add Item";
            AddItemToCartButton.UseVisualStyleBackColor = true;
            AddItemToCartButton.Click += AddItemToCartButton_Click;
            // 
            // CartTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddItemToCartButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(CreateOrderButton);
            Controls.Add(AmountTextBox);
            Controls.Add(TotalAmountLabel);
            Controls.Add(ClearCartButton);
            Controls.Add(CartItemsListGroupBox);
            Controls.Add(CustomerCartGroupBox);
            Name = "CartTab";
            Size = new Size(860, 600);
            CartItemsListGroupBox.ResumeLayout(false);
            CustomerCartGroupBox.ResumeLayout(false);
            CustomerCartGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ItemAddButton;
        private Button DeleteItemButton;
        private Button ItemSaveButton;
        private GroupBox CartItemsListGroupBox;
        private ListBox ItemsListBox;
        private GroupBox CustomerCartGroupBox;
        private ComboBox CustomerNameComboBox;
        private Label CustomerNameLabel;
        private Label ItemNameLabel;
        private TextBox ItemPriceTextBox;
        private ListBox CartItemsListBox;
        private Button ClearCartButton;
        private Label TotalAmountLabel;
        private TextBox AmountTextBox;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private Button AddItemToCartButton;
        private Label CartItemLabel;
    }
}
