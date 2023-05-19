namespace ZX_WareHouse.Models;

public class Product
{
    public int Id { get; set; }
    public string SKU { get; set; }
    public string Model { get; set; }
    public string Provider { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }
    public double NettoPrice { get; set; }
    public double Vat { get; set; }
}
