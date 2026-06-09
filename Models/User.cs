namespace TestMVC.Models;
// User là lớp trừu tượng bán phần.
// Lớp này tổng quát hóa các thuộc tính chung của Customer, Seller và Admin.
public abstract class User : BaseModel
{
    public string Username { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public virtual string GetRole()
    {
        return "User";
    }
}
