namespace ZX_WareHouse.UserControls;

    public partial class WarehousePanel : UserControl
    {
        public WarehousePanel()
        {
            InitializeComponent();
        }
    private void newDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        WarehouseProduct warehouseProduct = new();
        warehouseProduct.Show();
        warehouseProduct.FormClosed += delegate { LoadDatabaseProducts(); };
    }
    }
}
