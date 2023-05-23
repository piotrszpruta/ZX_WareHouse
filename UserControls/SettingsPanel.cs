using System.Data;

namespace ZX_WareHouse.UserControls;

public partial class SettingsPanel : UserControl
{
    public SettingsPanel() =>
        InitializeComponent();

    private void UsersPanel_Load(object sender, EventArgs e)
    {
        LoadDataToList();
    }

    private void LoadDataToList()
    {
        using LiteDatabase db = new(connectionString: ConnectionHelper.dbDefaultPath);

        var usersCol = db.GetCollection<User>("users");
        IList<User> users = usersCol.FindAll().ToList();

        DataTable dt = new();
        dt.Columns.Add("ID");
        dt.Columns.Add("First name");
        dt.Columns.Add("Last name");
        dt.Columns.Add("Login");
        dt.Columns.Add("Email");
        foreach (User user in users)
        {
            dt.Rows.Add(user.Id, user.FirstName, user.LastName, user.Name, user.Email);
        }

        UserGridView.DataSource = dt;
        db.Dispose();
    }
}
