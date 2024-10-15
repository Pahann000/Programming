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
            ItemNewTab = new View.Tabs.ItemTab();
            CustomerTabPage = new TabPage();
            CustomerNewTab = new View.Tabs.CustomerTab();
            CartTabPage = new TabPage();
            CartNewTab = new View.Tabs.CartTab();
            OrderTabPage = new TabPage();
            OrderNewTab = new View.Tabs.OrderTab();
            ShopTabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomerTabPage.SuspendLayout();
            CartTabPage.SuspendLayout();
            OrderTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // ShopTabControl
            // 
            ShopTabControl.Controls.Add(ItemsTabPage);
            ShopTabControl.Controls.Add(CustomerTabPage);
            ShopTabControl.Controls.Add(CartTabPage);
            ShopTabControl.Controls.Add(OrderTabPage);
            ShopTabControl.Dock = DockStyle.Fill;
            ShopTabControl.Location = new Point(0, 0);
            ShopTabControl.Name = "ShopTabControl";
            ShopTabControl.SelectedIndex = 0;
            ShopTabControl.Size = new Size(883, 643);
            ShopTabControl.TabIndex = 0;
            ShopTabControl.SelectedIndexChanged += ShopTabControl_SelectedTabChanged;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemNewTab);
            ItemsTabPage.Location = new Point(4, 29);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(875, 610);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemNewTab
            // 
            ItemNewTab.Dock = DockStyle.Fill;
            ItemNewTab.Location = new Point(3, 3);
            ItemNewTab.Name = "ItemNewTab";
            ItemNewTab.Size = new Size(869, 604);
            ItemNewTab.TabIndex = 0;
            // 
            // CustomerTabPage
            // 
            CustomerTabPage.Controls.Add(CustomerNewTab);
            CustomerTabPage.Location = new Point(4, 29);
            CustomerTabPage.Name = "CustomerTabPage";
            CustomerTabPage.Padding = new Padding(3);
            CustomerTabPage.Size = new Size(875, 610);
            CustomerTabPage.TabIndex = 1;
            CustomerTabPage.Text = "Customer";
            CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerNewTab
            // 
            CustomerNewTab.Dock = DockStyle.Fill;
            CustomerNewTab.Location = new Point(3, 3);
            CustomerNewTab.Name = "CustomerNewTab";
            CustomerNewTab.Size = new Size(869, 604);
            CustomerNewTab.TabIndex = 0;
            // 
            // CartTabPage
            // 
            CartTabPage.Controls.Add(CartNewTab);
            CartTabPage.Location = new Point(4, 29);
            CartTabPage.Name = "CartTabPage";
            CartTabPage.Padding = new Padding(3);
            CartTabPage.Size = new Size(875, 610);
            CartTabPage.TabIndex = 2;
            CartTabPage.Text = "Carts";
            CartTabPage.UseVisualStyleBackColor = true;
            // 
            // CartNewTab
            // 
            CartNewTab.Customers = null;
            CartNewTab.Items = null;
            CartNewTab.Location = new Point(0, 6);
            CartNewTab.Name = "CartNewTab";
            CartNewTab.Size = new Size(869, 604);
            CartNewTab.TabIndex = 0;
            // 
            // OrderTabPage
            // 
            OrderTabPage.Controls.Add(OrderNewTab);
            OrderTabPage.Location = new Point(4, 29);
            OrderTabPage.Name = "OrderTabPage";
            OrderTabPage.Padding = new Padding(3);
            OrderTabPage.Size = new Size(875, 610);
            OrderTabPage.TabIndex = 3;
            OrderTabPage.Text = "Orders";
            OrderTabPage.UseVisualStyleBackColor = true;
            // 
            // OrderNewTab
            // 
            OrderNewTab.Location = new Point(3, 4);
            OrderNewTab.Name = "OrderNewTab";
            OrderNewTab.Size = new Size(860, 600);
            OrderNewTab.TabIndex = 0;
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
            CartTabPage.ResumeLayout(false);
            OrderTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl ShopTabControl;
        private TabPage ItemsTabPage;
        private TabPage CustomerTabPage;
        private View.Tabs.ItemTab ItemNewTab;
        private View.Tabs.CustomerTab CustomerNewTab;
        private TabPage CartTabPage;
        private View.Tabs.CartTab CartNewTab;
        private TabPage OrderTabPage;
        private View.Tabs.OrderTab OrderNewTab;
    }
}
