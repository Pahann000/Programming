namespace ObjectOrientedPractics.Model
{
    partial class DiscountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DiscountLabel = new Label();
            CategoryComboBox = new ComboBox();
            OkDiscountButton = new Button();
            CancelDiscountButton = new Button();
            SuspendLayout();
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountLabel.Location = new Point(40, 49);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(75, 20);
            DiscountLabel.TabIndex = 0;
            DiscountLabel.Text = "Discount:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(40, 83);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(270, 28);
            CategoryComboBox.TabIndex = 1;
            // 
            // OkDiscountButton
            // 
            OkDiscountButton.Location = new Point(40, 157);
            OkDiscountButton.Name = "OkDiscountButton";
            OkDiscountButton.Size = new Size(120, 45);
            OkDiscountButton.TabIndex = 2;
            OkDiscountButton.Text = "Ok";
            OkDiscountButton.UseVisualStyleBackColor = true;
            OkDiscountButton.Click += OkButton_Click;
            // 
            // CancelDiscountButton
            // 
            CancelDiscountButton.Location = new Point(190, 157);
            CancelDiscountButton.Name = "CancelDiscountButton";
            CancelDiscountButton.Size = new Size(120, 45);
            CancelDiscountButton.TabIndex = 3;
            CancelDiscountButton.Text = "Cancel";
            CancelDiscountButton.UseVisualStyleBackColor = true;
            CancelDiscountButton.Click += CancelButton_Click;
            // 
            // DiscountsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 258);
            Controls.Add(CancelDiscountButton);
            Controls.Add(OkDiscountButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(DiscountLabel);
            Name = "DiscountsForm";
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DiscountLabel;
        private ComboBox CategoryComboBox;
        private Button OkDiscountButton;
        private Button CancelDiscountButton;
    }
}