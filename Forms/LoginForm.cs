namespace ZX_WareHouse.Forms;

public partial class LoginForm : Form
{
    public LoginForm() =>
        InitializeComponent();

    private void LoginForm_Load(object sender, EventArgs e) =>
        StartupHelper.Startup();

    private void SignInButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(PasswordTextField.Text) || string.IsNullOrEmpty(LoginTextField.Text))
        {
            ErrorMessage.Visible = true;
            return;
        }

        string hashedPassword = HashPassword.SHA254Hash(PasswordTextField.Text);
        bool isCorrect = ConnectionHelper.CheckUserCredentials(LoginTextField.Text, hashedPassword);
        int permissions = ConnectionHelper.CheckUserPermissions(LoginTextField.Text);
        if (isCorrect)
        {
            Hide();
            MainForm dashboard = new()
            {
                UserName = LoginTextField.Text,
                LoginForm = this,
                UserPermission = permissions
            };
            dashboard.FormClosing += delegate { this.Close(); };
            dashboard.Show();
        }
        else
        {
            ErrorMessage.Visible = true;
        }
    }
}
