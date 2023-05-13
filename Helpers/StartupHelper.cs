namespace ZX_WareHouse.Helpers;

class StartupHelper
{
    public static void Startup()
    {
        if (!File.Exists(ConnectionHelper.dbDefaultPath))
        {
            var pathCheck = MessageBox.Show("You don't have database created. Do you want to select the file? (If no then default database will be created)", "Database unavailable", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (pathCheck == DialogResult.Yes)
            {
                OpenFileDialog selectPath = new();
                selectPath.ShowDialog();
                ConnectionHelper.dbDefaultPath = selectPath.FileName;
            }
            else if (pathCheck == DialogResult.No)
            {
                // Create Data folder
                string dir = "./Data";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                // Create default user and database is created
                InsertDefaultUser();
            }
        }
        else
        {
            MessageBox.Show("Database found. Proceed to login", "Database available");
        }
    }

    /// <summary>
    /// Create db file, collection and default user if db doesn't exists
    /// </summary>
    private static void InsertDefaultUser()
    {
        using LiteDatabase db = new(ConnectionHelper.dbDefaultPath);
        var usersCol = db.GetCollection<User>("users");
        var user = new User
        {
            Name = "admin",
            Password = HashPassword.SHA254Hash("admin"),
            Email = "admin@admin.com"
        };

        var productsCol = db.GetCollection<Product>("products");
        var demoProduct = new Product
        {
            Model = "Demo product #1",
            Provider = "Provider #1",
            Vat = 23,
            NettoPrice = 1000,
            SKU = "DMPROD1",
            Weight = 18.5
        };

        usersCol.Insert(user);
        productsCol.Insert(demoProduct);
    }
}
