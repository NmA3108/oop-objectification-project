namespace TestMVC.Models;

// BaseModel là lớp cha chung cho các model trong hệ thống.
// Đây là phần tổng quát hóa: các model đều có Id và thông tin thời gian.
public abstract class BaseModel
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
