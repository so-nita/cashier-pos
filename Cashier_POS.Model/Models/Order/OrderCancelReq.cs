namespace CashierPOS.Model.Models.Order;

public class OrderCancelReq
{
    public string OrderId { get; set; } = string.Empty;
    public string ReasonCode { get; set; } = "";
}