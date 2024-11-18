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
            DeleteItemButton = new Button();
            ItemListListBox = new ListBox();
            ItemIdTextBox = new TextBox();
            ItemPriceTextBox = new TextBox();
            ItemsGroupBox = new GroupBox();
            ItemCategoryComboBox = new ComboBox();
            ItemCategoryLabel = new Label();
            ItemInfoRichTextBox = new RichTextBox();
            ItemNameRichTextBox = new RichTextBox();
            ItemInfoLabel = new Label();
            ItemNameLabel = new Label();
            ItemPriceLabel = new Label();
            ItemIdLabel = new Label();
            ItemsListGroupBox = new GroupBox();
            ItemSaveButton = new Button();
            ItemAddButton = new Button();
            FindTextBox = new TextBox();
            FindLabel = new Label();
            SortComboBox = new ComboBox();
            OrderByLabel = new Label();
            ItemsGroupBox.SuspendLayout();
            ItemsListGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteItemButton.Location = new Point(9, 516);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(120, 45);
            DeleteItemButton.TabIndex = 1;
            DeleteItemButton.Text = "Delete";
            DeleteItemButton.UseVisualStyleBackColor = true;
            DeleteItemButton.Click += DeleteItemButton_Click;
            // 
            // ItemListListBox
            // 
            ItemListListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemListListBox.FormattingEnabled = true;
            ItemListListBox.Location = new Point(6, 26);
            ItemListListBox.Name = "ItemListListBox";
            ItemListListBox.Size = new Size(389, 324);
            ItemListListBox.TabIndex = 2;
            ItemListListBox.SelectedIndexChanged += ItemListListBox_SelectedIndexChanged;
            // 
            // ItemIdTextBox
            // 
            ItemIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemIdTextBox.Location = new Point(37, 35);
            ItemIdTextBox.Name = "ItemIdTextBox";
            ItemIdTextBox.ReadOnly = true;
            ItemIdTextBox.Size = new Size(265, 27);
            ItemIdTextBox.TabIndex = 4;
            // 
            // ItemPriceTextBox
            // 
            ItemPriceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemPriceTextBox.Location = new Point(56, 81);
            ItemPriceTextBox.Name = "ItemPriceTextBox";
            ItemPriceTextBox.Size = new Size(246, 27);
            ItemPriceTextBox.TabIndex = 5;
            ItemPriceTextBox.TextChanged += ItemPriceTextBox_TextChanged;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsGroupBox.BackColor = SystemColors.ButtonHighlight;
            ItemsGroupBox.Controls.Add(ItemCategoryComboBox);
            ItemsGroupBox.Controls.Add(ItemCategoryLabel);
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
            // ItemCategoryComboBox
            // 
            ItemCategoryComboBox.FormattingEnabled = true;
            ItemCategoryComboBox.Location = new Point(86, 136);
            ItemCategoryComboBox.Name = "ItemCategoryComboBox";
            ItemCategoryComboBox.Size = new Size(218, 28);
            ItemCategoryComboBox.TabIndex = 15;
            ItemCategoryComboBox.SelectedIndexChanged += ItemCategoryComboBox_SelectedIndexChanged;
            // 
            // ItemCategoryLabel
            // 
            ItemCategoryLabel.AutoSize = true;
            ItemCategoryLabel.Location = new Point(6, 136);
            ItemCategoryLabel.Name = "ItemCategoryLabel";
            ItemCategoryLabel.Size = new Size(72, 20);
            ItemCategoryLabel.TabIndex = 14;
            ItemCategoryLabel.Text = "Category:";
            // 
            // ItemInfoRichTextBox
            // 
            ItemInfoRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemInfoRichTextBox.Location = new Point(14, 367);
            ItemInfoRichTextBox.Name = "ItemInfoRichTextBox";
            ItemInfoRichTextBox.Size = new Size(402, 168);
            ItemInfoRichTextBox.TabIndex = 12;
            ItemInfoRichTextBox.Text = "";
            ItemInfoRichTextBox.TextChanged += ItemInfoRichTextBox_TextChanged;
            // 
            // ItemNameRichTextBox
            // 
            ItemNameRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemNameRichTextBox.Location = new Point(14, 196);
            ItemNameRichTextBox.Name = "ItemNameRichTextBox";
            ItemNameRichTextBox.Size = new Size(402, 133);
            ItemNameRichTextBox.TabIndex = 11;
            ItemNameRichTextBox.Text = "";
            ItemNameRichTextBox.TextChanged += ItemNameRichTextBox_TextChanged;
            // 
            // ItemInfoLabel
            // 
            ItemInfoLabel.AutoSize = true;
            ItemInfoLabel.Location = new Point(6, 344);
            ItemInfoLabel.Name = "ItemInfoLabel";
            ItemInfoLabel.Size = new Size(38, 20);
            ItemInfoLabel.TabIndex = 10;
            ItemInfoLabel.Text = "Info:";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(6, 173);
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
            ItemsListGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListGroupBox.Controls.Add(ItemListListBox);
            ItemsListGroupBox.Location = new Point(9, 52);
            ItemsListGroupBox.Name = "ItemsListGroupBox";
            ItemsListGroupBox.Size = new Size(401, 376);
            ItemsListGroupBox.TabIndex = 8;
            ItemsListGroupBox.TabStop = false;
            ItemsListGroupBox.Text = "Items";
            // 
            // ItemSaveButton
            // 
            ItemSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ItemSaveButton.Location = new Point(135, 516);
            ItemSaveButton.Name = "ItemSaveButton";
            ItemSaveButton.Size = new Size(120, 45);
            ItemSaveButton.TabIndex = 0;
            ItemSaveButton.Text = "Save";
            ItemSaveButton.UseVisualStyleBackColor = true;
            ItemSaveButton.Click += ItemSaveButton_Click;
            // 
            // ItemAddButton
            // 
            ItemAddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ItemAddButton.Location = new Point(261, 516);
            ItemAddButton.Name = "ItemAddButton";
            ItemAddButton.Size = new Size(120, 45);
            ItemAddButton.TabIndex = 0;
            ItemAddButton.Text = "Add";
            ItemAddButton.UseVisualStyleBackColor = true;
            ItemAddButton.Click += ItemAddButton_Click;
            // 
            // FindTextBox
            // 
            FindTextBox.Location = new Point(55, 19);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(349, 27);
            FindTextBox.TabIndex = 9;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(9, 22);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(40, 20);
            FindLabel.TabIndex = 10;
            FindLabel.Text = "Find:";
            // 
            // SortComboBox
            // 
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Location = new Point(74, 462);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(330, 28);
            SortComboBox.TabIndex = 11;
            SortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
            // 
            // OrderByLabel
            // 
            OrderByLabel.AutoSize = true;
            OrderByLabel.Location = new Point(18, 465);
            OrderByLabel.Name = "OrderByLabel";
            OrderByLabel.Size = new Size(50, 20);
            OrderByLabel.TabIndex = 12;
            OrderByLabel.Text = "label1";
            // 
            // ItemTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrderByLabel);
            Controls.Add(SortComboBox);
            Controls.Add(FindLabel);
            Controls.Add(FindTextBox);
            Controls.Add(ItemAddButton);
            Controls.Add(DeleteItemButton);
            Controls.Add(ItemSaveButton);
            Controls.Add(ItemsListGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemTab";
            Size = new Size(860, 600);
            Load += ItemTab_Load;
            ItemsGroupBox.ResumeLayout(false);
            ItemsGroupBox.PerformLayout();
            ItemsListGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button ItemSaveButton;
        private Button ItemAddButton;
        private ComboBox ItemCategoryComboBox;
        private Label ItemCategoryLabel;
        private TextBox FindTextBox;
        private Label FindLabel;
        private ComboBox SortComboBox;
        private Label OrderByLabel;
    }
}
