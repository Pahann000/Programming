using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Магазин
        /// </summary>
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
            ItemNewTab.Items = _store.Items;
            CustomerNewTab.Customers = _store.Customers;
            CartNewTab.Items = _store.Items;
            CartNewTab.Customers = _store.Customers;
            OrderNewTab.Customers = _store.Customers;
        }

        private void ShopTabControl_SelectedTabChanged(object sender, EventArgs e)
        {
            CartNewTab.RefreshData();
            OrderNewTab.RefreshData();
        }


    }
}
