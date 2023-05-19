namespace ZX_WareHouse.Forms;

public partial class WarehouseProduct : Form
{
    public Product product;
    private Product Product { get => product; set => product = value; }
    public WarehouseProduct() =>
        InitializeComponent();

    private void WarehouseProduct_Load(object sender, EventArgs e)
    {
        if (product != null)
        {
            IdLabel.Text = product.Id.ToString();
            ModelTextField.Text = product.Model;
            ProviderTextBox.Text = product.Provider;
            NettoTextBox.Text = product.NettoPrice.ToString();
            QuantityTextBox.Text = product.Quantity.ToString();
            VatComboBox.SelectedIndex = VatComboBox.FindStringExact(product.Vat.ToString());
            UnitComboBox.SelectedIndex = UnitComboBox.FindStringExact(product.Unit);
        }
    }

    private void SaveProductToWarehouse_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(ModelTextField.Text))
            return;

        if (string.IsNullOrEmpty(ProviderTextBox.Text))
            return;

        if (string.IsNullOrEmpty(NettoTextBox.Text))
            return;

        if (string.IsNullOrEmpty(QuantityTextBox.Text))
            return;

        if (VatComboBox.SelectedIndex < 0)
            return;

        if (UnitComboBox.SelectedIndex < 0)
            return;

        using LiteDatabase db = new(ConnectionHelper.dbDefaultPath);
        var productCol = db.GetCollection<Product>("products");

        Product product = new()
        {
            Model = ModelTextField.Text,
            Provider = ProviderTextBox.Text,
            NettoPrice = Convert.ToDouble(NettoTextBox.Text),
            Quantity = Convert.ToDouble(QuantityTextBox.Text),
            Vat = Convert.ToDouble(VatComboBox.Text),
            Unit = UnitComboBox.Text,
        };

        if (string.IsNullOrWhiteSpace(IdLabel.Text))
        {
            productCol.Insert(product);
        }
        else
        {
            product.Id = Convert.ToInt32(IdLabel.Text);
            productCol.Update(product);
        }
        db.Dispose();
        this.Close();
    }
}
