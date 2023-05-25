namespace ZX_WareHouse.Models;

public class Product
{
    public int Id { get; set; }
    public string SKU { get; set; }
    public string Model { get; set; }
    public string Provider { get; set; }
    public decimal Quantity { get; set; }
    public string Unit { get; set; }
    public decimal NettoPrice { get; set; }
    public decimal Vat { get; set; }
}
