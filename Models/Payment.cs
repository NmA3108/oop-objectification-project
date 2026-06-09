namespace TestMVC.Models;

// Payment là lớp trừu tượng bán phần.
// Lớp này có thuộc tính chung, nhưng phương thức Pay() được các lớp con triển khai riêng.
public abstract class Payment : BaseModel
{
    public decimal Amount { get; set; }

    public DateTime PaymentDate { get; set; } = DateTime.Now;

    public abstract string Pay();
}

public class CashPayment : Payment
{
    public override string Pay()
    {
        return $"Thanh toán tiền mặt: {Amount:N0} VNĐ";
    }
}

public class MomoPayment : Payment
{
    public string PhoneNumber { get; set; } = string.Empty;

    public override string Pay()
    {
        return $"Thanh toán MoMo: {Amount:N0} VNĐ";
    }
}

public class VNPayPayment : Payment
{
    public string TransactionCode { get; set; } = string.Empty;

    public override string Pay()
    {
        return $"Thanh toán VNPay: {Amount:N0} VNĐ";
    }
}
