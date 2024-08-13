//public class PaymentRequest
//{
//    public int AccountId { get; set; }
//    public decimal Amount { get; set; }
//    public string Currency { get; set; }
//}

public class PaymentRequest
{
    public int AccountId { get; set; }
    public string CardNumber { get; set; }
    public string ExpiryDate { get; set; }
    public string CVV { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
}