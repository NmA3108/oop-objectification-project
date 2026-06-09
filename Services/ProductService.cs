using TestMVC.Models;

namespace TestMVC.Services;

// ProductService là đặc thù hóa từ CRUD tổng quát.
// Ngoài CRUD cơ bản, ProductService có thêm chức năng Search cho sản phẩm.
public class ProductService : InMemoryCrudService<Product>
{
    public ProductService()
    {
        Create(new Product
        {
            Name = "iPhone 15 Pro Max",
            Brand = "Apple",
            Description = "Điện thoại cao cấp của Apple",
            Price = 35000000,
            Stock = 20,
            ImageUrl = "https://picsum.photos/300/200?1"
        });

        Create(new Product
        {
            Name = "Samsung Galaxy S25",
            Brand = "Samsung",
            Description = "Flagship Android mới nhất",
            Price = 28000000,
            Stock = 15,
            ImageUrl = "https://picsum.photos/300/200?2"
        });

        Create(new Product
        {
            Name = "MacBook Air M4",
            Brand = "Apple",
            Description = "Laptop cho học tập và làm việc",
            Price = 32000000,
            Stock = 10,
            ImageUrl = "https://picsum.photos/300/200?3"
        });
    }

    public List<Product> Search(string? keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return GetAll();
        }

        return GetAll()
            .Where(product => product.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                || product.Brand.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
