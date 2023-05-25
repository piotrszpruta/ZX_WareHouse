namespace ZX_WareHouse.UserControls;

public partial class HistoryPanel : UserControl
{
    public HistoryPanel()
    {
        InitializeComponent();
    }

    private void HistoryPanel_Load(object sender, EventArgs e)
    {
        using LiteDatabase db = new(ConnectionHelper.dbDefaultPath);
        var historyCol = db.GetCollection<History>("release_history");
        IList<History> historyList = historyCol.FindAll().ToList();

        DataTable dt = new();
        dt.Columns.Add("ID");
        dt.Columns.Add("Date");
        dt.Columns.Add("Company");
        dt.Columns.Add("NIP");
        dt.Columns.Add("Products count");
        foreach (History history in historyList)
        {
            dt.Rows.Add(history.Id, history.Modified, history.Company, history.NIP, history.Products.Count);
        }

        HistoryGridView.DataSource = dt;

        db.Dispose();
    }
}
