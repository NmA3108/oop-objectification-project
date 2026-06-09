namespace TestMVC.Models;

// Admin là lớp đặc thù hóa từ User.
public class Admin : User
{
    public string PermissionLevel { get; set; } = "Full";

    public override string GetRole()
    {
        return "Admin";
    }
}
