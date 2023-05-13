using System.Data;

namespace ZX_WareHouse.UserControls;

public partial class UsersPanel : UserControl
{
    public UsersPanel() =>
        InitializeComponent();

    private void UsersPanel_Load(object sender, EventArgs e)
    {
        using LiteDatabase db = new(ConnectionHelper.dbDefaultPath);
        var usersCol = db.GetCollection<User>("users");
        IList<User> users = usersCol.FindAll().ToList();

        DataTable dt = new();
        dt.Columns.Add("ID");
        dt.Columns.Add("Login");
        dt.Columns.Add("Email");
        foreach (User user in users)
        {
            dt.Rows.Add(user.Id, user.Name, user.Email);
        }

        UserGridView.DataSource = dt;
    }
}
