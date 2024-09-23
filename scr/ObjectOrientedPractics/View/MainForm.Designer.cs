namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ShopTabControl = new TabControl();
            ItemsTabPage = new TabPage();
            ItemTab = new View.Tabs.ItemTab();
            CustomerTabPage = new TabPage();
            customerTab1 = new View.Tabs.CustomerTab();
            ShopTabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomerTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // ShopTabControl
            // 
            ShopTabControl.Controls.Add(ItemsTabPage);
            ShopTabControl.Controls.Add(CustomerTabPage);
            ShopTabControl.Dock = DockStyle.Fill;
            ShopTabControl.Location = new Point(0, 0);
            ShopTabControl.Name = "ShopTabControl";
            ShopTabControl.SelectedIndex = 0;
            ShopTabControl.Size = new Size(883, 643);
            ShopTabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemTab);
            ItemsTabPage.Location = new Point(4, 29);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(875, 610);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemTab
            // 
            ItemTab.Dock = DockStyle.Fill;
            ItemTab.Location = new Point(3, 3);
            ItemTab.Name = "ItemTab";
            ItemTab.Size = new Size(869, 604);
            ItemTab.TabIndex = 0;
            // 
            // CustomerTabPage
            // 
            CustomerTabPage.Controls.Add(customerTab1);
            CustomerTabPage.Location = new Point(4, 29);
            CustomerTabPage.Name = "CustomerTabPage";
            CustomerTabPage.Padding = new Padding(3);
            CustomerTabPage.Size = new Size(875, 610);
            CustomerTabPage.TabIndex = 1;
            CustomerTabPage.Text = "Customer";
            CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // customerTab1
            // 
            customerTab1.Location = new Point(3, 3);
            customerTab1.Name = "customerTab1";
            customerTab1.Size = new Size(866, 604);
            customerTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 643);
            Controls.Add(ShopTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Object Oriented Practics";
            ShopTabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            CustomerTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl ShopTabControl;
        private TabPage ItemsTabPage;
        private TabPage CustomerTabPage;
        private View.Tabs.ItemTab ItemTab;
        private View.Tabs.CustomerTab customerTab1;
    }
}
