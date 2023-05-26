namespace ZX_WareHouse.Helpers;

class StartupHelper
{
    /// <summary>
    /// Startup method to detect database and set it's path 
    /// </summary>
    public static void Startup()
    {
        if (!File.Exists(ConnectionHelper.dbDefaultPath))
        {
            bool isSelected = false;
            while (!isSelected)
            {
                var pathCheck = MessageBox.Show("You don't have database created. Do you want to select the file? (If no then default database will be created)", "Database unavailable", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (pathCheck == DialogResult.Yes)
                {
                    OpenFileDialog selectPath = new();
                    selectPath.ShowDialog();
                    ConnectionHelper.dbDefaultPath = selectPath.FileName;
                    if (selectPath.FileName != "")
                        isSelected = true;
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
                    isSelected = true;
                }
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
        // Insert demo user
        var usersCol = db.GetCollection<User>("users");
        var userAdmin = new User
        {
            FirstName = "Test",
            LastName = "User",
            Name = "admin",
            Password = HashPassword.SHA254Hash("admin"),
            Email = "admin@admin.com",
            Permission = 1
        };
        usersCol.Insert(userAdmin);

        var userMod = new User
        {
            FirstName = "Test",
            LastName = "User",
            Name = "moderator",
            Password = HashPassword.SHA254Hash("moderator"),
            Email = "moderator@mod.com",
            Permission = 3
        };
        usersCol.Insert(userMod);

        // Insert demo products
        var productsCol = db.GetCollection<Product>("products");

        var demo1 = new Product
        {
            Model = "First Demo",
            Provider = "Demo provider",
            Quantity = 78,
            Vat = 23,
            Unit = "liters",
            NettoPrice = 900
        };
        productsCol.Insert(demo1);

        var demo2 = new Product
        {
            Model = "Demo product #1",
            Provider = "Demo provider",
            Quantity = 530,
            Vat = 8,
            Unit = "items",
            NettoPrice = 350
        };
        productsCol.Insert(demo2);

        var demo3 = new Product
        {
            Model = "Demo product #2",
            Provider = "Second provider",
            Quantity = 690,
            Vat = 23,
            Unit = "kilograms",
            NettoPrice = 780
        };
        productsCol.Insert(demo3);

        var historyCol = db.GetCollection<History>("release_history");

        var demoHistory = new History
        {
            Company = "Test company",
            NIP = "123123123",
            Address = "ul. Testing 2",
            Products = new()
            {
                demo1,
                demo2,
                demo3
            },
            Modified = DateTime.Now,
            User = "Test User"
        };

        historyCol.Insert(demoHistory);

        db.Dispose();
    }
}
