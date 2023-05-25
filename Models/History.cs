namespace ZX_WareHouse.Models;

public class History
{
    public int Id { get; set; }
    public string Company { get; set; }
    public string NIP { get; set; }
    public string Address { get; set; }
    public List<Product> Products { get; set; }
    public DateTime Modified { get; set; }
    public string User { get; set; }
}
