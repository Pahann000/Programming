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
            PriorityOrdersNewTab.Items = _store.Items;
            ItemNewTab.ItemsChanged += Tabs_DataChanges;

        }

        private void ShopTabControl_SelectedTabChanged(object sender, EventArgs e)
        {
            CartNewTab.RefreshData();
            OrderNewTab.RefreshData();
        }

        /// <summary>
        /// Событие для обновления данных
        /// </summary>
        /// <param name="sender">Ссылка на объект, зажигающий событие</param>
        /// <param name="e">Данные о событие</param>
        private void Tabs_DataChanges(object sender, EventArgs e)
        {
            ItemNewTab.RefreshData();
            CartNewTab.RefreshData();
            OrderNewTab.RefreshData();
        }


    }
}
