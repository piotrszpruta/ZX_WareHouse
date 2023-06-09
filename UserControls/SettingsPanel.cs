﻿namespace ZX_WareHouse.UserControls;

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
        dt.Columns.Add("Permissions");
        foreach (User user in users)
        {
            string permissionName = "";
            if (user.Permission == 1)
                permissionName = "Administrator";
            else
                permissionName = "Moderator";

            dt.Rows.Add(user.Id, user.FirstName, user.LastName, user.Name, user.Email, permissionName);
        }

        UserGridView.DataSource = dt;
        db.Dispose();
    }

    private void SaveUserButton_Click(object sender, EventArgs e)
    {
        using LiteDatabase db = new(connectionString: ConnectionHelper.dbDefaultPath);
        var usersCol = db.GetCollection<User>("users");
        int permissionSelected = AdministratorRadioButton.Checked ? 1 : 3;
        if (string.IsNullOrEmpty(selectedID.Text))
        {
            usersCol.Insert(new User
            {
                Name = NameTextField.Text,
                Email = EmailTextField.Text,
                FirstName = FirstNameTextField.Text,
                LastName = SecondNameTextField.Text,
                Password = HashPassword.SHA254Hash(PasswordTextBox.Text),
                Permission = permissionSelected,
            });
        }
        else
        {
            var userUpdate = new User
            {
                Id = Convert.ToInt32(selectedID.Text),
                Name = NameTextField.Text,
                Email = EmailTextField.Text,
                FirstName = FirstNameTextField.Text,
                LastName = SecondNameTextField.Text,
                Password = HashPassword.SHA254Hash(PasswordTextBox.Text),
                Permission = permissionSelected,
            };
            usersCol.Update(userUpdate);
        }

        db.Dispose();
        LoadDataToList();
    }

    private void GeneratePasswordButton_Click(object sender, EventArgs e)
    {
        const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        StringBuilder sb = new();
        Random rnd = new();

        for (int i = 0; i < 10; i++)
        {
            int index = rnd.Next(chars.Length);
            sb.Append(chars[index]);
        }

        PasswordTextBox.Text = sb.ToString();
    }

    private void RemoveUserButton_Click(object sender, EventArgs e)
    {
        if (UserGridView.SelectedRows.Count > 0)
        {
            using LiteDatabase db = new(connectionString: ConnectionHelper.dbDefaultPath);
            var usersCol = db.GetCollection<User>("users");
            bool isRemoved = usersCol.Delete(Convert.ToInt32(UserGridView.SelectedCells[0].Value));
            if (isRemoved)
            {
                MessageBox.Show("User removed.");
            }
            else
            {
                MessageBox.Show("Removing failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.Dispose();
            LoadDataToList();
        }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        selectedID.ResetText();
        FirstNameTextField.ResetText();
        SecondNameTextField.ResetText();
        NameTextField.ResetText();
        EmailTextField.ResetText();
        PasswordTextBox.ResetText();
    }

    private void UserGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (UserGridView.SelectedRows.Count > 0)
        {
            selectedID.Text = (string)UserGridView.SelectedRows[0].Cells[0].Value;
            FirstNameTextField.Text = (string)UserGridView.SelectedRows[0].Cells[1].Value;
            SecondNameTextField.Text = (string)UserGridView.SelectedRows[0].Cells[2].Value;
            NameTextField.Text = (string)UserGridView.SelectedRows[0].Cells[3].Value;
            EmailTextField.Text = (string)UserGridView.SelectedRows[0].Cells[4].Value;
            PasswordTextBox.ResetText();
            if ((string)UserGridView.SelectedRows[0].Cells[5].Value == "Administrator")
            {
                AdministratorRadioButton.Checked = true;
            }
            else
            {
                ModeratorRadioButton.Checked = true;
            }
        }
    }
}
