using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.Model.Models.RequestModel.Order;

public class OrderUpdateReq : IUpdateReq
{
    public string Id { get; set; } = null!;
    public string? Source_Id { get; set; } = null!;
    /*public string Reference_Id { get; set; } = null!;*/
    public decimal? Tax { get; set; } = 0;
    public OrderStatus? Order_Status { get; set; }
    public List<OrderDetailUpdateReq> OrderDetails { get; set; } = new ();
}
