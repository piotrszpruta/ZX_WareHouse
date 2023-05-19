namespace ZX_WareHouse.Models;

public class History
{
    public int Id { get; set; }
    public string Model { get; set; }
    public string Provider { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }
    public double NettoPrice { get; set; }
    public double Vat { get; set; }
    public bool IsAdded { get; set; }
    public DateTime Modified { get; set; }
    public string User { get; set; }
}
