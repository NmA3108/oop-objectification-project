namespace TestMVC.Models;

public class Order : BaseModel
{
    public DateTime OrderDate { get; set; } = DateTime.Now;

    public string Status { get; set; } = "Pending";

    public decimal TotalAmount { get; set; }

    public List<Product> Products { get; set; } = new();
}
