namespace ObjectOrientedPractics.View.Controls
{
    partial class CustomerAddressControl
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
            CustomerFullAdressGroupBox = new GroupBox();
            CustomerBuildingLabel = new Label();
            CustomerApartmentLabel = new Label();
            CustomerStreetLabel = new Label();
            CustomerCityLabel = new Label();
            CustomerCountryLabel = new Label();
            CustomerPostIndexLabel = new Label();
            CustomerCountryTextBox = new TextBox();
            CustomerPostIndexTextBox = new TextBox();
            CustomerBuildingTextBox = new TextBox();
            CustomerCityTextBox = new TextBox();
            CustomerApartmentTextBox = new TextBox();
            CustomerStreetTextBox = new TextBox();
            CustomerFullAdressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerFullAdressGroupBox
            // 
            CustomerFullAdressGroupBox.Controls.Add(CustomerBuildingLabel);
            CustomerFullAdressGroupBox.Controls.Add(CustomerApartmentLabel);
            CustomerFullAdressGroupBox.Controls.Add(CustomerStreetLabel);
            CustomerFullAdressGroupBox.Controls.Add(CustomerCityLabel);
            CustomerFullAdressGroupBox.Controls.Add(CustomerCountryLabel);
            CustomerFullAdressGroupBox.Controls.Add(CustomerPostIndexLabel);
            CustomerFullAdressGroupBox.Controls.Add(CustomerCountryTextBox);
            CustomerFullAdressGroupBox.Controls.Add(CustomerPostIndexTextBox);
            CustomerFullAdressGroupBox.Controls.Add(CustomerBuildingTextBox);
            CustomerFullAdressGroupBox.Controls.Add(CustomerCityTextBox);
            CustomerFullAdressGroupBox.Controls.Add(CustomerApartmentTextBox);
            CustomerFullAdressGroupBox.Controls.Add(CustomerStreetTextBox);
            CustomerFullAdressGroupBox.Location = new Point(3, 3);
            CustomerFullAdressGroupBox.Name = "CustomerFullAdressGroupBox";
            CustomerFullAdressGroupBox.Size = new Size(447, 216);
            CustomerFullAdressGroupBox.TabIndex = 6;
            CustomerFullAdressGroupBox.TabStop = false;
            CustomerFullAdressGroupBox.Text = "Delivery Address";
            // 
            // CustomerBuildingLabel
            // 
            CustomerBuildingLabel.AutoSize = true;
            CustomerBuildingLabel.Location = new Point(0, 179);
            CustomerBuildingLabel.Name = "CustomerBuildingLabel";
            CustomerBuildingLabel.Size = new Size(67, 20);
            CustomerBuildingLabel.TabIndex = 17;
            CustomerBuildingLabel.Text = "Building:";
            // 
            // CustomerApartmentLabel
            // 
            CustomerApartmentLabel.AutoSize = true;
            CustomerApartmentLabel.Location = new Point(223, 179);
            CustomerApartmentLabel.Name = "CustomerApartmentLabel";
            CustomerApartmentLabel.Size = new Size(83, 20);
            CustomerApartmentLabel.TabIndex = 16;
            CustomerApartmentLabel.Text = "Apartment:";
            // 
            // CustomerStreetLabel
            // 
            CustomerStreetLabel.AutoSize = true;
            CustomerStreetLabel.Location = new Point(0, 135);
            CustomerStreetLabel.Name = "CustomerStreetLabel";
            CustomerStreetLabel.Size = new Size(51, 20);
            CustomerStreetLabel.TabIndex = 15;
            CustomerStreetLabel.Text = "Street:";
            // 
            // CustomerCityLabel
            // 
            CustomerCityLabel.AutoSize = true;
            CustomerCityLabel.Location = new Point(236, 81);
            CustomerCityLabel.Name = "CustomerCityLabel";
            CustomerCityLabel.Size = new Size(37, 20);
            CustomerCityLabel.TabIndex = 14;
            CustomerCityLabel.Text = "City:";
            // 
            // CustomerCountryLabel
            // 
            CustomerCountryLabel.AutoSize = true;
            CustomerCountryLabel.Location = new Point(0, 81);
            CustomerCountryLabel.Name = "CustomerCountryLabel";
            CustomerCountryLabel.Size = new Size(63, 20);
            CustomerCountryLabel.TabIndex = 13;
            CustomerCountryLabel.Text = "Country:";
            // 
            // CustomerPostIndexLabel
            // 
            CustomerPostIndexLabel.AutoSize = true;
            CustomerPostIndexLabel.Location = new Point(3, 39);
            CustomerPostIndexLabel.Name = "CustomerPostIndexLabel";
            CustomerPostIndexLabel.Size = new Size(48, 20);
            CustomerPostIndexLabel.TabIndex = 12;
            CustomerPostIndexLabel.Text = "Index:";
            // 
            // CustomerCountryTextBox
            // 
            CustomerCountryTextBox.Location = new Point(66, 81);
            CustomerCountryTextBox.Name = "CustomerCountryTextBox";
            CustomerCountryTextBox.Size = new Size(125, 27);
            CustomerCountryTextBox.TabIndex = 11;
            // 
            // CustomerPostIndexTextBox
            // 
            CustomerPostIndexTextBox.Location = new Point(53, 36);
            CustomerPostIndexTextBox.Name = "CustomerPostIndexTextBox";
            CustomerPostIndexTextBox.Size = new Size(125, 27);
            CustomerPostIndexTextBox.TabIndex = 10;
            // 
            // CustomerBuildingTextBox
            // 
            CustomerBuildingTextBox.Location = new Point(77, 178);
            CustomerBuildingTextBox.Name = "CustomerBuildingTextBox";
            CustomerBuildingTextBox.Size = new Size(125, 27);
            CustomerBuildingTextBox.TabIndex = 9;
            // 
            // CustomerCityTextBox
            // 
            CustomerCityTextBox.Location = new Point(279, 81);
            CustomerCityTextBox.Name = "CustomerCityTextBox";
            CustomerCityTextBox.Size = new Size(125, 27);
            CustomerCityTextBox.TabIndex = 8;
            // 
            // CustomerApartmentTextBox
            // 
            CustomerApartmentTextBox.Location = new Point(312, 176);
            CustomerApartmentTextBox.Name = "CustomerApartmentTextBox";
            CustomerApartmentTextBox.Size = new Size(125, 27);
            CustomerApartmentTextBox.TabIndex = 7;
            // 
            // CustomerStreetTextBox
            // 
            CustomerStreetTextBox.Location = new Point(53, 132);
            CustomerStreetTextBox.Name = "CustomerStreetTextBox";
            CustomerStreetTextBox.Size = new Size(384, 27);
            CustomerStreetTextBox.TabIndex = 6;
            // 
            // CustomerAddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomerFullAdressGroupBox);
            Name = "CustomerAddressControl";
            Size = new Size(460, 229);
            CustomerFullAdressGroupBox.ResumeLayout(false);
            CustomerFullAdressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomerFullAdressGroupBox;
        private TextBox CustomerCountryTextBox;
        private TextBox CustomerPostIndexTextBox;
        private TextBox CustomerBuildingTextBox;
        private TextBox CustomerCityTextBox;
        private TextBox CustomerApartmentTextBox;
        private TextBox CustomerStreetTextBox;
        private Label CustomerStreetLabel;
        private Label CustomerCityLabel;
        private Label CustomerCountryLabel;
        private Label CustomerPostIndexLabel;
        private Label CustomerBuildingLabel;
        private Label CustomerApartmentLabel;
    }
}
