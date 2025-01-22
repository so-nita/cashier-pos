using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.Model.Models.Order;

public class OrderResponse : IResponse
{
    //--public int PosId { get; set; }
    public int ShiftId { get; set; }
    public string OrderId { get; set; } = "";
    public decimal ExchangeRate { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public decimal? Tax { get; set; }
    public decimal Total { get; set; }
    public decimal TotalKh { get; set; }
    public decimal? TotalDiscount { get; set; }
    public DateTime OrderDate { get; set; }
}