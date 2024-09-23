namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemTab
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
            ItemAddButton = new Button();
            DeleteItemButton = new Button();
            ItemListListBox = new ListBox();
            ItemIdTextBox = new TextBox();
            ItemPriceTextBox = new TextBox();
            ItemsGroupBox = new GroupBox();
            ItemInfoRichTextBox = new RichTextBox();
            ItemNameRichTextBox = new RichTextBox();
            ItemInfoLabel = new Label();
            ItemNameLabel = new Label();
            ItemPriceLabel = new Label();
            ItemIdLabel = new Label();
            ItemsListGroupBox = new GroupBox();
            DeleteItemButtonPanel = new Panel();
            AddItemButtonPanel = new Panel();
            NewItemButtonPanel = new Panel();
            ItemSaveButton = new Button();
            ItemsGroupBox.SuspendLayout();
            ItemsListGroupBox.SuspendLayout();
            DeleteItemButtonPanel.SuspendLayout();
            AddItemButtonPanel.SuspendLayout();
            NewItemButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemAddButton
            // 
            ItemAddButton.Location = new Point(3, 3);
            ItemAddButton.Name = "ItemAddButton";
            ItemAddButton.Size = new Size(120, 45);
            ItemAddButton.TabIndex = 0;
            ItemAddButton.Text = "Add";
            ItemAddButton.UseVisualStyleBackColor = true;
            ItemAddButton.Click += ItemAddButton_Click;
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.Location = new Point(5, 3);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(120, 45);
            DeleteItemButton.TabIndex = 1;
            DeleteItemButton.Text = "Delete";
            DeleteItemButton.UseVisualStyleBackColor = true;
            DeleteItemButton.Click += DeleteItemButton_Click;
            // 
            // ItemListListBox
            // 
            ItemListListBox.FormattingEnabled = true;
            ItemListListBox.Location = new Point(6, 23);
            ItemListListBox.Name = "ItemListListBox";
            ItemListListBox.Size = new Size(389, 484);
            ItemListListBox.TabIndex = 2;
            ItemListListBox.SelectedIndexChanged += ItemListListBox_SelectedIndexChanged;
            // 
            // ItemIdTextBox
            // 
            ItemIdTextBox.Location = new Point(37, 35);
            ItemIdTextBox.Name = "ItemIdTextBox";
            ItemIdTextBox.ReadOnly = true;
            ItemIdTextBox.Size = new Size(265, 27);
            ItemIdTextBox.TabIndex = 4;
            // 
            // ItemPriceTextBox
            // 
            ItemPriceTextBox.Location = new Point(56, 81);
            ItemPriceTextBox.Name = "ItemPriceTextBox";
            ItemPriceTextBox.Size = new Size(246, 27);
            ItemPriceTextBox.TabIndex = 5;
            ItemPriceTextBox.TextChanged += ItemPriceTextBox_TextChanged;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.BackColor = SystemColors.ButtonHighlight;
            ItemsGroupBox.Controls.Add(ItemInfoRichTextBox);
            ItemsGroupBox.Controls.Add(ItemNameRichTextBox);
            ItemsGroupBox.Controls.Add(ItemInfoLabel);
            ItemsGroupBox.Controls.Add(ItemNameLabel);
            ItemsGroupBox.Controls.Add(ItemPriceLabel);
            ItemsGroupBox.Controls.Add(ItemIdLabel);
            ItemsGroupBox.Controls.Add(ItemIdTextBox);
            ItemsGroupBox.Controls.Add(ItemPriceTextBox);
            ItemsGroupBox.Location = new Point(410, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(435, 562);
            ItemsGroupBox.TabIndex = 7;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Selected Item:";
            // 
            // ItemInfoRichTextBox
            // 
            ItemInfoRichTextBox.Location = new Point(14, 314);
            ItemInfoRichTextBox.Name = "ItemInfoRichTextBox";
            ItemInfoRichTextBox.Size = new Size(288, 168);
            ItemInfoRichTextBox.TabIndex = 12;
            ItemInfoRichTextBox.Text = "";
            ItemInfoRichTextBox.TextChanged += ItemInfoRichTextBox_TextChanged;
            // 
            // ItemNameRichTextBox
            // 
            ItemNameRichTextBox.Location = new Point(14, 144);
            ItemNameRichTextBox.Name = "ItemNameRichTextBox";
            ItemNameRichTextBox.Size = new Size(290, 133);
            ItemNameRichTextBox.TabIndex = 11;
            ItemNameRichTextBox.Text = "";
            ItemNameRichTextBox.TextChanged += ItemNameRichTextBox_TextChanged;
            // 
            // ItemInfoLabel
            // 
            ItemInfoLabel.AutoSize = true;
            ItemInfoLabel.Location = new Point(14, 280);
            ItemInfoLabel.Name = "ItemInfoLabel";
            ItemInfoLabel.Size = new Size(38, 20);
            ItemInfoLabel.TabIndex = 10;
            ItemInfoLabel.Text = "Info:";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(6, 121);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(52, 20);
            ItemNameLabel.TabIndex = 9;
            ItemNameLabel.Text = "Name:";
            // 
            // ItemPriceLabel
            // 
            ItemPriceLabel.AutoSize = true;
            ItemPriceLabel.Location = new Point(6, 81);
            ItemPriceLabel.Name = "ItemPriceLabel";
            ItemPriceLabel.Size = new Size(44, 20);
            ItemPriceLabel.TabIndex = 8;
            ItemPriceLabel.Text = "Price:";
            // 
            // ItemIdLabel
            // 
            ItemIdLabel.AutoSize = true;
            ItemIdLabel.Location = new Point(6, 35);
            ItemIdLabel.Name = "ItemIdLabel";
            ItemIdLabel.Size = new Size(25, 20);
            ItemIdLabel.TabIndex = 7;
            ItemIdLabel.Text = "Id:";
            // 
            // ItemsListGroupBox
            // 
            ItemsListGroupBox.Controls.Add(ItemListListBox);
            ItemsListGroupBox.Location = new Point(3, 3);
            ItemsListGroupBox.Name = "ItemsListGroupBox";
            ItemsListGroupBox.Size = new Size(401, 507);
            ItemsListGroupBox.TabIndex = 8;
            ItemsListGroupBox.TabStop = false;
            ItemsListGroupBox.Text = "Items";
            // 
            // DeleteItemButtonPanel
            // 
            DeleteItemButtonPanel.Controls.Add(DeleteItemButton);
            DeleteItemButtonPanel.Location = new Point(15, 513);
            DeleteItemButtonPanel.Name = "DeleteItemButtonPanel";
            DeleteItemButtonPanel.Size = new Size(127, 52);
            DeleteItemButtonPanel.TabIndex = 9;
            // 
            // AddItemButtonPanel
            // 
            AddItemButtonPanel.Controls.Add(ItemAddButton);
            AddItemButtonPanel.Location = new Point(143, 513);
            AddItemButtonPanel.Name = "AddItemButtonPanel";
            AddItemButtonPanel.Size = new Size(127, 52);
            AddItemButtonPanel.TabIndex = 10;
            // 
            // NewItemButtonPanel
            // 
            NewItemButtonPanel.Controls.Add(ItemSaveButton);
            NewItemButtonPanel.Location = new Point(271, 513);
            NewItemButtonPanel.Name = "NewItemButtonPanel";
            NewItemButtonPanel.Size = new Size(127, 52);
            NewItemButtonPanel.TabIndex = 11;
            // 
            // ItemSaveButton
            // 
            ItemSaveButton.Location = new Point(4, 4);
            ItemSaveButton.Name = "ItemSaveButton";
            ItemSaveButton.Size = new Size(120, 45);
            ItemSaveButton.TabIndex = 0;
            ItemSaveButton.Text = "Save";
            ItemSaveButton.UseVisualStyleBackColor = true;
            ItemSaveButton.Click += ItemSaveButton_Click;
            // 
            // ItemTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NewItemButtonPanel);
            Controls.Add(AddItemButtonPanel);
            Controls.Add(DeleteItemButtonPanel);
            Controls.Add(ItemsListGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemTab";
            Size = new Size(860, 600);
            ItemsGroupBox.ResumeLayout(false);
            ItemsGroupBox.PerformLayout();
            ItemsListGroupBox.ResumeLayout(false);
            DeleteItemButtonPanel.ResumeLayout(false);
            AddItemButtonPanel.ResumeLayout(false);
            NewItemButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ItemAddButton;
        private Button DeleteItemButton;
        private ListBox ItemListListBox;
        private TextBox ItemIdTextBox;
        private TextBox ItemPriceTextBox;
        private GroupBox ItemsGroupBox;
        private GroupBox ItemsListGroupBox;
        private Label ItemPriceLabel;
        private Label ItemIdLabel;
        private Label ItemInfoLabel;
        private Label ItemNameLabel;
        private RichTextBox ItemInfoRichTextBox;
        private RichTextBox ItemNameRichTextBox;
        private Panel DeleteItemButtonPanel;
        private Panel AddItemButtonPanel;
        private Panel NewItemButtonPanel;
        private Button ItemSaveButton;
    }
}
