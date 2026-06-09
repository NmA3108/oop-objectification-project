namespace TestMVC.Models;

public class Cart : BaseModel
{
    public List<Product> Products { get; set; } = new();

    public decimal TotalAmount => Products.Sum(product => product.Price);

    public void AddProduct(Product product)
    {
        Products.Add(product);
        UpdatedAt = DateTime.Now;
    }

    public void RemoveProduct(int productId)
    {
        var product = Products.FirstOrDefault(item => item.Id == productId);

        if (product != null)
        {
            Products.Remove(product);
            UpdatedAt = DateTime.Now;
        }
    }
}
