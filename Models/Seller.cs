namespace TestMVC.Models;
// Seller là lớp đặc thù hóa từ User.
public class Seller : User
{
    public string StoreName { get; set; } = string.Empty;

    public override string GetRole()
    {
        return "Seller";
    }
}
