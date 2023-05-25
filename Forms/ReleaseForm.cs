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
                    var sumValues = Convert.ToDecimal(item.Cells[2].Value) + QuantityNumericValue.Value;
                    var quantityStatusLb = Convert.ToDecimal(QuantityStatusLabel.Text);
                    if (sumValues <= quantityStatusLb)
                    {
                        item.Cells[2].Value = sumValues;
                        item.Cells[3].Value = selectedUnits;
                    }
                    else
                    {
                        MessageBox.Show($"Limit is exceed! \nYour max quantity in warehouse is: {quantityStatusLb} {item.Cells[3].Value}", "Exceed limit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
        QuantityStatusLabel.Text = product.Quantity.ToString();
        QuantityNumericValue.Maximum = (decimal)product.Quantity;
        selectedUnits = product.Unit;
        db.Dispose();
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        using LiteDatabase db = new(ConnectionHelper.dbDefaultPath);
        var historyCol = db.GetCollection<History>("release_history");

        List<Product> productList = new();

        foreach (DataGridViewRow item in ProductGridView.Rows)
        {
            // Update warehouse status
            string prodModel = (string)item.Cells[1].Value;
            decimal prodQuantity = (decimal)item.Cells[2].Value;
            var productCol = db.GetCollection<Product>("products");
            var product = productCol.FindOne(y => y.Model.Equals(prodModel));

            var updatedProd = new Product
            {
                Id = product.Id,
                Model = prodModel,
                Provider = product.Provider,
                Quantity = product.Quantity - prodQuantity,
                NettoPrice = product.NettoPrice,
                Unit = product.Unit,
                Vat = product.Vat,
            };

            productCol.Update(updatedProd);

            // Insert data to db
            var prod = new Product
            {
                Model = prodModel,
                Quantity = prodQuantity,
                Unit = (string)item.Cells[3].Value,
            };

            productList.Add(prod);
        }

        var data = new History
        {
            Company = CompanyTextField.Text,
            NIP = NipTextBox.Text,
            Address = AddressTextBox.Text,
            Products = productList,
            Modified = DateTime.Now,
        };

        historyCol.Insert(data);
        db.Dispose();
        MessageBox.Show("Products release successful!");
        this.Close();
    }
}
