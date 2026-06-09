namespace TestMVC.Models;
// Product kế thừa BaseModel để dùng chung Id, CreatedAt, UpdatedAt.
public class Product : BaseModel
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public string Brand { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;
}
