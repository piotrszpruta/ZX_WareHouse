namespace ZX_WareHouse.UserControls;

    public partial class WarehousePanel : UserControl
    {
        public WarehousePanel()
        {
            InitializeComponent();
        }

    private void WarehousePanel_Load(object sender, EventArgs e)
    {
        // Set background color of menustrip
        menuStrip1.ForeColor = Color.White;
        menuStrip1.BackColor = Color.FromArgb(43, 42, 41);

        LoadDatabaseProducts();
    }

    private void LoadDatabaseProducts()
    {
        using LiteDatabase db = new(ConnectionHelper.dbDefaultPath);
        var productCol = db.GetCollection<Product>("products");
        IList<Product> productList = productCol.FindAll().ToList();

        DataTable dt = new();
        dt.Columns.Add("ID");
        dt.Columns.Add("Model");
        dt.Columns.Add("Provider");
        dt.Columns.Add("Quantity");
        dt.Columns.Add("Unit");
        dt.Columns.Add("Netto price");
        dt.Columns.Add("VAT (%)");
        dt.Columns.Add("Brutto price");
        foreach (Product product in productList)
        {
            double bruttoPrice = product.NettoPrice + (product.NettoPrice * product.Vat / 100);
            bruttoPrice = Math.Round(bruttoPrice, 2);
            dt.Rows.Add(product.Id, product.Model, product.Provider, product.Quantity, product.Unit, product.NettoPrice, product.Vat, bruttoPrice);
        }

        ProductGridView.DataSource = dt;
        ProductGridView.ClearSelection();
    }
    private void newDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        WarehouseProduct warehouseProduct = new();
        warehouseProduct.Show();
        warehouseProduct.FormClosed += delegate { LoadDatabaseProducts(); };
    }
    }
}
