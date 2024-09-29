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
        }
    }
}
