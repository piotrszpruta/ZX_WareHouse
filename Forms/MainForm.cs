using ZX_WareHouse.UserControls;

namespace ZX_WareHouse.Forms;

public partial class MainForm : Form
{
    private string userName;
    public string UserName { get => userName; set => userName = value; }
    public Form LoginForm { get; set; }

    public MainForm() =>
        InitializeComponent();

    private void MainForm_Load(object sender, EventArgs e)
    {
        LoginUserLabel.Text = "Logged as: " + userName;
    }

    private void UsersButton_Click(object sender, EventArgs e)
    {
        FillPanelContainer.Controls.Clear();
        FillPanelContainer.Controls.Add(new SettingsPanel() { Dock = DockStyle.Fill });
    }

    private void WarehouseButton_Click(object sender, EventArgs e)
    {
        FillPanelContainer.Controls.Clear();
        FillPanelContainer.Controls.Add(new WarehousePanel() { Dock = DockStyle.Fill });
    }

    private void ReleaseHistoryButton_Click(object sender, EventArgs e)
    {
        FillPanelContainer.Controls.Clear();
        FillPanelContainer.Controls.Add(new HistoryPanel() { Dock = DockStyle.Fill });
    }
}