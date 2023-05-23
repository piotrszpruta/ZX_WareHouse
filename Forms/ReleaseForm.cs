namespace ZX_WareHouse.Forms;

public partial class ReleaseForm : Form
{
    string selectedUnits = "";
    public ReleaseForm() =>
        InitializeComponent();

    private void ReleaseForm_Load(object sender, EventArgs e)
    {
        using LiteDatabase db = new(ConnectionHelper.dbDefaultPath);
        ProductComboBox.ForeColor = Color.White;
        ProductGridView.Columns.Add("numColumn", "lp.");
        ProductGridView.Columns.Add("modelColumn", "Model");
        ProductGridView.Columns.Add("quantityColumn", "Quantity");
        ProductGridView.Columns.Add("unitsColumn", "Unit");

        var prodCol = db.GetCollection<Product>("products");
        var products = prodCol.FindAll().Cast<Product>().ToList();

        List<string> modelsList = new();
        foreach (var product in products)
            modelsList.Add(product.Model);

        db.Dispose();
        ProductComboBox.DataSource = modelsList;
    }

    int i;
    private void AddProductToListButton_Click(object sender, EventArgs e)
    {
        if (ProductComboBox.SelectedIndex >= 0)
        {
            var item = ProductGridView.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.Cells[1].Value == ProductComboBox.SelectedItem.ToString());
            if (item == null)
            {
                ProductGridView.Rows.Add(++i, ProductComboBox.SelectedItem, QuantityNumericValue.Value, selectedUnits);
            }
            else
            {
                var msg = MessageBox.Show("Product of this name exists in current table, do you want to update it? (If No is clicked current value will be overwritten.)", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                {
                    item.Cells[1].Value = ProductComboBox.SelectedItem.ToString();
                    item.Cells[2].Value = Convert.ToDecimal(item.Cells[2].Value) + QuantityNumericValue.Value;
                    item.Cells[3].Value = selectedUnits;
                }
                else if (msg == DialogResult.No)
                {
                    item.Cells[1].Value = ProductComboBox.SelectedItem.ToString();
                    item.Cells[2].Value = QuantityNumericValue.Value;
                    item.Cells[3].Value = selectedUnits;
                }
                else
                {
                    return;
                }
            }
        }
    }

    private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        using LiteDatabase db = new(ConnectionHelper.dbDefaultPath);
        string productName = ProductComboBox.SelectedItem.ToString();
        var prodCol = db.GetCollection<Product>("products");
        var product = prodCol.Query().Where(x => x.Model.Equals(productName)).First();
        QuantityStatusLabel.Text = "Available quantity: " + product.Quantity.ToString() + " " + product.Unit;
        QuantityNumericValue.Maximum = (decimal)product.Quantity;
        selectedUnits = product.Unit;
        db.Dispose();
    }
}
