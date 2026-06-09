namespace TestMVC.Models;

// Customer là lớp đặc thù hóa từ User.
public class Customer : User
{
    public string Address { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public override string GetRole()
    {
        return "Customer";
    }
}
